using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;


namespace FlowerShop.Models
{
    public class ConnectionCart
    {

        public string conString = "server=localhost;database=flowershop;uid=root;pwd=toor;SslMode=none";
        private string procedureName = "cart_procedure";
        private string dbname = "flowershop";

        /*
         *getUserCart by clietnId
         */
        public DataTable getUserCart(int clietnId)
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",9),
                    new MySqlParameter("cId",clietnId),      //clientId
                    new MySqlParameter("pId",0),             //productId
                    new MySqlParameter("pA",0),              //productAmount
                    
                };
                if (con.State == ConnectionState.Open)
                {
                    con.ChangeDatabase(dbname);
                    MySqlCommand cmd = new MySqlCommand(procedureName, con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (parameters != null)
                    {
                        foreach (MySqlParameter param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(dat);
                }
                return dat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Clone();
                }
            }

        }


        /*
        *clearUserCart by clietnId
        */
        public DataTable clearUserCart(int clietnId)
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",6),
                    new MySqlParameter("cId",clietnId),      //clientId
                    new MySqlParameter("pId",0),             //productId
                    new MySqlParameter("pA",0),              //productAmount
                    
                };
                if (con.State == ConnectionState.Open)
                {
                    con.ChangeDatabase(dbname);
                    MySqlCommand cmd = new MySqlCommand(procedureName, con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (parameters != null)
                    {
                        foreach (MySqlParameter param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(dat);
                }
                return dat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Clone();
                }
            }

        }




        /*
         *setCartProductAmount by clientId & productId
         */
        public DataTable SetCartProductAmount(int clietnId,int productId,int Amount)
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",2),
                    new MySqlParameter("cId",clietnId),            //clientId
                    new MySqlParameter("pId",productId),           //productId
                    new MySqlParameter("pA",Amount),               //productAmount
                    
                };
                if (con.State == ConnectionState.Open)
                {
                    con.ChangeDatabase(dbname);
                    MySqlCommand cmd = new MySqlCommand(procedureName, con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (parameters != null)
                    {
                        foreach (MySqlParameter param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(dat);
                }
                return dat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Clone();
                }
            }

        }




        /*
         *setCartProductAmount by clientId & productId and get all table 
         */
        public DataTable AdminSetCartProductAmount(int clietnId, int productId, int Amount)
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",21),
                    new MySqlParameter("cId",clietnId),            //clientId
                    new MySqlParameter("pId",productId),           //productId
                    new MySqlParameter("pA",Amount),               //productAmount
                    
                };
                if (con.State == ConnectionState.Open)
                {
                    con.ChangeDatabase(dbname);
                    MySqlCommand cmd = new MySqlCommand(procedureName, con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (parameters != null)
                    {
                        foreach (MySqlParameter param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(dat);
                }
                return dat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Clone();
                }
            }

        }


        /*
         *  addCartProduct
         */
        public DataTable addCartProduct(int clietnId, int productId,int Amount)
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",3),
                    new MySqlParameter("cId",clietnId),           //clientId
                    new MySqlParameter("pId",productId),          //productId
                    new MySqlParameter("pA",Amount),              //productAmount
                    
                };
                if (con.State == ConnectionState.Open)
                {
                    con.ChangeDatabase(dbname);
                    MySqlCommand cmd = new MySqlCommand(procedureName, con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (parameters != null)
                    {
                        foreach (MySqlParameter param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(dat);
                }
                return dat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Clone();
                }
            }

        }



        /*
         *  addCartProduct and get all table
         */
        public DataTable adminAddCartProduct(int clietnId, int productId, int Amount)
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",31),
                    new MySqlParameter("cId",clietnId),           //clientId
                    new MySqlParameter("pId",productId),          //productId
                    new MySqlParameter("pA",Amount),              //productAmount
                    
                };
                if (con.State == ConnectionState.Open)
                {
                    con.ChangeDatabase(dbname);
                    MySqlCommand cmd = new MySqlCommand(procedureName, con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (parameters != null)
                    {
                        foreach (MySqlParameter param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(dat);
                }
                return dat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Clone();
                }
            }

        }


        /*
         *  removeCartItem
         */
        public DataTable removeCartItem(int clietnId, int productId)
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",5),
                    new MySqlParameter("cId",clietnId),           //clientId
                    new MySqlParameter("pId",productId),          //productId
                    new MySqlParameter("pA",0),                     //productAmount
                    
                };
                if (con.State == ConnectionState.Open)
                {
                    con.ChangeDatabase(dbname);
                    MySqlCommand cmd = new MySqlCommand(procedureName, con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (parameters != null)
                    {
                        foreach (MySqlParameter param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(dat);
                }
                return dat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Clone();
                }
            }

        }


        /*
        *  removeCartItem and get all the table
        */
        public DataTable AdminRemoveCartItem(int clietnId, int productId)
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",51),
                    new MySqlParameter("cId",clietnId),           //clientId
                    new MySqlParameter("pId",productId),          //productId
                    new MySqlParameter("pA",0),                     //productAmount
                    
                };
                if (con.State == ConnectionState.Open)
                {
                    con.ChangeDatabase(dbname);
                    MySqlCommand cmd = new MySqlCommand(procedureName, con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (parameters != null)
                    {
                        foreach (MySqlParameter param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(dat);
                }
                return dat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Clone();
                }
            }

        }


        /*
       *clearUserCart by clietnId and return all table
       */
        public DataTable deleteUser_clearCart(int clietnId)
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",7),
                    new MySqlParameter("cId",clietnId),      //clientId
                    new MySqlParameter("pId",0),             //productId
                    new MySqlParameter("pA",0),              //productAmount
                    
                };
                if (con.State == ConnectionState.Open)
                {
                    con.ChangeDatabase(dbname);
                    MySqlCommand cmd = new MySqlCommand(procedureName, con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (parameters != null)
                    {
                        foreach (MySqlParameter param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(dat);
                }
                return dat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Clone();
                }
            }

        }




        /*
        *getAllTable 
        */
        public DataTable getAllTable()
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",4),
                    new MySqlParameter("cId",0),             //clientId
                    new MySqlParameter("pId",0),             //productId
                    new MySqlParameter("pA",0),              //productAmount
                    
                };
                if (con.State == ConnectionState.Open)
                {
                    con.ChangeDatabase(dbname);
                    MySqlCommand cmd = new MySqlCommand(procedureName, con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (parameters != null)
                    {
                        foreach (MySqlParameter param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(dat);
                }
                return dat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Clone();
                }
            }

        }





    }
}