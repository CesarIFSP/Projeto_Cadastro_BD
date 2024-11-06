using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;
namespace ProjetoTeste
{
    [TestClass]
    public class UnitTest1
    {
        public MySqlConnection GetConnection()
        {
            string c = @"server=127.0.0.1;" +
                "uid=root;" +
                "pwd=1234;" +
                "database=academico";
            return new MySqlConnection(c);
        }

        [TestMethod]
        public void TestConnect()
        {
            var con = GetConnection();
            con.Open();
            Assert.IsTrue(con.State == System.Data.ConnectionState.Open);

        }
        [TestMethod]
        public void TestInsertAluno()
        {
            string sql = "INSERT INTO aluno " +
                " (matricula, dt_nascimento, nome, endereco, bairro, cidade, estado, senha) " +
                " VALUES " +
                " (@matricula, @dt_nascimento, @nome, @endereco, @bairro, @cidade, @estado, @senha)";
            var con = GetConnection();
            con.Open();
            var cmd = new MySqlCommand(sql,con);
            cmd.Parameters.AddWithValue("@matricula", "BI3017834");
            cmd.Parameters.AddWithValue("@dt_nascimento", new DateTime(2000,12,24));
            cmd.Parameters.AddWithValue("@nome", "César");
            cmd.Parameters.AddWithValue("@endereco", "Rua Rio Negro 565");
            cmd.Parameters.AddWithValue("@bairro", "Piedade");
            cmd.Parameters.AddWithValue("@cidade", "Itauna");
            cmd.Parameters.AddWithValue("@estado", "MG");
            cmd.Parameters.AddWithValue("@senha", "1234");
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
        [TestMethod]
        public void TestInsertCurso()
        {
            string sql = "INSERT INTO curso " +
                " (codigo, nome, nivel, periodo, area, duracao) " +
                " VALUES " +
                " (@codigo, @nome, @nivel, @periodo, @area, @duracao)";
            var con = GetConnection();
            con.Open();
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@codigo", "ENG221");
            cmd.Parameters.AddWithValue("@nome", "Engenharia");
            cmd.Parameters.AddWithValue("@nivel", "Superior");
            cmd.Parameters.AddWithValue("@periodo", "Integral");
            cmd.Parameters.AddWithValue("@area", "Tecnologia");
            cmd.Parameters.AddWithValue("@duracao", "10 Semestres");
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
        [TestMethod]
        public void TestSelectCurso()
        {
            var con = GetConnection();
            con.Open();
            var sql = "SELECT * FROM curso";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Debug.Write(dr["codigo"] + " ");
                Debug.Write(dr["nome"] + " ");
                Debug.Write(dr["nivel"] + " ");
                Debug.Write(dr["periodo"] + " ");
                Debug.Write(dr["area"] + " ");
                Debug.Write(dr["duracao"] + " ");
                Debug.WriteLine(" ");
            }
            con.Close();
        }

        [TestMethod]
        public void TestSelectAluno()
        {
            var con = GetConnection();
            con.Open();
            var sql = "SELECT * FROM aluno";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql,con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                Debug.Write(dr["matricula"] + " ");
                Debug.Write(dr["dt_nascimento"] + " ");
                Debug.Write(dr["endereco"] + " ");
                Debug.Write(dr["bairro"] + " ");
                Debug.Write(dr["cidade"] + " ");
                Debug.Write(dr["estado"] + " ");
                Debug.Write(dr["senha"] + " ");
                Debug.WriteLine(" ");
            }
            con.Close();
        }
    }
}