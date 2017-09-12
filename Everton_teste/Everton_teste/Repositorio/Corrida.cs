using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Everton_teste.Repositorio
{
    public class Corrida
    {
        public void Salvar(Models.Corrida_Novo_Salvar novo)
        {
            string query = @"
                        insert into Corridas(IdMotorista, IdPassageiro, Valor)
                        VALUES('" + novo.Motorista + "', '" + novo.Passageiro + "', '" + novo.Valor+ "')";

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

        public DataTable GetGrid()
        {
            string query = @"
                    SELECT C.Id,
		                    M.Nome AS Motorista,
		                    P.Nome AS Passageiro,
		                    C.Valor
                    from Corridas C
                    INNER JOIN Motoristas M ON C.IdMotorista = M.Id
                    INNER JOIN Passageiros P ON C.IdPassageiro = P.Id";

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