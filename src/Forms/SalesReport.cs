using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Services;
using kiosko_ssms.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace kiosko_ssms.Forms
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
            FillReportTypes();
        }
        private void SalesReport_Load(object sender, EventArgs e)
        {
            GenerateIncomeVsTaxesReport(DateTime.Now, false);
        }

        private void GenerateIncomeVsTaxesReport(DateTime date, bool viewByYear)
        {
            ClearChart(chart1);

            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Interval = 1;
            area.AxisX.Title = viewByYear ? "MES" : "CONCEPTO";
            area.AxisY.Title = $"MONTO ({Properties.Settings.Default.currencyShortName})";
            chart1.ChartAreas.Add(area);

            Series incomeSeries = new Series("INGRESOS")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.FromArgb(46, 204, 113),
                IsValueShownAsLabel = true,
                LabelFormat = "N2"
            };

            Series taxesSeries = new Series("IMPUESTOS")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.FromArgb(207, 62, 45),
                IsValueShownAsLabel = true,
                LabelFormat = "N2"
            };

            List<Voucher> vouchers = new List<Voucher>();

            using (var context = new AppDbContext())
            {
                if (viewByYear)
                {
                    int year = date.Year;
                    DateTime startDate = new DateTime(year, 1, 1);
                    DateTime endDate = new DateTime(year, 12, 31);

                    vouchers = new VoucherService(context).GetAllVouchersBetweenDates(startDate, endDate, false);
                    if (!vouchers.Any())
                    {
                        MessageBox.Show(Constants.Messages.Error.YEAR_WITHOUT_VOUCHERS, Constants.Messages.Error.ERROR_TAG, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    var monthlyData = vouchers
                        .GroupBy(v => v.CreatedAt.Month)
                        .Select(g => new
                        {
                            Month = g.Key,
                            TotalIncome = g.Sum(v => v.VoucherDetails.Sum(d => d.Product.Profit * d.Amount)),
                            TotalTaxes = g.Sum(v => v.Igv)
                        })
                        .OrderBy(d => d.Month)
                        .ToList();

                    for (int month = 1; month <= 12; month++)
                    {
                        var data = monthlyData.FirstOrDefault(d => d.Month == month);
                        decimal income = data?.TotalIncome ?? 0;
                        double taxes = data?.TotalTaxes ?? 0;
                        string monthName = new DateTime(year, month, 1).ToString("MMMM").ToUpper();

                        incomeSeries.Points.AddXY(monthName, income);
                        taxesSeries.Points.AddXY(monthName, taxes);
                    }

                    chart1.Titles.Add($"INGRESOS VS IMPUESTOS - {year}");
                }
                else
                {
                    int year = date.Year;
                    int month = date.Month;
                    DateTime startDate = new DateTime(year, month, 1);
                    DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                    vouchers = new VoucherService(context).GetAllVouchersBetweenDates(startDate, endDate, false);
                    if (!vouchers.Any())
                    {
                        MessageBox.Show(Constants.Messages.Error.MONTH_WITHOUT_VOUCHERS, Constants.Messages.Error.ERROR_TAG, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    decimal totalIncome = vouchers.Sum(v => v.VoucherDetails.Sum(d => d.Product.Profit * d.Amount));
                    double totalTaxes = vouchers.Sum(v => v.Igv);

                    string monthName = date.ToString("MMMM").ToUpper();

                    incomeSeries.Points.AddXY("INGRESOS", totalIncome);
                    taxesSeries.Points.AddXY("IMPUESTOS", totalTaxes);

                    chart1.Titles.Add($"INGRESOS VS IMPUESTOS - {monthName} {year}");
                }
            }

            chart1.Series.Add(incomeSeries);
            chart1.Series.Add(taxesSeries);
            lblStatus.Text = $"GRAFICO REFRESCADO: {DateTime.Now}";
        }

        private void GenerateBestSellingProductsReport(DateTime date, bool viewByYear)
        {
            ClearChart(chart1);

            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Interval = 1;
            area.AxisX.Title = viewByYear ? "MES" : "PRODUCTO";
            area.AxisY.Title = "CANTIDAD VENDIDA";
            chart1.ChartAreas.Add(area);

            Series productSeries = new Series("VENTAS")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.FromArgb(46, 204, 113),
                IsValueShownAsLabel = true,
                LabelFormat = "N0"
            };

            List<Voucher> vouchers = new List<Voucher>();

            using (var context = new AppDbContext())
            {
                if (viewByYear)
                {
                    int year = date.Year;
                    DateTime startDate = new DateTime(year, 1, 1);
                    DateTime endDate = new DateTime(year, 12, 31);

                    vouchers = new VoucherService(context).GetAllVouchersBetweenDates(startDate, endDate, false);
                    if (!vouchers.Any())
                    {
                        MessageBox.Show(Constants.Messages.Error.YEAR_WITHOUT_VOUCHERS, Constants.Messages.Error.ERROR_TAG, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    var bestByMonth = vouchers
                        .GroupBy(v => v.CreatedAt.Month)
                        .Select(g => new
                        {
                            Month = g.Key,
                            BestProduct = g.SelectMany(v => v.VoucherDetails)
                                           .GroupBy(d => d.Product.Name)
                                           .Select(pg => new { Product = pg.Key, Quantity = pg.Sum(d => d.Amount) })
                                           .OrderByDescending(pg => pg.Quantity)
                                           .FirstOrDefault()
                        })
                        .OrderBy(m => m.Month)
                        .ToList();

                    for (int month = 1; month <= 12; month++)
                    {
                        var data = bestByMonth.FirstOrDefault(d => d.Month == month);
                        if (data?.BestProduct != null)
                        {
                            string monthName = new DateTime(year, month, 1).ToString("MMMM").ToUpper();
                            string label = $"{monthName}\n({data.BestProduct.Product})";

                            productSeries.Points.AddXY(label, data.BestProduct.Quantity);
                        }
                        else
                        {
                            string monthName = new DateTime(year, month, 1).ToString("MMMM").ToUpper();
                            productSeries.Points.AddXY(monthName, 0);
                        }
                    }

                    chart1.Titles.Add($"PRODUCTO MÁS VENDIDO POR MES - {year}");
                }
                else
                {
                    int year = date.Year;
                    int month = date.Month;
                    DateTime startDate = new DateTime(year, month, 1);
                    DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                    vouchers = new VoucherService(context).GetAllVouchersBetweenDates(startDate, endDate, false);
                    if (!vouchers.Any())
                    {
                        MessageBox.Show(Constants.Messages.Error.MONTH_WITHOUT_VOUCHERS, Constants.Messages.Error.ERROR_TAG, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    var topProducts = vouchers
                        .SelectMany(v => v.VoucherDetails)
                        .GroupBy(d => d.Product.Name)
                        .Select(pg => new { Product = pg.Key, Quantity = pg.Sum(d => d.Amount) })
                        .OrderByDescending(pg => pg.Quantity)
                        .Take(10)
                        .ToList();

                    foreach (var p in topProducts)
                    {
                        productSeries.Points.AddXY(p.Product, p.Quantity);
                    }

                    string monthName = date.ToString("MMMM").ToUpper();
                    chart1.Titles.Add($"TOP 10 PRODUCTOS MÁS VENDIDOS - {monthName} {year}");
                }
            }

            chart1.Series.Add(productSeries);
            lblStatus.Text = $"GRAFICO REFRESCADO: {DateTime.Now}";
        }

        private void GenerateSalesCountReport(DateTime date, string mode)
        {
            ClearChart(chart1);

            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Interval = 1;
            area.AxisY.Title = "NÚMERO DE VENTAS";
            chart1.ChartAreas.Add(area);

            Series salesSeries = new Series("VENTAS")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.FromArgb(46, 204, 113),
                IsValueShownAsLabel = true,
                LabelFormat = "N0"
            };

            List<Voucher> vouchers = new List<Voucher>();

            using (var context = new AppDbContext())
            {
                if (mode == "DAY")
                {
                    DateTime startDate = date.Date;
                    DateTime endDate = date.Date.AddDays(1).AddTicks(-1);

                    vouchers = new VoucherService(context).GetAllVouchersBetweenDates(startDate, endDate, false);

                    int salesCount = vouchers.Count;
                    string label = date.ToString("dd/MM/yyyy");
                    salesSeries.Points.AddXY(label, salesCount);

                    chart1.Titles.Add($"VENTAS DEL DÍA {label}");
                }
                else if (mode == "MONTH")
                {
                    int year = date.Year;
                    int month = date.Month;
                    DateTime startDate = new DateTime(year, month, 1);
                    DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                    vouchers = new VoucherService(context).GetAllVouchersBetweenDates(startDate, endDate, false);

                    var dailyCounts = vouchers
                        .GroupBy(v => v.CreatedAt.Day)
                        .Select(g => new { Day = g.Key, Count = g.Count() })
                        .OrderBy(g => g.Day)
                        .ToList();

                    int daysInMonth = DateTime.DaysInMonth(year, month);
                    for (int day = 1; day <= daysInMonth; day++)
                    {
                        int count = dailyCounts.FirstOrDefault(d => d.Day == day)?.Count ?? 0;
                        salesSeries.Points.AddXY(day.ToString(), count);
                    }

                    string monthName = date.ToString("MMMM").ToUpper();
                    chart1.Titles.Add($"VENTAS POR DÍA - {monthName} {year}");
                    area.AxisX.Title = "DÍA";
                }
                else if (mode == "YEAR")
                {
                    int year = date.Year;
                    DateTime startDate = new DateTime(year, 1, 1);
                    DateTime endDate = new DateTime(year, 12, 31);

                    vouchers = new VoucherService(context).GetAllVouchersBetweenDates(startDate, endDate, false);

                    var monthlyCounts = vouchers
                        .GroupBy(v => v.CreatedAt.Month)
                        .Select(g => new { Month = g.Key, Count = g.Count() })
                        .OrderBy(g => g.Month)
                        .ToList();

                    for (int month = 1; month <= 12; month++)
                    {
                        int count = monthlyCounts.FirstOrDefault(m => m.Month == month)?.Count ?? 0;
                        string monthName = new DateTime(year, month, 1).ToString("MMM").ToUpper();
                        salesSeries.Points.AddXY(monthName, count);
                    }

                    chart1.Titles.Add($"VENTAS POR MES - {year}");
                    area.AxisX.Title = "MES";
                }
            }

            chart1.Series.Add(salesSeries);
            lblStatus.Text = $"GRAFICO REFRESCADO: {DateTime.Now}";
        }



        private void ClearChart(Chart chart)
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Titles.Clear();
        }

        private void FillReportTypes()
        {
            cbType.DataSource = Constants.ReportTypes;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            GenerateIncomeVsTaxesReport(DateTime.Now, false);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            switch (cbType.SelectedIndex)
            {
                case 0: //Incomes vs Taxes - By Month
                    GenerateIncomeVsTaxesReport(dtpDate.Value, false);
                    break;
                case 1: //Incomes vs Taxes - By Year
                    GenerateIncomeVsTaxesReport(dtpDate.Value, true);
                    break;
                case 2: //Best Selling Products - By Month
                    GenerateBestSellingProductsReport(dtpDate.Value, false);
                    break;
                case 3: //Best Selling Products - By Year
                    GenerateBestSellingProductsReport(dtpDate.Value, true);
                    break;
                case 4: //Number of Sales - By Day
                    GenerateSalesCountReport(dtpDate.Value, "DAY");
                    break;
                case 5: //Number of Sales - By Month
                    GenerateSalesCountReport(dtpDate.Value, "MONTH");
                    break;
                case 6: //Number of Sales - By Year
                    GenerateSalesCountReport(dtpDate.Value, "YEAR");
                    break;
                default: break;
            }
        }
    }
}
