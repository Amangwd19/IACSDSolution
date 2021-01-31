using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace DAL
{
  
    public static class DBManager
    {

        public static readonly string connString = string.Empty;
        static DBManager()
        {
            connString = ConfigurationManager.ConnectionStrings["dbString"].ConnectionString;
        }



        public static Vendor GetByIDV(int id)
        {
            Vendor thevendor = new Vendor();

            IDbConnection conn = new MySqlConnection();
            conn.ConnectionString = connString;
            string query = "Select * from vendors WHERE Id=" + id;
            IDbCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd as MySqlCommand);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataRowCollection rows = ds.Tables[0].Rows;
                foreach (DataRow row in rows)
                {
                    thevendor.ID = int.Parse(row["Id"].ToString());
                    thevendor.VName = row["VName"].ToString();
                    thevendor.EmailId = row["EmailId"].ToString();
                    thevendor.Address = row["Address"].ToString();
                 //   thevendor.Quantity = int.Parse(row["Quantity"].ToString());
                 //   thevendor.ImageUrl = row["ImageUrl"].ToString();
                }
            }
            catch (MySqlException e)
            {
                string message = e.Message;
            }
            // implementation 
            return thevendor;
        }
        public static List<Vendor> GetAllVendors()
        {
            List<Vendor> allVendors = new List<Vendor>();


            IDbConnection conn = new MySqlConnection();
            conn.ConnectionString = connString;
            string query = "Select * from vendors";
            IDbCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd as MySqlCommand);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataRowCollection rows = ds.Tables[0].Rows;
                foreach (DataRow row in rows)
                {
                    Vendor thevendor = new Vendor();
                    thevendor.ID = int.Parse(row["Id"].ToString());
                    thevendor.VName = row["VName"].ToString();
                    thevendor.EmailId = row["EmailId"].ToString();
                    thevendor.Address = row["Address"].ToString();
                  //  theproduct.Quantity = int.Parse(row["Quantity"].ToString());
                    allVendors.Add(thevendor);
                }

            }

            catch (MySqlException e)
            {
                string message = e.Message;
            }

            return allVendors;
        }
        public static bool InsertV(Vendor newVendor)
        {
            bool status = false;
            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))   //DI via Constructor
                {
                    if (con.State == ConnectionState.Closed)        //if connection is closed?
                        con.Open();
                    string query = "INSERT INTO vendors (Id,VName ,EmailId, Address) " +
                                                "VALUES (@Id, @VName, @EmailId, @Address)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@Id", newVendor.ID));
                    cmd.Parameters.Add(new MySqlParameter("@VName", newVendor.VName));
                    cmd.Parameters.Add(new MySqlParameter("@EmailId", newVendor.EmailId));
                    cmd.Parameters.Add(new MySqlParameter("@Address", newVendor.Address));
                //    cmd.Parameters.Add(new MySqlParameter("@Quantity", newProduct.Quantity));
                 //   cmd.Parameters.Add(new MySqlParameter("@ImageUrl", newProduct.ImageUrl));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    status = true;
                }
            }
            catch (MySqlException exp)
            {
                string message = exp.Message;
            }
            return status;
        }
        public static bool UpdateV(Vendor existingVendor)
        {
            bool status = false;
            IDbConnection conn = new MySqlConnection();
            conn.ConnectionString = connString;
            IDbCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from vendors";
            cmd.Connection = conn;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd as MySqlCommand);
            DataSet ds = new DataSet();
            try
            {
                MySqlCommandBuilder cmdbuilder = new MySqlCommandBuilder(da);
                da.Fill(ds);
                DataColumn[] keyColumns = new DataColumn[1];
                keyColumns[0] = ds.Tables[0].Columns["Id"];
                ds.Tables[0].PrimaryKey = keyColumns;
                DataRow datarow = ds.Tables[0].Rows.Find(existingVendor.ID);
                datarow["Vname"] = existingVendor.VName;
                datarow["EmailId"] = existingVendor.EmailId;
                datarow["Address"] = existingVendor.Address;
               // datarow["Quantity"] = existingProduct.Quantity;
               // datarow["ImageUrl"] = existingProduct.ImageUrl;
                da.Update(ds);
                status = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                string msg = e.Message;
            }
            return status;
        }

        public static Product GetByID(int id)
        {
            Product theproduct = new Product();

            IDbConnection conn = new MySqlConnection();
            conn.ConnectionString = connString;
            string query = "Select * from flowers WHERE Id=" + id;
            IDbCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd as MySqlCommand);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataRowCollection rows = ds.Tables[0].Rows;
                foreach (DataRow row in rows)
                {
                    theproduct.ID = int.Parse(row["Id"].ToString());
                    theproduct.Title = row["Title"].ToString();
                    theproduct.Description = row["Description"].ToString();
                    theproduct.UnitPrice = double.Parse(row["UnitPrice"].ToString());
                    theproduct.Quantity = int.Parse(row["Quantity"].ToString());
                    theproduct.ImageUrl = row["ImageUrl"].ToString();
                }
            }
            catch (MySqlException e)
            {
                string message = e.Message;
            }
            // implementation 
            return theproduct;
        }

        public static List<Product> GetAllProducts()
        {
            List<Product> allProducts = new List<Product>();


            IDbConnection conn = new MySqlConnection();
            conn.ConnectionString = connString;
            string query = "Select * from flowers";
            IDbCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd as MySqlCommand);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataRowCollection rows = ds.Tables[0].Rows;
                foreach (DataRow row in rows)
                {
                    Product theproduct = new Product();
                    theproduct.ID = int.Parse(row["Id"].ToString());
                    theproduct.Title = row["Title"].ToString();
                    theproduct.Description = row["Description"].ToString();
                    theproduct.UnitPrice = double.Parse(row["UnitPrice"].ToString());
                    theproduct.Quantity = int.Parse(row["Quantity"].ToString());
                    allProducts.Add(theproduct);
                }

            }

            catch (MySqlException e)
            {
                string message = e.Message;
            }

            return allProducts;
        }
        //   public static bool Insert(Product newProduct)
        // public static bool Update(Product existingProduct)
        public static bool Insert(Product newProduct)
        {
            bool status = false;
            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))   //DI via Constructor
                {
                    if (con.State == ConnectionState.Closed)        //if connection is closed?
                        con.Open();
                    string query = "INSERT INTO flowers (Id,Title ,Description, UnitPrice, Quantity, ImageUrl) " +
                                                "VALUES (@Id, @Title, @Description, @UnitPrice, @Quantity,@ImageUrl)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@Id", newProduct.ID));
                    cmd.Parameters.Add(new MySqlParameter("@Title", newProduct.Title));
                    cmd.Parameters.Add(new MySqlParameter("@Description", newProduct.Description));
                    cmd.Parameters.Add(new MySqlParameter("@UnitPrice", newProduct.UnitPrice));
                    cmd.Parameters.Add(new MySqlParameter("@Quantity", newProduct.Quantity));
                    cmd.Parameters.Add(new MySqlParameter("@ImageUrl", newProduct.ImageUrl));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    status = true;
                }
            }
            catch (MySqlException exp)
            {
                string message = exp.Message;
            }
            return status;
        }

        public static bool Update(Product existingProduct)
        {
            bool status = false;
            IDbConnection conn = new MySqlConnection();
            conn.ConnectionString = connString;
            IDbCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from flowers";
            cmd.Connection = conn;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd as MySqlCommand);
            DataSet ds = new DataSet();
            try
            {
                MySqlCommandBuilder cmdbuilder = new MySqlCommandBuilder(da);
                da.Fill(ds);
                DataColumn[] keyColumns = new DataColumn[1];
                keyColumns[0] = ds.Tables[0].Columns["Id"];
                ds.Tables[0].PrimaryKey = keyColumns;
                DataRow datarow = ds.Tables[0].Rows.Find(existingProduct.ID);
                datarow["Title"] = existingProduct.Title;
                datarow["Description"] = existingProduct.Description;
                datarow["UnitPrice"] = existingProduct.UnitPrice;
                datarow["Quantity"] = existingProduct.Quantity;
                datarow["ImageUrl"] = existingProduct.ImageUrl;
                da.Update(ds);
                status = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                string msg = e.Message;
            }
            return status;
        }

        public static bool Delete(int id)
        {
            bool status = false;
            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "DELETE from flowers  WHERE Id=@Id";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@Id", id));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    status = true;
                }
            }
            catch (MySqlException exp)
            {
                string message = exp.Message;
            }
            return status;
        }

        /* public static Product GetByID(int id)
        {
            Product theProduct = new Product();


            IDbConnection conn = new MySqlConnection();
            conn.ConnectionString = connString;
            string query = "Select * from flowers";
            IDbCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd as MySqlCommand);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataRowCollection rows = ds.Tables[0].Rows;
                foreach (DataRow row in rows)
                {
                    Product theproduct = new Product();
                    theproduct.ID = int.Parse(row["Id"].ToString());
                    theproduct.Title = row["Title"].ToString();
                    theproduct.Description = row["Description"].ToString();
                    theproduct.UnitPrice = double.Parse(row["UnitPrice"].ToString());
                    theproduct.Quantity = int.Parse(row["Quantity"].ToString());
                }
            }
            catch (MySqlException e)
            {
                string message = e.Message;
            }

            return theProduct;
        }

        */
    }
}
