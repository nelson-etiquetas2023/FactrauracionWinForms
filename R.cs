using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDesktopApp
{
    public class R
    {
        public class SERVER
        {
            public static string SERVER_ETIQUETAS = "SERVER-ETIQUETA";
            public static string SERVER_RITRAMA = "RITRAMASRV01";
            public static string SERVER_DELL = "PCDELL";
        }
        public class USERS 
        {
            public static string UserMaster = @"netuser";
            public static string KeyMaster = "password";
        }
        public class SQL 
        {
            public class DATABASES 
            {
                public static string DATAFLOW = "FACTURACION";
            }
            public class TABLES 
            {
                public static string PRODUCTS = "producto";
            }
            public class QUERIES 
            {
                public class PRODUCTS 
                {
                    public static string QUERY_SQL_SELECT_PRODUCT_ALL = "SELECT * FROM product";
                }
                public class CUSTOMERS 
                {
                    public static string QUERY_SQL_SELECT_CUSTOMERS_ALL = "SELECT * FROM CUSTOMER";
                }
                public class FACTURA 
                { 
                    public static string QUERY_SQL_SELECT_HEADER_FACTURA_ALL = "SELECT * FROM ENC_FACTURA";
                    public static string QUERY_SQL_SELECT_DETAILS_FACTURA_ALL = "SELECT * FROM DETALLE_FACTURA";
                }
            }
        
        }
        public class MESSAGE_APPLICATION
        {
            public class MESSAGE_PRODUCTS 
            {
                public static string SELECT_LOAD_ALL_DATA_PRODUCTS_ERROR = "Hubo un error al cargar losm datos de productos correctsmente...";
            }
            public class MESSAGES_CUSTOMERS 
            {
                public static string SELECT_LOAD_ALL_DATA_CUSTOMERS_ERROR = "Hubo un error en la carga de los datos de clientes correctsmente...";
            }
            public class MESSAGE_FACTURAS 
            {
                public static string SELECT_LOAD_ALL_DATA_FACTURA_ERROR = "Hubo un error al cargas los header de factura...";
                public static string SELECT_LOAD_ALL_DATA_DETAILS_FACTURA_ERROR = "Hubo un error al cargar los renglones de facturas...";
            }


        }        
    }
    public class ERRORS_SQL 
    {
        public class SQL_CONNECT { }
        public class ERROR_PRODUCTS { }
        public class ERROR_CUSTOMERS { }
        public class ERROR_FACTURAS { }
    }
    public class PATH_FILES { }
    public class PARAMETERS { }
    
}
