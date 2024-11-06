using ReaLTaiizor.Forms;

namespace ProjetoCadastroBD
{
    public partial class Principal : MaterialForm
    {
        CadastroAluno FormAluno = new CadastroAluno();
        CadastroCurso FormCurso = new CadastroCurso();
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void cadastroAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAluno.MdiParent = this;
            FormAluno.Show();

        }

        private void cadastroCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCurso.MdiParent = this;
            FormCurso.Show();
        }
    }
}
