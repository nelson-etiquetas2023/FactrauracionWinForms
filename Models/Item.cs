using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDesktopApp.Models
{
    public class Item
    {

        public string Id_Product { get; set; }
        public string Name_Product { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }
        public Boolean Imputesto { get; set; }
        public double TotalRenglon { get; set; }

    }
}
