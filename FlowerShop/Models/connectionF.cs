using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace FlowerShop.Models
{
    public class connectionF
    {
        public string conString = "server=localhost;database=flowershop;uid=root;pwd=toor;SslMode=none";
        private string procedureName = "get_Prod";
        private string userProcedureName = "user_procedure";
        private string dbname = "flowershop";
       
        //getAll flowers
        public DataTable getFlowers() {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",1),
                    new MySqlParameter("idP",0),
                    new MySqlParameter("nameP",0),
                    new MySqlParameter("priceP",0),
                    new MySqlParameter("amountP",0)
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
            finally {
                if (con.State == ConnectionState.Open) {
                    con.Clone();
                }
            }

        }
       
        //getFlower by name
        public DataTable getFlower(string nameFlower) {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",2),
                    new MySqlParameter("idP",0),
                    new MySqlParameter("nameP",nameFlower),
                    new MySqlParameter("priceP",0),
                    new MySqlParameter("amountP",0)
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



        // setAmount
        public DataTable setAmount(string nameFlower, int amount)
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",3),
                    new MySqlParameter("idP",0),
                    new MySqlParameter("nameP",nameFlower),
                    new MySqlParameter("priceP",0),
                    new MySqlParameter("amountP",amount)
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





        // setPrice_Amount
        public DataTable setPrice_Amount(string nameFlower,int price,int amount)
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",4),
                    new MySqlParameter("idP",0),
                    new MySqlParameter("nameP",nameFlower),
                    new MySqlParameter("priceP",price),
                    new MySqlParameter("amountP",amount)
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


        //addFlower(id,name,price,amount)
        public DataTable addFlower(int id,string nameFlower, int price, int amount)
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",5),
                    new MySqlParameter("idP",id),
                    new MySqlParameter("nameP",nameFlower),
                    new MySqlParameter("priceP",price),
                    new MySqlParameter("amountP",amount)
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

        //removeFlower(name)
        public DataTable remFlower(string nameFlower)
        {

            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                DataTable dat = new DataTable();
                List<MySqlParameter> parameters = new List<MySqlParameter>() {
                    new MySqlParameter("operation",6),
                    new MySqlParameter("idP",0),
                    new MySqlParameter("nameP",nameFlower),
                    new MySqlParameter("priceP",0),
                    new MySqlParameter("amountP",0)
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