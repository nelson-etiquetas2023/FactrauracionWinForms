using System;
using System.Collections.Generic;


namespace FacturaDesktopApp.Models
{
    public class DocumentoFactura
    {
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public Customer customer { get; set; }
        public Boolean Contado { get; set; }
        public Boolean Credito { get; set; }
        public Boolean Impresa { get; set; }
        public Boolean Anulada { get; set; }
        public string Comentarios { get; set; }
        public double SubTotal { get; set; }
        public double Impuesto { get; set; }
        public double MontoTotal_Factura { get; set; }
        public List<Item> items { get; set; }
    }
} 