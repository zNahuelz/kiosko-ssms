using kiosko_ssms.Data.Entities;
using System.Collections.Generic;

namespace kiosko_ssms.Utils
{
    public static class Constants
    {
        public static readonly List<string> ProductSearchModes = new List<string> { "POR NOMBRE", "POR COD. BARRAS", "POR DESCRIPCIÓN", "POR PROVEEDOR", "POR PRESENTACIÓN" };
        public static readonly List<string> SupplierSearchModes = new List<string> { "POR NOMBRE", "POR RUC" };
        public static readonly List<string> VisibilityOptions = new List<string> { "MOSTRAR ELIMINADOS", "OCULTAR ELIMINADOS" };
        public static readonly List<string> CustomerSearchModes = new List<string> { "POR NOMBRE", "POR DNI" };
        public static readonly List<string> PresentationSearchModes = new List<string> { "POR ID", "POR NOMBRE", "POR UNIDAD" };
        public static readonly List<string> VoucherSearchModes = new List<string> { "POR ID", "POR DNI", "POR FECHA" };
        public static readonly List<string> ReportTypes = new List<string> { "INGRESOS VS IMPUESTOS - POR MES", "INGRESOS VS IMPUESTOS - POR AÑO", "PRODUCTOS MÁS VENDIDOS - POR MES", "PRODUCTOS MÁS VENDIDOS - POR AÑO", "CANTIDAD DE VENTAS - POR DÍA", "CANTIDAD DE VENTAS - POR MES", "CANTIDAD DE VENTAS - POR AÑO" };
        public static readonly List<StartupOption> StartupOptions = new List<StartupOption>
        {
            new StartupOption { FormName = "DISABLED", Tag = "DESACTIVADO" },
            new StartupOption { FormName = "SALES_FORM", Tag = "VENTAS" },
            new StartupOption { FormName = "REPORTS_FORM", Tag = "REPORTES" },
        };

        public static class Messages
        {
            public static class Success
            {
                public static string SUCCESS_TAG = "OPERACIÓN COMPLETADA";
                public static string CUSTOMER_UPDATED(string names, string surnames) { return $"Cliente {names} {surnames} actualizado correctamente."; }
                public static string PRESENTATION_UPDATED(string name) { return $"Presentación {name} actualizada correctamente."; }
                public static string SALE_SAVED(string hash, int id, Customer customer) { return $"Venta guardada correctamente. Asignado hash: {hash} y ID: {id}. \nCLIENTE: {customer.Names.ToUpper()} {customer.Surnames.ToUpper()}"; }
            }
            public static class Error
            {
                public static string ERROR_TAG = "OPERACIÓN FALLIDA";
                public static string DB_CONN_FAILED = "Ha fallado la conexión con la base de datos. \n DETALLES: \n";
                public static string CUSTOMER_NOT_FOUND = "Cliente no encontrado.";
                public static string CUSTOMER_NOT_FOUND_BY_DNI = "No se encontró ningún cliente con el DNI proporcionado.";
                public static string CUSTOMER_UPDATE_FAILED = "No se pudo actualizar el cliente. Intente nuevamente. \n DETALLES: \n";
                public static string PRESENTATION_NOT_FOUND_BY_ID = "No se encontró ninguna presentación con el ID proporcionado.";
                public static string DUPLICATED_PRESENTATION = "Ya existe una presentación con el mismo nombre, cantidad y unidad.";
                public static string PRESENTATION_UPDATE_FAILED(string ex) { return $"Ocurrió un error al actualizar la presentación: {ex}"; }
                public static string PRESENTATIONS_LOAD_FAILED = "Imposible cargar el listado de presentaciones de productos. La busqueda de productos por esta característica se encuentra deshabilitada.";
                public static string SUPPLIERS_LOAD_FAILED = "Imposible cargar el listado de proveedores. La busqueda de productos por esta característica se encuentra deshabilitada.";
                public static string PRESENTATION_LOAD_FAILED_CREATE_PRODUCT_DISABLED = "Imposible cargar el listado de presentaciones de productos. La creación de productos se encuentra deshabilitada. Debe tener presentaciones registradas previamente.";
                public static string SUPPLIERS_LOAD_FAILED_CREATE_PRODUCT_DISABLED = "Imposible cargar el listado de proveedores. La creación de productos se encuentra deshabilitada. Debe tener proveedores registrados previamente.";
                public static string CUSTOMER_NOT_FOUND_BY_DNI_SALES_MODULE = "No se encontró ningún cliente con el DNI proporcionado. Intente nuevamente o realice la venta con DNI 0";
                public static string PRODUCT_NOT_FOUND_BY_BARCODE = "No se encontró el producto con el código de barras proporcionado. Intente nuevamente.";
                public static string PAYMENT_TYPES_NOT_LOADED = "No se encontraron métodos de pago para realizar la venta. Intente nuevamente o registre algunos.";
                public static string VOUCHER_TYPES_NOT_LOADED = "No se encontraron tipos de pago para realizar la venta. Intente nuevamente o registra algunos.";
                public static string SALE_SAVE_FAILED = "Error al guardar la venta, intente nuevamente.";
                public static string ID_NOT_INTEGER = "El ID debe ser un número entero válido.";
                public static string YEAR_WITHOUT_VOUCHERS = "No se encontraron ventas registradas en el año seleccionado.";
                public static string MONTH_WITHOUT_VOUCHERS = "No se encontraron ventas registradas en el mes seleccionado.";
                public static string UNEXPECTED_ERROR = "Ha ocurrido un error inesperado. \n DETALLES: \n";
            }

            public static class Info
            {
                public static string NO_BROWSER_FOUND = "Parece que no tienes ningún navegador web instalado en este PC :(";
                public static string COPIED_DNI = "DNI copiado al portapapeles!";
                public static string COPIED_EMAIL = "Email copiado al portapapeles!";
                public static string COPIED_ID = "ID copiado al portapapeles!";
            }
        }

        public class StartupOption
        {
            public string FormName { get; set; }
            public string Tag { get; set; }
        }
    }
}
