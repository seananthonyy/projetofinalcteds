using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFteste.Interfaces;
using WPFteste.Models;



namespace WPFteste.Repositories
{
    public class UsuariosRepository : IUsuarios
    {
        public void CriarUsuario(Usuarios novoUsuario)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = "serverdefinitivo.database.windows.net";
                builder.UserID = "thiagoantonio";
                builder.Password = "12677679ta!";
                builder.InitialCatalog = "dbdefinitiva";

                using (SqlConnection con = new SqlConnection(builder.ConnectionString))
                {
                    
                    string queryInsert = "INSERT INTO Usuarios (UsuarioNome, UsuarioSenha) VALUES (@UsuarioNome, @UsuarioSenha)";

                    using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                    {
                        cmd.Parameters.AddWithValue("@UsuarioNome", novoUsuario.Nome);
                        cmd.Parameters.AddWithValue("@UsuarioSenha", novoUsuario.Senha);


                        con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }


            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
