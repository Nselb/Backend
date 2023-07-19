namespace Backend.Models.Varios
{
    public class TipoOperacion
    {
        public string CodigoTipooperacion { get; set; }
        public string NombreOperacion { get; set; }
    }
    public class MovimientosExcepcion1y2
    {
        public string CodigoMovimientoExce { get; set; }
        public string DesripMovimientoExce { get; set; }
    }
    public class MovimientosExcepcion3
    {
        public string CodigoMovimientoExce { get; set; }
        public string DesripMovimientoExce { get; set; }
    }
    public class TrabaAfectaIESS
    {
        public string CodigoMovimientoExce { get; set; }
        public string DesripMovimientoExce { get; set; }
    }
    public class TrabAfecImpuestoRenta
    {
        public string CodigoMovimientoExce { get; set; }
        public string DesripMovimientoExce { get; set; }
    }
    public class InfoGeneral
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
    }
    public class Info
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
    }

    public class CuentaContable
    {
        public int Sucursal { get; set; }
        public int CodigoConceptoNomina { get; set; }
        public string DescripcionConcepto { get; set; } = "";
        public int CodigoCategoriaocupacional { get; set; }
        public string DescripcionCategoria { get; set; } = "";
        public string CodigoOperacion { get; set; } = "";
        public float CodigoCuentaContable { get; set; }
        public string CodigoTipoCuenta { get; set; } = "";
        public string DescripcionCuenta { get; set; } = "";
        public string Mensaje { get; set; } = "";
    }

    public class PlanDeCuentas
    {
        public string CodigoTipoCuenta { get; set; } = "";
        public float Cuenta { get; set; }
        public string CuentaCaracter { get; set; } = "";
        public string DescripcionCuenta { get; set; } = "";
        public string Auxiliar_Controla_Cuenta { get; set; } = "";
        public string Estado { get; set; } = "";
    }


}
