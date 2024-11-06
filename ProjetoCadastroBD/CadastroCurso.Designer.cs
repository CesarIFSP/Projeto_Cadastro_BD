namespace ProjetoCadastroBD
{
    partial class CadastroCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCurso));
            tabControlCurso = new ReaLTaiizor.Controls.MaterialTabControl();
            tabCadastro = new TabPage();
            TextId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ButtonCancelar = new ReaLTaiizor.Controls.MaterialButton();
            ButtonSalvar = new ReaLTaiizor.Controls.MaterialButton();
            ComboArea = new ReaLTaiizor.Controls.MaterialComboBox();
            ComboPeriodo = new ReaLTaiizor.Controls.MaterialComboBox();
            ComboDuracao = new ReaLTaiizor.Controls.MaterialComboBox();
            ComboNivel = new ReaLTaiizor.Controls.MaterialComboBox();
            TextNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabConsulta = new TabPage();
            ButtonExcluir = new ReaLTaiizor.Controls.MaterialButton();
            ButtonNovo = new ReaLTaiizor.Controls.MaterialButton();
            ButtonEditar = new ReaLTaiizor.Controls.MaterialButton();
            dataGridCurso = new DataGridView();
            imageList1 = new ImageList(components);
            tabControlCurso.SuspendLayout();
            tabCadastro.SuspendLayout();
            tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCurso).BeginInit();
            SuspendLayout();
            // 
            // tabControlCurso
            // 
            tabControlCurso.Controls.Add(tabCadastro);
            tabControlCurso.Controls.Add(tabConsulta);
            tabControlCurso.Depth = 0;
            tabControlCurso.Dock = DockStyle.Fill;
            tabControlCurso.ImageList = imageList1;
            tabControlCurso.Location = new Point(3, 64);
            tabControlCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlCurso.Multiline = true;
            tabControlCurso.Name = "tabControlCurso";
            tabControlCurso.SelectedIndex = 0;
            tabControlCurso.Size = new Size(794, 419);
            tabControlCurso.TabIndex = 0;
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(TextId);
            tabCadastro.Controls.Add(ButtonCancelar);
            tabCadastro.Controls.Add(ButtonSalvar);
            tabCadastro.Controls.Add(ComboArea);
            tabCadastro.Controls.Add(ComboPeriodo);
            tabCadastro.Controls.Add(ComboDuracao);
            tabCadastro.Controls.Add(ComboNivel);
            tabCadastro.Controls.Add(TextNome);
            tabCadastro.Controls.Add(TextCodigo);
            tabCadastro.ImageKey = "form.png";
            tabCadastro.Location = new Point(4, 31);
            tabCadastro.Name = "tabCadastro";
            tabCadastro.Padding = new Padding(3);
            tabCadastro.Size = new Size(786, 384);
            tabCadastro.TabIndex = 0;
            tabCadastro.Text = "Cadastro";
            tabCadastro.UseVisualStyleBackColor = true;
            // 
            // TextId
            // 
            TextId.AnimateReadOnly = false;
            TextId.AutoCompleteMode = AutoCompleteMode.None;
            TextId.AutoCompleteSource = AutoCompleteSource.None;
            TextId.BackgroundImageLayout = ImageLayout.None;
            TextId.CharacterCasing = CharacterCasing.Normal;
            TextId.Depth = 0;
            TextId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextId.HideSelection = true;
            TextId.Hint = "Id do Curso";
            TextId.LeadingIcon = null;
            TextId.Location = new Point(89, 333);
            TextId.MaxLength = 32767;
            TextId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextId.Name = "TextId";
            TextId.PasswordChar = '\0';
            TextId.PrefixSuffixText = null;
            TextId.ReadOnly = true;
            TextId.RightToLeft = RightToLeft.No;
            TextId.SelectedText = "";
            TextId.SelectionLength = 0;
            TextId.SelectionStart = 0;
            TextId.ShortcutsEnabled = true;
            TextId.Size = new Size(587, 48);
            TextId.TabIndex = 8;
            TextId.TabStop = false;
            TextId.TextAlign = HorizontalAlignment.Left;
            TextId.TrailingIcon = null;
            TextId.UseSystemPasswordChar = false;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonCancelar.Depth = 0;
            ButtonCancelar.HighEmphasis = true;
            ButtonCancelar.Icon = null;
            ButtonCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonCancelar.Location = new Point(683, 339);
            ButtonCancelar.Margin = new Padding(4, 6, 4, 6);
            ButtonCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.NoAccentTextColor = Color.Empty;
            ButtonCancelar.Size = new Size(96, 36);
            ButtonCancelar.TabIndex = 7;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonCancelar.UseAccentColor = false;
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ButtonSalvar
            // 
            ButtonSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonSalvar.Depth = 0;
            ButtonSalvar.HighEmphasis = true;
            ButtonSalvar.Icon = null;
            ButtonSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonSalvar.Location = new Point(6, 339);
            ButtonSalvar.Margin = new Padding(4, 6, 4, 6);
            ButtonSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonSalvar.Name = "ButtonSalvar";
            ButtonSalvar.NoAccentTextColor = Color.Empty;
            ButtonSalvar.Size = new Size(76, 36);
            ButtonSalvar.TabIndex = 6;
            ButtonSalvar.Text = "Salvar";
            ButtonSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonSalvar.UseAccentColor = false;
            ButtonSalvar.UseVisualStyleBackColor = true;
            ButtonSalvar.Click += ButtonSalvar_Click;
            // 
            // ComboArea
            // 
            ComboArea.AutoResize = false;
            ComboArea.BackColor = Color.FromArgb(255, 255, 255);
            ComboArea.Depth = 0;
            ComboArea.DrawMode = DrawMode.OwnerDrawVariable;
            ComboArea.DropDownHeight = 174;
            ComboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboArea.DropDownWidth = 121;
            ComboArea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboArea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboArea.FormattingEnabled = true;
            ComboArea.Hint = "Área";
            ComboArea.IntegralHeight = false;
            ComboArea.ItemHeight = 43;
            ComboArea.Items.AddRange(new object[] { "Licenciatura", "Informática", "Indústria", "Administração" });
            ComboArea.Location = new Point(6, 279);
            ComboArea.MaxDropDownItems = 4;
            ComboArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ComboArea.Name = "ComboArea";
            ComboArea.Size = new Size(774, 49);
            ComboArea.StartIndex = 0;
            ComboArea.TabIndex = 5;
            // 
            // ComboPeriodo
            // 
            ComboPeriodo.AutoResize = false;
            ComboPeriodo.BackColor = Color.FromArgb(255, 255, 255);
            ComboPeriodo.Depth = 0;
            ComboPeriodo.DrawMode = DrawMode.OwnerDrawVariable;
            ComboPeriodo.DropDownHeight = 174;
            ComboPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboPeriodo.DropDownWidth = 121;
            ComboPeriodo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboPeriodo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboPeriodo.FormattingEnabled = true;
            ComboPeriodo.Hint = "Período";
            ComboPeriodo.IntegralHeight = false;
            ComboPeriodo.ItemHeight = 43;
            ComboPeriodo.Items.AddRange(new object[] { "Diurno", "Vespertino", "Noturno", "Integral" });
            ComboPeriodo.Location = new Point(6, 224);
            ComboPeriodo.MaxDropDownItems = 4;
            ComboPeriodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ComboPeriodo.Name = "ComboPeriodo";
            ComboPeriodo.Size = new Size(774, 49);
            ComboPeriodo.StartIndex = 0;
            ComboPeriodo.TabIndex = 4;
            // 
            // ComboDuracao
            // 
            ComboDuracao.AutoResize = false;
            ComboDuracao.BackColor = Color.FromArgb(255, 255, 255);
            ComboDuracao.Depth = 0;
            ComboDuracao.DrawMode = DrawMode.OwnerDrawVariable;
            ComboDuracao.DropDownHeight = 174;
            ComboDuracao.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboDuracao.DropDownWidth = 121;
            ComboDuracao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboDuracao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboDuracao.FormattingEnabled = true;
            ComboDuracao.Hint = "Duração";
            ComboDuracao.IntegralHeight = false;
            ComboDuracao.ItemHeight = 43;
            ComboDuracao.Items.AddRange(new object[] { "2 Semestre", "4 Semestres", "6 Semestres", "8 Semestres", "10 Semestres", "12 Semestres" });
            ComboDuracao.Location = new Point(6, 169);
            ComboDuracao.MaxDropDownItems = 4;
            ComboDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ComboDuracao.Name = "ComboDuracao";
            ComboDuracao.Size = new Size(774, 49);
            ComboDuracao.StartIndex = 0;
            ComboDuracao.TabIndex = 3;
            // 
            // ComboNivel
            // 
            ComboNivel.AutoResize = false;
            ComboNivel.BackColor = Color.FromArgb(255, 255, 255);
            ComboNivel.Depth = 0;
            ComboNivel.DrawMode = DrawMode.OwnerDrawVariable;
            ComboNivel.DropDownHeight = 174;
            ComboNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboNivel.DropDownWidth = 121;
            ComboNivel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboNivel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboNivel.FormattingEnabled = true;
            ComboNivel.Hint = "Nível";
            ComboNivel.IntegralHeight = false;
            ComboNivel.ItemHeight = 43;
            ComboNivel.Items.AddRange(new object[] { "Superior", "Técnico" });
            ComboNivel.Location = new Point(6, 114);
            ComboNivel.MaxDropDownItems = 4;
            ComboNivel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ComboNivel.Name = "ComboNivel";
            ComboNivel.Size = new Size(774, 49);
            ComboNivel.StartIndex = 0;
            ComboNivel.TabIndex = 2;
            // 
            // TextNome
            // 
            TextNome.AnimateReadOnly = false;
            TextNome.AutoCompleteMode = AutoCompleteMode.None;
            TextNome.AutoCompleteSource = AutoCompleteSource.None;
            TextNome.BackgroundImageLayout = ImageLayout.None;
            TextNome.CharacterCasing = CharacterCasing.Normal;
            TextNome.Depth = 0;
            TextNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextNome.HideSelection = true;
            TextNome.Hint = "Nome";
            TextNome.LeadingIcon = null;
            TextNome.Location = new Point(6, 60);
            TextNome.MaxLength = 32767;
            TextNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextNome.Name = "TextNome";
            TextNome.PasswordChar = '\0';
            TextNome.PrefixSuffixText = null;
            TextNome.ReadOnly = false;
            TextNome.RightToLeft = RightToLeft.No;
            TextNome.SelectedText = "";
            TextNome.SelectionLength = 0;
            TextNome.SelectionStart = 0;
            TextNome.ShortcutsEnabled = true;
            TextNome.Size = new Size(774, 48);
            TextNome.TabIndex = 1;
            TextNome.TabStop = false;
            TextNome.TextAlign = HorizontalAlignment.Left;
            TextNome.TrailingIcon = null;
            TextNome.UseSystemPasswordChar = false;
            // 
            // TextCodigo
            // 
            TextCodigo.AnimateReadOnly = false;
            TextCodigo.AutoCompleteMode = AutoCompleteMode.None;
            TextCodigo.AutoCompleteSource = AutoCompleteSource.None;
            TextCodigo.BackgroundImageLayout = ImageLayout.None;
            TextCodigo.CharacterCasing = CharacterCasing.Normal;
            TextCodigo.Depth = 0;
            TextCodigo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextCodigo.HideSelection = true;
            TextCodigo.Hint = "Código";
            TextCodigo.LeadingIcon = null;
            TextCodigo.Location = new Point(6, 6);
            TextCodigo.MaxLength = 32767;
            TextCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextCodigo.Name = "TextCodigo";
            TextCodigo.PasswordChar = '\0';
            TextCodigo.PrefixSuffixText = null;
            TextCodigo.ReadOnly = false;
            TextCodigo.RightToLeft = RightToLeft.No;
            TextCodigo.SelectedText = "";
            TextCodigo.SelectionLength = 0;
            TextCodigo.SelectionStart = 0;
            TextCodigo.ShortcutsEnabled = true;
            TextCodigo.Size = new Size(774, 48);
            TextCodigo.TabIndex = 0;
            TextCodigo.TabStop = false;
            TextCodigo.TextAlign = HorizontalAlignment.Left;
            TextCodigo.TrailingIcon = null;
            TextCodigo.UseSystemPasswordChar = false;
            // 
            // tabConsulta
            // 
            tabConsulta.Controls.Add(ButtonExcluir);
            tabConsulta.Controls.Add(ButtonNovo);
            tabConsulta.Controls.Add(ButtonEditar);
            tabConsulta.Controls.Add(dataGridCurso);
            tabConsulta.ImageKey = "search.png";
            tabConsulta.Location = new Point(4, 31);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.Padding = new Padding(3);
            tabConsulta.Size = new Size(786, 384);
            tabConsulta.TabIndex = 1;
            tabConsulta.Text = "Consulta";
            tabConsulta.UseVisualStyleBackColor = true;
            tabConsulta.Enter += tabConsulta_Enter;
            // 
            // ButtonExcluir
            // 
            ButtonExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonExcluir.Depth = 0;
            ButtonExcluir.HighEmphasis = true;
            ButtonExcluir.Icon = null;
            ButtonExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonExcluir.Location = new Point(699, 339);
            ButtonExcluir.Margin = new Padding(4, 6, 4, 6);
            ButtonExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonExcluir.Name = "ButtonExcluir";
            ButtonExcluir.NoAccentTextColor = Color.Empty;
            ButtonExcluir.Size = new Size(80, 36);
            ButtonExcluir.TabIndex = 3;
            ButtonExcluir.Text = "Excluir";
            ButtonExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonExcluir.UseAccentColor = false;
            ButtonExcluir.UseVisualStyleBackColor = true;
            ButtonExcluir.Click += ButtonExcluir_Click;
            // 
            // ButtonNovo
            // 
            ButtonNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonNovo.Depth = 0;
            ButtonNovo.HighEmphasis = true;
            ButtonNovo.Icon = null;
            ButtonNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonNovo.Location = new Point(548, 339);
            ButtonNovo.Margin = new Padding(4, 6, 4, 6);
            ButtonNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonNovo.Name = "ButtonNovo";
            ButtonNovo.NoAccentTextColor = Color.Empty;
            ButtonNovo.Size = new Size(64, 36);
            ButtonNovo.TabIndex = 2;
            ButtonNovo.Text = "Novo";
            ButtonNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonNovo.UseAccentColor = false;
            ButtonNovo.UseVisualStyleBackColor = true;
            ButtonNovo.Click += ButtonNovo_Click;
            // 
            // ButtonEditar
            // 
            ButtonEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonEditar.Depth = 0;
            ButtonEditar.HighEmphasis = true;
            ButtonEditar.Icon = null;
            ButtonEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonEditar.Location = new Point(620, 339);
            ButtonEditar.Margin = new Padding(4, 6, 4, 6);
            ButtonEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonEditar.Name = "ButtonEditar";
            ButtonEditar.NoAccentTextColor = Color.Empty;
            ButtonEditar.Size = new Size(71, 36);
            ButtonEditar.TabIndex = 1;
            ButtonEditar.Text = "Editar";
            ButtonEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonEditar.UseAccentColor = false;
            ButtonEditar.UseVisualStyleBackColor = true;
            ButtonEditar.Click += ButtonEditar_Click;
            // 
            // dataGridCurso
            // 
            dataGridCurso.AllowUserToAddRows = false;
            dataGridCurso.AllowUserToDeleteRows = false;
            dataGridCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCurso.Dock = DockStyle.Top;
            dataGridCurso.Location = new Point(3, 3);
            dataGridCurso.Name = "dataGridCurso";
            dataGridCurso.ReadOnly = true;
            dataGridCurso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCurso.Size = new Size(780, 330);
            dataGridCurso.TabIndex = 0;
            dataGridCurso.CellDoubleClick += dataGridCurso_CellDoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "search.png");
            imageList1.Images.SetKeyName(1, "form.png");
            // 
            // CadastroCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(tabControlCurso);
            DrawerTabControl = tabControlCurso;
            Name = "CadastroCurso";
            Text = "Cadastro Curso";
            Load += CadastroCurso_Load;
            tabControlCurso.ResumeLayout(false);
            tabCadastro.ResumeLayout(false);
            tabCadastro.PerformLayout();
            tabConsulta.ResumeLayout(false);
            tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCurso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl tabControlCurso;
        private TabPage tabCadastro;
        private TabPage tabConsulta;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialComboBox ComboArea;
        private ReaLTaiizor.Controls.MaterialComboBox ComboPeriodo;
        private ReaLTaiizor.Controls.MaterialComboBox ComboDuracao;
        private ReaLTaiizor.Controls.MaterialComboBox ComboNivel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextCodigo;
        private ReaLTaiizor.Controls.MaterialButton ButtonCancelar;
        private ReaLTaiizor.Controls.MaterialButton ButtonSalvar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextId;
        private DataGridView dataGridCurso;
        private ReaLTaiizor.Controls.MaterialButton ButtonExcluir;
        private ReaLTaiizor.Controls.MaterialButton ButtonNovo;
        private ReaLTaiizor.Controls.MaterialButton ButtonEditar;
    }
}