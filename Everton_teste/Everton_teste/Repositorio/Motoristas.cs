using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Everton_teste.Repositorio
{
    public class Motoristas
    {
        public DataTable GetGrid()
        {
            string query = "SELECT Id, Nome, CPF FROM Motoristas";
            string conection = System.Configuration.ConfigurationManager.ConnectionStrings["myContext"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(conection))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    connection.Close();

                    return dt;
                }
            }
        }

        public void Salvar(Models.Motoristas_Novo novo)
        {
            string query = @"
                        insert into Motoristas(Nome, DataNascimento, CPF, ModeloCarro, Sexo, Status)
                        VALUES('" + novo.Nome + "', '" + novo.DataNascimento.ToString("yyyy/MM/dd") + "', '" + novo.CPF + "','" + novo.Modelo + "', '" + novo.Sexo + "', '" + novo.Status + "')";

            string conection = System.Configuration.ConfigurationManager.ConnectionStrings["myContext"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conection))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public DataTable GetSelect()
        {
            string query = "SELECT ID, Nome FROM Motoristas WHERE Status = 1";

            string conection = System.Configuration.ConfigurationManager.ConnectionStrings["myContext"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(conection))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    connection.Close();

                    return dt;
                }
            }
        }
    }
}