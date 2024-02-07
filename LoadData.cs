using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacturaDesktopApp.Models;

namespace FacturaDesktopApp
{
    public static class LoadData
    {
        public static List<DocumentoFactura> GetData()
        {

            try
            {
                DocumentoFactura factura = new DocumentoFactura
                {
                    Numero = "1000",
                    Fecha = new DateTime(2024, 1, 12),
                    customer = new Customer
                    {
                        Id_Customer = "1203",
                        Customer_Name = "PANADERIA LA COSTA, S.R."
                    },
                    Contado = true,
                    Impresa = true,
                    Anulada = false,
                    Comentarios = "Entregar con delivery.",
                    SubTotal = 115000,
                    Impuesto = 526.12,
                    MontoTotal_Factura = 115526.12,
                    items = new List<Item>()               

                };

                var items = new List<Item> {
                new Item { Precio = 1200, Cantidad = 50, Id_Product = "12301", Name_Product = "Harina Saco 240 Libras",Imputesto=true,TotalRenglon= 1407.11 },
                new Item { Precio = 1700, Cantidad = 40, Id_Product = "12306", Name_Product = "Mantequilla caja de 24",Imputesto=true,TotalRenglon=1508.33 },
                new Item { Precio = 1200, Cantidad = 30, Id_Product = "12302", Name_Product = "Salsa de Tomate caja de 24",Imputesto=true,TotalRenglon=1304.55 }
            };

                foreach (var item in items) 
                {
                    factura.items.Add(item);
                }                

                List<DocumentoFactura> facturas = new List<DocumentoFactura>
                {
                    factura
                };

                return facturas;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("error al cargar los datos. error code: "+ex.Message);
                return null;
            }
        }
    }
}
