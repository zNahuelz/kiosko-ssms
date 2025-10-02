using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using kiosko_ssms.Data.Entities;
using System;
using System.IO;

namespace kiosko_ssms.Utils
{
    public static class PdfGenerator
    {
        public static string GenerateVoucher(Voucher voucher, string filePath = null)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                string appFolder = AppDomain.CurrentDomain.BaseDirectory;
                string vouchersFolder = Path.Combine(appFolder, "vouchers");
                if (!Directory.Exists(vouchersFolder))
                {
                    Directory.CreateDirectory(vouchersFolder);
                }
                filePath = Path.Combine(vouchersFolder, $"{voucher.SaleSerial}_{DateTime.Now:dd_MM_yyyy}.pdf");
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document doc = new Document(PageSize.A4, 50, 50, 25, 25);
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                LineSeparator line = new LineSeparator(1f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, -1);
                doc.Add(new Paragraph(Properties.Settings.Default.companyName?.Trim().ToUpper(), titleFont) { Alignment = Element.ALIGN_CENTER });
                doc.Add(new Paragraph($"RUC.: {Properties.Settings.Default.companyTaxId}") { Alignment = Element.ALIGN_CENTER });
                doc.Add(new Paragraph($"{Properties.Settings.Default.companyAddress}") { Alignment = Element.ALIGN_CENTER });
                doc.Add(new Paragraph(
                    voucher.VoucherType.Name?.Trim().ToUpper() == "BOLETA"
                        ? "BOLETA DE VENTA ELECTRÓNICA"
                        : voucher.VoucherType.Name?.Trim().ToUpper(),
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)
                )
                { Alignment = Element.ALIGN_CENTER });
                doc.Add(new Paragraph($"{voucher.SaleSerial}") { Alignment = Element.ALIGN_CENTER });

                doc.Add(new Chunk(line));
                doc.Add(new Paragraph($"Fecha y Hora de Emisión: {DateTime.Now:dd/MM/yyyy HH:mm:ss}"));
                doc.Add(new Paragraph($"Cliente: {voucher.Customer.Names} {voucher.Customer.Surnames}"));
                doc.Add(new Paragraph($"DOC. ID.: {(voucher.Customer.Dni == "00000000" ? "0" : voucher.Customer.Dni)}"));
                doc.Add(new Paragraph($"Caja: CAJA 01"));
                doc.Add(new Paragraph($"Forma de Pago: {voucher.PaymentType.Name?.Trim().ToUpper()}"));
                doc.Add(new Chunk(line));


                PdfPTable table = new PdfPTable(3);
                table.WidthPercentage = 100;

                PdfPCell cell1 = new PdfPCell(new Phrase("CANT."));
                cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                table.AddCell(cell1);

                PdfPCell cell2 = new PdfPCell(new Phrase("PRODUCTO"));
                cell2.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell2);

                PdfPCell cell3 = new PdfPCell(new Phrase("TOTAL"));
                cell3.HorizontalAlignment = Element.ALIGN_RIGHT;
                table.AddCell(cell3);

                foreach (var detail in voucher.VoucherDetails)
                {
                    PdfPCell c1 = new PdfPCell(new Phrase(detail.Amount.ToString()));
                    c1.HorizontalAlignment = Element.ALIGN_LEFT;
                    table.AddCell(c1);

                    PdfPCell c2 = new PdfPCell(new Phrase(detail.Product.Name));
                    c2.HorizontalAlignment = Element.ALIGN_LEFT;
                    table.AddCell(c2);

                    PdfPCell c3 = new PdfPCell(new Phrase(Math.Round(detail.Subtotal, 2).ToString("F2")));
                    c3.HorizontalAlignment = Element.ALIGN_RIGHT;
                    table.AddCell(c3);
                }

                doc.Add(table);

                doc.Add(new Paragraph($"\nSUBTOTAL {Properties.Settings.Default.currencyShortName?.Trim().ToUpper()}: {Math.Round(voucher.Subtotal, 2)}") { Alignment = Element.ALIGN_RIGHT });
                doc.Add(new Paragraph($"{Properties.Settings.Default.taxName?.Trim().ToUpper()} ({voucher.Tax * 100}%) {Properties.Settings.Default.currencyShortName?.Trim().ToUpper()}: {Math.Round(voucher.Igv, 2)}") { Alignment = Element.ALIGN_RIGHT });
                doc.Add(new Paragraph($"CAMBIO {Properties.Settings.Default.currencyShortName?.Trim().ToUpper()}: {Math.Round(voucher.Change, 2)}") { Alignment = Element.ALIGN_RIGHT });
                doc.Add(new Paragraph($"TOTAL {Properties.Settings.Default.currencyShortName?.Trim().ToUpper()}: {Math.Round(voucher.Total, 2)}") { Alignment = Element.ALIGN_RIGHT });

                doc.Close();
                writer.Close();
            }

            return filePath;
        }
    }
}
