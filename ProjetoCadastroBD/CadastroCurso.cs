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
    public partial class CadastroCurso : MaterialForm
    {
        bool isAlteracao = false;
        string conexao = @"server=127.0.0.1;" +
                "uid=root;" +
                "pwd=1234;" +
                "database=academico";
        public CadastroCurso()
        {
            InitializeComponent();
        }

        private void CadastroCurso_Load(object sender, EventArgs e)
        {

        }
        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var c in tabCadastro.Controls)
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
        private bool Valida_Campos()
        {
            if (string.IsNullOrEmpty(TextNome.Text))
            {
                MessageBox.Show("O campo Nome precisa ter um valor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(TextCodigo.Text))
            {
                MessageBox.Show("O campo Código precisa ter um valor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void Salvar()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "";
            if (isAlteracao)
            {
                sql = "UPDATE curso SET " +
                      "codigo = @codigo, " +
                      "nome = @nome, " +
                      "nivel = @nivel, " +
                      "duracao = @duracao, " +
                      "periodo = @periodo, " +
                      "area = @area " +
                      " WHERE id = @id";
            }
            else
            {
                sql = "INSERT INTO curso " +
                    " (codigo, nome, nivel, duracao, periodo, area) " +
                    " VALUES " +
                    " (@codigo, @nome, @nivel, @duracao, @periodo, @area)";
            }
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@codigo", TextCodigo.Text);
            cmd.Parameters.AddWithValue("@nome", TextNome.Text);
            cmd.Parameters.AddWithValue("@nivel", ComboNivel.Text);
            cmd.Parameters.AddWithValue("@duracao", ComboDuracao.Text);
            cmd.Parameters.AddWithValue("@periodo", ComboPeriodo.Text);
            cmd.Parameters.AddWithValue("@area", ComboArea.Text);
            if (isAlteracao)
            {
                cmd.Parameters.AddWithValue("@id", TextId.Text);
            }
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
            LimpaCampos();
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            if (Valida_Campos())
            {
                Salvar();
                tabControlCurso.SelectedIndex = 1;
            }
        }
        private void CarregaGrid()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "SELECT * FROM curso";
            var sqlAd = new MySqlDataAdapter(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridCurso.DataSource = dt;
            con.Close();
        }

        private void tabConsulta_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Os dados fornecidos serão perdidos", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
            }
        }

        private void ButtonNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            tabControlCurso.SelectedIndex = 0;
            TextCodigo.Focus();
        }

        private void Excluir(int id)
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "DELETE FROM curso WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void ButtonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridCurso.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja excluir este curso?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Excluir((int)dataGridCurso.SelectedRows[0].Cells["id"].Value);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione um curso para ser excluído", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Editar()
        {
            isAlteracao = true;
            var linha = dataGridCurso.SelectedRows[0];
            TextId.Text = linha.Cells["id"].Value.ToString();
            TextCodigo.Text = linha.Cells["codigo"].Value.ToString();
            TextNome.Text = linha.Cells["nome"].Value.ToString();
            ComboArea.Text = linha.Cells["area"].Value.ToString();
            ComboDuracao.Text = linha.Cells["duracao"].Value.ToString();
            ComboNivel.Text = linha.Cells["nivel"].Value.ToString();
            ComboPeriodo.Text = linha.Cells["periodo"].Value.ToString();
            tabControlCurso.SelectedIndex = 0;
            TextCodigo.Focus();
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridCurso.SelectedRows.Count > 0)
            {
                Editar();
            }
            else
            {
                MessageBox.Show("Selecione um curso para ser editado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridCurso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }
    }
}
