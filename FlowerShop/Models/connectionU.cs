using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace FlowerShop.Models
{
    public class connectionU
    {
        public string conString = "server=localhost;database=flowershop;uid=root;pwd=toor;SslMode=none";
        private string procedureName = "user_procedure";
        private string dbname = "flowershop";

         /*
          *getUSERS
          */
        public DataTable getUsers()
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",9),
                    new MySqlParameter("idU",0),
                    new MySqlParameter("loginU",0),
                    new MySqlParameter("paswdU",0),
                    new MySqlParameter("mailU",0)
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
         *getUser by name
         */
        public DataTable getUserByName(string name)
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",4),
                    new MySqlParameter("idU",0),
                    new MySqlParameter("loginU",name),
                    new MySqlParameter("paswdU",0),
                    new MySqlParameter("mailU",0)
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
         * 
         * AddUser
         * 
         * 
         */
        public DataTable addUser(int userId , string userLogin , string userPass , string userMail )
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",1),
                    new MySqlParameter("idU",userId),
                    new MySqlParameter("loginU",userLogin),
                    new MySqlParameter("paswdU",userPass),
                    new MySqlParameter("mailU",userMail)
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
         * 
         * update User by ID
         * 
         * 
         */

        public DataTable upUser(int userId, string userLogin, string userPass, string userMail)
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",2),
                    new MySqlParameter("idU",userId),
                    new MySqlParameter("loginU",userLogin),
                    new MySqlParameter("paswdU",userPass),
                    new MySqlParameter("mailU",userMail)
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
         * 
         * removeUser by ID
         * 
         * 
         */

        public DataTable remUser(int userId)
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",3),
                    new MySqlParameter("idU",userId),
                    new MySqlParameter("loginU",0),
                    new MySqlParameter("paswdU",0),
                    new MySqlParameter("mailU",0)
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
          *GET MAX ID
          */
        public DataTable getMaxId()
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",99),
                    new MySqlParameter("idU",0),
                    new MySqlParameter("loginU",0),
                    new MySqlParameter("paswdU",0),
                    new MySqlParameter("mailU",0)
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





