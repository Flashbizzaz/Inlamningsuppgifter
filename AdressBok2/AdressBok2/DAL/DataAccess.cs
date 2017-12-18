using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBok2.DAL
{
    class DataAccess
    {
        public SqlConnection con = null;

        public DataAccess()
        {
            var connectionString = Properties.Settings.Default.AdressConnectionsString;
            con = new SqlConnection(connectionString);
        }


        public bool ExecuteNonQuery(string Command, CommandType cmdType, SqlParameter[] parameters)
        {
            SqlCommand cmd = null;
            int resultat = 0;

            cmd = con.CreateCommand();
            cmd.CommandType = cmdType;
            cmd.CommandText = Command;
            cmd.Parameters.AddRange(parameters);

            try
            {
                con.Open();
                resultat = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cmd = null;
                con.Close();
            }

            if (resultat >= 1)
            {
                return true;
            }

            return false;

        }


        public DataSet ExecuteSelectCommand(string Command, CommandType cmdType)
        {

            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();

            SqlCommand cmd = null;

            using (cmd = new SqlCommand(Command, con))
            {
                cmd.CommandType = cmdType;
                cmd.CommandText = Command;

                SqlDataAdapter da = null;
                using (da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }

                dataSet.Tables.Add(dataTable);

                cmd = null;
            }

            return dataSet;

        }



        public void UpdatePrice()
        {

            //string command = "update Products set UnitPrice*1.10 where CategoryID = 1";
            string command = "update Kontakt set epost*1.10 where kontaktID = 12";

            SqlCommand cmd = null;

            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = command;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cmd = null;
                con.Close();
            }

        }





    }
}
