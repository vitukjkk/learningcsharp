using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace data
{
    internal class banco
    {
        private static SQLiteConnection cnx;

        protected static SQLiteConnection opencnx()
        {
            cnx = new SQLiteConnection("Data Source=C:\\Users\\vitto\\Downloads\\PC#\\data\\db_academia.db");
            cnx.Open();
            return cnx;
        }

        public static DataTable query(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = opencnx().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, opencnx());
                    da.Fill(dt);
                    opencnx().Close();
                    return dt;
                }
            }
            catch (Exception e)
            {
                opencnx().Close();
                throw e;
            }
        }


        public static void newuser(user u)
        {
            try
            {
                string sql = "INSERT INTO users (name, senha, status, level) VALUES (@name, @senha, @status, @level)";

                using (var cmd = opencnx().CreateCommand())
                {
                    cmd.CommandText = sql;

                    cmd.Parameters.AddWithValue("@name", u.name);
                    cmd.Parameters.AddWithValue("@senha", u.senha);
                    cmd.Parameters.AddWithValue("@status", u.status);
                    cmd.Parameters.AddWithValue("@level", u.level);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Novo usuário adicionado!");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro ao gravar o novo usuário!");
                throw e;

            }
        }

        

        public static bool usersExists(string name)
        {

            string sql = "SELECT COUNT(*) FROM users WHERE name = @name";

            using (var cmd = opencnx().CreateCommand())
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@name", name);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}