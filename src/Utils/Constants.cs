using System.Collections.Generic;

namespace kiosko_ssms.Utils
{
    public class Constants
    {
        public static List<string> ProductSearchModes = new List<string> { "POR NOMBRE", "POR COD. BARRAS", "POR DESCRIPCIÓN", "POR PROVEEDOR", "POR PRESENTACIÓN" };
        public static List<string> SupplierSearchModes = new List<string> { "POR NOMBRE", "POR RUC" };
        public static List<string> VisibilityOptions = new List<string> { "MOSTRAR ELIMINADOS", "OCULTAR ELIMINADOS" };
        public static List<string> CustomerSearchModes = new List<string> { "POR NOMBRE", "POR DNI" };
    }
}
