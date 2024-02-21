using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturaDesktopApp.Services
{
    public class FacturaService
    {
        readonly Conexion micomm = new Conexion();
        public DataSet ds = new DataSet();
        readonly SqlDataAdapter daproductos = new SqlDataAdapter();
        readonly SqlDataAdapter dacustomers = new SqlDataAdapter();
        readonly SqlDataAdapter daHeaderFactura = new SqlDataAdapter();
        readonly SqlDataAdapter daDetailFactura = new SqlDataAdapter();
        readonly DataTable dtproductos = new DataTable();
        readonly DataTable dtcustomers = new DataTable();
        readonly DataTable dtHeaderFactura = new DataTable();
        readonly DataTable dtDetailFactura = new DataTable();

        public FacturaService()
        {
            LoadTables();
            LoadRelaciones();
        }
        public Boolean CommandSQLloadDS(string db, string query, SqlDataAdapter da, string dt, List<SqlParameter> parameters, Boolean msg, string messagError)
        {
            try
            {
                micomm.Conectar(db);
                SqlCommand comando = new SqlCommand
                {
                    Connection = micomm.cnn,
                    CommandType = CommandType.Text,
                    CommandText = query,
                };
                if (parameters.Count > 0)
                {
                    foreach (SqlParameter item in parameters)
                    {
                        comando.Parameters.Add(item);
                    }
                }
                comando.ExecuteNonQuery();
                da.SelectCommand = comando;
                da.Fill(ds, dt);

                comando.Dispose();
                micomm.Desconectar();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(messagError + " " + ex);
                return false;
            }
        }

        public void LoadTables()
        {
            LoadTableProducts();
            LoadTableCustomers();
            LoadTableFactura();
            LoadDetalleFacturas();
        }
        public Boolean LoadDetalleFacturas() 
        {
            //Carga de detalle de facturas.
            try
            {
                List<SqlParameter> spc = new List<SqlParameter>();
                CommandSQLloadDS(R.SQL.DATABASES.DATAFLOW, R.SQL.QUERIES.FACTURA.QUERY_SQL_SELECT_DETAILS_FACTURA_ALL,
                    daDetailFactura, "dtdetailFactura", spc, true,
                    R.MESSAGE_APPLICATION.MESSAGE_FACTURAS.SELECT_LOAD_ALL_DATA_DETAILS_FACTURA_ERROR);

                return true;
            }
            catch (SqlException ex)
            {
                var error = ex.Message;
                return false;
            }
        }
        public Boolean LoadTableFactura() 
        {
            //Carga del header de factura.
            try
            {
                List<SqlParameter> spc = new List<SqlParameter>();
                CommandSQLloadDS(R.SQL.DATABASES.DATAFLOW,
                    R.SQL.QUERIES.FACTURA.QUERY_SQL_SELECT_HEADER_FACTURA_ALL,
                    daHeaderFactura,"dtheaderfactura",spc,true,
                    R.MESSAGE_APPLICATION.MESSAGE_FACTURAS.SELECT_LOAD_ALL_DATA_FACTURA_ERROR);
                return true;
            }
            catch (SqlException ex)
            {
                var error = ex.Message;
                return false;
            }
           
        }
        public Boolean LoadTableProducts() 
        {
            try
            {
                // carga de productos.
                List<SqlParameter> spc = new List<SqlParameter>();
                //cargar la tabla de productos
                CommandSQLloadDS(R.SQL.DATABASES.DATAFLOW,
                    R.SQL.QUERIES.PRODUCTS.QUERY_SQL_SELECT_PRODUCT_ALL,
                    daproductos, "dtproductos", spc, true,
                    R.MESSAGE_APPLICATION.MESSAGE_PRODUCTS.SELECT_LOAD_ALL_DATA_PRODUCTS_ERROR);
                return true;
            }
            catch (Exception)
            {
               
                return false;
            }
        }
        public Boolean LoadTableCustomers() 
        {
            try
            {
                List<SqlParameter> spc = new List<SqlParameter>();
                CommandSQLloadDS(R.SQL.DATABASES.DATAFLOW,
                    R.SQL.QUERIES.CUSTOMERS.QUERY_SQL_SELECT_CUSTOMERS_ALL,
                    dacustomers, "dtcustomers", spc, true,
                    R.MESSAGE_APPLICATION.MESSAGES_CUSTOMERS.SELECT_LOAD_ALL_DATA_CUSTOMERS_ERROR);
            
                return true;
            }
            catch (SqlException ex)
            {
                var error = ex.Message;
                return false;   
            }
        }
        public Boolean LoadRelaciones() 
        {
            try 
            {
                //relacion factura productos.
                DataColumn ParentCol1 = ds.Tables["dtproductos"].Columns["product_id"];
                DataColumn ChildColo1 = ds.Tables["dtDetailFactura"].Columns["product_id"];
                DataRelation factura_productos = new DataRelation("FK_FACTURAS_PRODUCTOS",ParentCol1,ChildColo1);
                ds.Relations.Add(factura_productos);
                ds.Tables["dtDetailFactura"].Columns.Add("product_name", Type.GetType("System.String"), 
                "parent(FK_FACTURAS_PRODUCTOS).product_name");

                //Relacion Facturas-Customers.
                DataColumn ParentColumn2 = ds.Tables["dtcustomers"].Columns["customer_id"];
                DataColumn ChildColumn2 = ds.Tables["dtheaderfactura"].Columns["customer_id"];
                DataRelation factura_customers = new DataRelation("FK_FACTURAS_CUSTOMERS", ParentColumn2, ChildColumn2);
                ds.Relations.Add(factura_customers);
                ds.Tables["dtheaderfactura"].Columns.Add("customer_name", Type.GetType("System.String"),
                "parent(FK_FACTURAS_CUSTOMERS).description_customer");

                //Relacion Encabezado Detalle.
                DataColumn ParentColumn3 = ds.Tables["dtheaderfactura"].Columns["numero"];
                DataColumn ChildColumn3 = ds.Tables["dtdetailfactura"].Columns["numero"];
                DataRelation factura_detalle = new DataRelation("FK_FACTURA_DETALLE", ParentColumn3, ChildColumn3);
                ds.Relations.Add(factura_detalle);
                return true; 
            } catch(SqlException ex) 
            {
                MessageBox.Show("error al establecer las relaciones de las tablas: " + ex);
                return false;
            }
        }
    }
}
