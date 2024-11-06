using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace ProjetoCadastroBD
{
    public partial class CadastroAluno : MaterialForm
    {
        bool isAlteracao = false;
        string conexao = @"server=127.0.0.1;" +
                "uid=root;" +
                "pwd=1234;" +
                "database=academico";
        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {

        }
        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var c in TabCadastros.Controls)
            {
                if (c is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)c).Clear();
                }
                if (c is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)c).Clear();
                }
            }
        }
        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(TextNome.Text))
            {
                MessageBox.Show("Nome inválido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TextMatricula.Text))
            {
                MessageBox.Show("Matricula inválida", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextMatricula.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TextEndereco.Text))
            {
                MessageBox.Show("Endereço inválido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextEndereco.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TextBairro.Text))
            {
                MessageBox.Show("Bairro inválido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBairro.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TextCidade.Text))
            {
                MessageBox.Show("Cidade inválida", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextCidade.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TextSenha.Text))
            {
                MessageBox.Show("Senha inválida", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextSenha.Focus();
                return false;
            }
            if (!DateTime.TryParse(TextNascimento.Text, out DateTime _))
            {
                MessageBox.Show("Data inválida", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextNascimento.Focus();
                return false;
            }
            return true;
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();
                TabAlunos.SelectedIndex = 1;
            }
        }

        private void CarregaGrid()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "SELECT * FROM aluno";
            var sqlAd = new MySqlDataAdapter(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridViewAluno.DataSource = dt;
            con.Close();
        }
        private void TabConsulta_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }
        public void Salvar()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "";
            if (isAlteracao)
            {
                sql = "UPDATE aluno SET " +
                    "matricula = @matricula, " +
                    "dt_nascimento = @dt_nascimento, " +
                    "nome = @nome, " +
                    "endereco = @endereco, " +
                    "bairro = @bairro, " +
                    "cidade = @cidade, " +
                    "estado = @estado, " +
                    "senha = @senha " +
                    " WHERE id = @id";
            }
            else
            {
                sql = "INSERT INTO aluno " +
                    " (matricula, dt_nascimento, nome, endereco, bairro, cidade, estado, senha) " +
                    " VALUES " +
                    " (@matricula, @dt_nascimento, @nome, @endereco, @bairro, @cidade, @estado, @senha)";
            }
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matricula", TextMatricula.Text);
            DateTime.TryParse(TextNascimento.Text, out var dataNascimento);
            cmd.Parameters.AddWithValue("@dt_nascimento", dataNascimento);
            cmd.Parameters.AddWithValue("@nome", TextNome.Text);
            cmd.Parameters.AddWithValue("@endereco", TextEndereco.Text);
            cmd.Parameters.AddWithValue("@bairro", TextBairro.Text);
            cmd.Parameters.AddWithValue("@cidade", TextCidade.Text);
            cmd.Parameters.AddWithValue("@estado", ComboEstados.Text);
            cmd.Parameters.AddWithValue("@senha", TextSenha.Text);
            if (isAlteracao)
            {
                cmd.Parameters.AddWithValue("@id", TextId.Text);
            }
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            LimpaCampos();

        }
        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza? Seus dados serão perdidos", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LimpaCampos();
            }
        }
        private void Editar()
        {
            if (dataGridViewAluno.SelectedRows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridViewAluno.SelectedRows[0];
                TextId.Text = linha.Cells["id"].Value.ToString();
                TextMatricula.Text = linha.Cells["matricula"].Value.ToString();
                TextNascimento.Text = linha.Cells["dt_nascimento"].Value.ToString();
                TextEndereco.Text = linha.Cells["endereco"].Value.ToString();
                TextBairro.Text = linha.Cells["bairro"].Value.ToString();
                TextCidade.Text = linha.Cells["cidade"].Value.ToString();
                ComboEstados.Text = linha.Cells["estado"].Value.ToString();
                TextNome.Text = linha.Cells["nome"].Value.ToString();
                TextSenha.Text = linha.Cells["senha"].Value.ToString();
                TabAlunos.SelectedIndex = 0;
                TextMatricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAluno.SelectedRows.Count > 0)
            {
                Editar();
            }
        }

        private void dataGridViewAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void Excluir(int id)
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "DELETE FROM aluno WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void ButtonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewAluno.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Excluir((int)dataGridViewAluno.SelectedRows[0].Cells["id"].Value);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            TabAlunos.SelectedIndex = 0;
            TextNome.Focus();
        }
    }
}
