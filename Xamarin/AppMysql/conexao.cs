using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMysql
{
    class conexao
    {
        public string conec = "SERVER = mysql744.umbler.com; DATABASE = appmysql; UID = wapsi; PWD = P28042019g*; PORT = 41890";
        public MySqlConnection con = null;

        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(conec); 
                con.Open();
            }
            catch (Exception ex)
            {

                Toast.MakeText(Application.Context, "Erro ao conectar" + ex, ToastLength.Long).Show();
            }
        }

        public void FecharConexao()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Close();
            }
            catch (Exception ex)
            {

                Toast.MakeText(Application.Context, "Erro ao fechar" + ex, ToastLength.Long).Show();
            }
        }

    }   
}
