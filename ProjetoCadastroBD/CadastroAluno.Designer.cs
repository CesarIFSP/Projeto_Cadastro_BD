namespace ProjetoCadastroBD
{
    partial class CadastroAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroAluno));
            TabAlunos = new ReaLTaiizor.Controls.MaterialTabControl();
            TabCadastros = new TabPage();
            TextId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ButtonCancelar = new ReaLTaiizor.Controls.MaterialButton();
            ButtonSalvar = new ReaLTaiizor.Controls.MaterialButton();
            TextSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ComboEstados = new ReaLTaiizor.Controls.MaterialComboBox();
            TextCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            TextMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TabConsulta = new TabPage();
            dataGridViewAluno = new DataGridView();
            ButtonEditar = new ReaLTaiizor.Controls.MaterialButton();
            ButtonExcluir = new ReaLTaiizor.Controls.MaterialButton();
            ButtonNovo = new ReaLTaiizor.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            TabAlunos.SuspendLayout();
            TabCadastros.SuspendLayout();
            TabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAluno).BeginInit();
            SuspendLayout();
            // 
            // TabAlunos
            // 
            TabAlunos.Controls.Add(TabCadastros);
            TabAlunos.Controls.Add(TabConsulta);
            TabAlunos.Depth = 0;
            TabAlunos.Dock = DockStyle.Fill;
            TabAlunos.ImageList = imageList1;
            TabAlunos.Location = new Point(3, 64);
            TabAlunos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabAlunos.Multiline = true;
            TabAlunos.Name = "TabAlunos";
            TabAlunos.SelectedIndex = 0;
            TabAlunos.Size = new Size(794, 431);
            TabAlunos.TabIndex = 0;
            // 
            // TabCadastros
            // 
            TabCadastros.Controls.Add(TextId);
            TabCadastros.Controls.Add(ButtonCancelar);
            TabCadastros.Controls.Add(ButtonSalvar);
            TabCadastros.Controls.Add(TextSenha);
            TabCadastros.Controls.Add(ComboEstados);
            TabCadastros.Controls.Add(TextCidade);
            TabCadastros.Controls.Add(TextBairro);
            TabCadastros.Controls.Add(TextEndereco);
            TabCadastros.Controls.Add(TextNome);
            TabCadastros.Controls.Add(TextNascimento);
            TabCadastros.Controls.Add(TextMatricula);
            TabCadastros.ImageKey = "form.png";
            TabCadastros.Location = new Point(4, 31);
            TabCadastros.Name = "TabCadastros";
            TabCadastros.Padding = new Padding(3);
            TabCadastros.Size = new Size(786, 396);
            TabCadastros.TabIndex = 0;
            TabCadastros.Text = "Cadastro";
            TabCadastros.UseVisualStyleBackColor = true;
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
            TextId.Hint = "Id do Aluno";
            TextId.LeadingIcon = null;
            TextId.Location = new Point(87, 330);
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
            TextId.Size = new Size(590, 48);
            TextId.TabIndex = 10;
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
            ButtonCancelar.Location = new Point(684, 342);
            ButtonCancelar.Margin = new Padding(4, 6, 4, 6);
            ButtonCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.NoAccentTextColor = Color.Empty;
            ButtonCancelar.Size = new Size(96, 36);
            ButtonCancelar.TabIndex = 9;
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
            ButtonSalvar.Location = new Point(4, 342);
            ButtonSalvar.Margin = new Padding(4, 6, 4, 6);
            ButtonSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonSalvar.Name = "ButtonSalvar";
            ButtonSalvar.NoAccentTextColor = Color.Empty;
            ButtonSalvar.Size = new Size(76, 36);
            ButtonSalvar.TabIndex = 8;
            ButtonSalvar.Text = "Salvar";
            ButtonSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonSalvar.UseAccentColor = false;
            ButtonSalvar.UseVisualStyleBackColor = true;
            ButtonSalvar.Click += ButtonSalvar_Click;
            // 
            // TextSenha
            // 
            TextSenha.AnimateReadOnly = false;
            TextSenha.AutoCompleteMode = AutoCompleteMode.None;
            TextSenha.AutoCompleteSource = AutoCompleteSource.None;
            TextSenha.BackgroundImageLayout = ImageLayout.None;
            TextSenha.CharacterCasing = CharacterCasing.Normal;
            TextSenha.Depth = 0;
            TextSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextSenha.HideSelection = true;
            TextSenha.Hint = "Senha";
            TextSenha.LeadingIcon = Properties.Resources.baseline_fingerprint_black_24dp;
            TextSenha.Location = new Point(3, 276);
            TextSenha.MaxLength = 32767;
            TextSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextSenha.Name = "TextSenha";
            TextSenha.PasswordChar = '*';
            TextSenha.PrefixSuffixText = null;
            TextSenha.ReadOnly = false;
            TextSenha.RightToLeft = RightToLeft.No;
            TextSenha.SelectedText = "";
            TextSenha.SelectionLength = 0;
            TextSenha.SelectionStart = 0;
            TextSenha.ShortcutsEnabled = true;
            TextSenha.Size = new Size(777, 48);
            TextSenha.TabIndex = 7;
            TextSenha.TabStop = false;
            TextSenha.TextAlign = HorizontalAlignment.Left;
            TextSenha.TrailingIcon = null;
            TextSenha.UseSystemPasswordChar = false;
            // 
            // ComboEstados
            // 
            ComboEstados.AutoResize = false;
            ComboEstados.BackColor = Color.FromArgb(255, 255, 255);
            ComboEstados.Depth = 0;
            ComboEstados.DrawMode = DrawMode.OwnerDrawVariable;
            ComboEstados.DropDownHeight = 174;
            ComboEstados.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboEstados.DropDownWidth = 121;
            ComboEstados.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboEstados.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboEstados.FormattingEnabled = true;
            ComboEstados.Hint = "UF";
            ComboEstados.IntegralHeight = false;
            ComboEstados.ItemHeight = 43;
            ComboEstados.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            ComboEstados.Location = new Point(659, 222);
            ComboEstados.MaxDropDownItems = 4;
            ComboEstados.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ComboEstados.Name = "ComboEstados";
            ComboEstados.Size = new Size(121, 49);
            ComboEstados.StartIndex = 0;
            ComboEstados.TabIndex = 6;
            // 
            // TextCidade
            // 
            TextCidade.AnimateReadOnly = false;
            TextCidade.AutoCompleteMode = AutoCompleteMode.None;
            TextCidade.AutoCompleteSource = AutoCompleteSource.None;
            TextCidade.BackgroundImageLayout = ImageLayout.None;
            TextCidade.CharacterCasing = CharacterCasing.Normal;
            TextCidade.Depth = 0;
            TextCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextCidade.HideSelection = true;
            TextCidade.Hint = "Cidade";
            TextCidade.LeadingIcon = null;
            TextCidade.Location = new Point(6, 222);
            TextCidade.MaxLength = 32767;
            TextCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextCidade.Name = "TextCidade";
            TextCidade.PasswordChar = '\0';
            TextCidade.PrefixSuffixText = null;
            TextCidade.ReadOnly = false;
            TextCidade.RightToLeft = RightToLeft.No;
            TextCidade.SelectedText = "";
            TextCidade.SelectionLength = 0;
            TextCidade.SelectionStart = 0;
            TextCidade.ShortcutsEnabled = true;
            TextCidade.Size = new Size(647, 48);
            TextCidade.TabIndex = 5;
            TextCidade.TabStop = false;
            TextCidade.TextAlign = HorizontalAlignment.Left;
            TextCidade.TrailingIcon = null;
            TextCidade.UseSystemPasswordChar = false;
            // 
            // TextBairro
            // 
            TextBairro.AnimateReadOnly = false;
            TextBairro.AutoCompleteMode = AutoCompleteMode.None;
            TextBairro.AutoCompleteSource = AutoCompleteSource.None;
            TextBairro.BackgroundImageLayout = ImageLayout.None;
            TextBairro.CharacterCasing = CharacterCasing.Normal;
            TextBairro.Depth = 0;
            TextBairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBairro.HideSelection = true;
            TextBairro.Hint = "Bairro";
            TextBairro.LeadingIcon = null;
            TextBairro.Location = new Point(6, 168);
            TextBairro.MaxLength = 32767;
            TextBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextBairro.Name = "TextBairro";
            TextBairro.PasswordChar = '\0';
            TextBairro.PrefixSuffixText = null;
            TextBairro.ReadOnly = false;
            TextBairro.RightToLeft = RightToLeft.No;
            TextBairro.SelectedText = "";
            TextBairro.SelectionLength = 0;
            TextBairro.SelectionStart = 0;
            TextBairro.ShortcutsEnabled = true;
            TextBairro.Size = new Size(774, 48);
            TextBairro.TabIndex = 4;
            TextBairro.TabStop = false;
            TextBairro.TextAlign = HorizontalAlignment.Left;
            TextBairro.TrailingIcon = null;
            TextBairro.UseSystemPasswordChar = false;
            // 
            // TextEndereco
            // 
            TextEndereco.AnimateReadOnly = false;
            TextEndereco.AutoCompleteMode = AutoCompleteMode.None;
            TextEndereco.AutoCompleteSource = AutoCompleteSource.None;
            TextEndereco.BackgroundImageLayout = ImageLayout.None;
            TextEndereco.CharacterCasing = CharacterCasing.Normal;
            TextEndereco.Depth = 0;
            TextEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextEndereco.HideSelection = true;
            TextEndereco.Hint = "Endereço";
            TextEndereco.LeadingIcon = null;
            TextEndereco.Location = new Point(6, 114);
            TextEndereco.MaxLength = 32767;
            TextEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextEndereco.Name = "TextEndereco";
            TextEndereco.PasswordChar = '\0';
            TextEndereco.PrefixSuffixText = null;
            TextEndereco.ReadOnly = false;
            TextEndereco.RightToLeft = RightToLeft.No;
            TextEndereco.SelectedText = "";
            TextEndereco.SelectionLength = 0;
            TextEndereco.SelectionStart = 0;
            TextEndereco.ShortcutsEnabled = true;
            TextEndereco.Size = new Size(774, 48);
            TextEndereco.TabIndex = 3;
            TextEndereco.TabStop = false;
            TextEndereco.TextAlign = HorizontalAlignment.Left;
            TextEndereco.TrailingIcon = null;
            TextEndereco.UseSystemPasswordChar = false;
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
            TextNome.TabIndex = 2;
            TextNome.TabStop = false;
            TextNome.TextAlign = HorizontalAlignment.Left;
            TextNome.TrailingIcon = null;
            TextNome.UseSystemPasswordChar = false;
            // 
            // TextNascimento
            // 
            TextNascimento.AllowPromptAsInput = true;
            TextNascimento.AnimateReadOnly = false;
            TextNascimento.AsciiOnly = false;
            TextNascimento.BackgroundImageLayout = ImageLayout.None;
            TextNascimento.BeepOnError = false;
            TextNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            TextNascimento.Depth = 0;
            TextNascimento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextNascimento.HidePromptOnLeave = false;
            TextNascimento.HideSelection = true;
            TextNascimento.Hint = "Data Nascimento";
            TextNascimento.InsertKeyMode = InsertKeyMode.Default;
            TextNascimento.LeadingIcon = null;
            TextNascimento.Location = new Point(490, 6);
            TextNascimento.Mask = "99/99/9999";
            TextNascimento.MaxLength = 32767;
            TextNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextNascimento.Name = "TextNascimento";
            TextNascimento.PasswordChar = '\0';
            TextNascimento.PrefixSuffixText = null;
            TextNascimento.PromptChar = '_';
            TextNascimento.ReadOnly = false;
            TextNascimento.RejectInputOnFirstFailure = false;
            TextNascimento.ResetOnPrompt = true;
            TextNascimento.ResetOnSpace = true;
            TextNascimento.RightToLeft = RightToLeft.No;
            TextNascimento.SelectedText = "";
            TextNascimento.SelectionLength = 0;
            TextNascimento.SelectionStart = 0;
            TextNascimento.ShortcutsEnabled = true;
            TextNascimento.Size = new Size(290, 48);
            TextNascimento.SkipLiterals = true;
            TextNascimento.TabIndex = 1;
            TextNascimento.TabStop = false;
            TextNascimento.Text = "  /  /";
            TextNascimento.TextAlign = HorizontalAlignment.Left;
            TextNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            TextNascimento.TrailingIcon = null;
            TextNascimento.UseSystemPasswordChar = false;
            TextNascimento.ValidatingType = null;
            // 
            // TextMatricula
            // 
            TextMatricula.AnimateReadOnly = false;
            TextMatricula.AutoCompleteMode = AutoCompleteMode.None;
            TextMatricula.AutoCompleteSource = AutoCompleteSource.None;
            TextMatricula.BackgroundImageLayout = ImageLayout.None;
            TextMatricula.CharacterCasing = CharacterCasing.Normal;
            TextMatricula.Depth = 0;
            TextMatricula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextMatricula.HideSelection = true;
            TextMatricula.Hint = "Matrícula";
            TextMatricula.LeadingIcon = null;
            TextMatricula.Location = new Point(3, 6);
            TextMatricula.MaxLength = 32767;
            TextMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextMatricula.Name = "TextMatricula";
            TextMatricula.PasswordChar = '\0';
            TextMatricula.PrefixSuffixText = null;
            TextMatricula.ReadOnly = false;
            TextMatricula.RightToLeft = RightToLeft.No;
            TextMatricula.SelectedText = "";
            TextMatricula.SelectionLength = 0;
            TextMatricula.SelectionStart = 0;
            TextMatricula.ShortcutsEnabled = true;
            TextMatricula.Size = new Size(481, 48);
            TextMatricula.TabIndex = 0;
            TextMatricula.TabStop = false;
            TextMatricula.TextAlign = HorizontalAlignment.Left;
            TextMatricula.TrailingIcon = null;
            TextMatricula.UseSystemPasswordChar = false;
            // 
            // TabConsulta
            // 
            TabConsulta.Controls.Add(dataGridViewAluno);
            TabConsulta.Controls.Add(ButtonEditar);
            TabConsulta.Controls.Add(ButtonExcluir);
            TabConsulta.Controls.Add(ButtonNovo);
            TabConsulta.ImageKey = "search.png";
            TabConsulta.Location = new Point(4, 31);
            TabConsulta.Name = "TabConsulta";
            TabConsulta.Padding = new Padding(3);
            TabConsulta.Size = new Size(786, 396);
            TabConsulta.TabIndex = 1;
            TabConsulta.Text = "Consulta";
            TabConsulta.UseVisualStyleBackColor = true;
            TabConsulta.Enter += TabConsulta_Enter;
            // 
            // dataGridViewAluno
            // 
            dataGridViewAluno.AllowUserToAddRows = false;
            dataGridViewAluno.AllowUserToDeleteRows = false;
            dataGridViewAluno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAluno.Dock = DockStyle.Top;
            dataGridViewAluno.Location = new Point(3, 3);
            dataGridViewAluno.Name = "dataGridViewAluno";
            dataGridViewAluno.ReadOnly = true;
            dataGridViewAluno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAluno.Size = new Size(780, 344);
            dataGridViewAluno.TabIndex = 4;
            dataGridViewAluno.CellDoubleClick += dataGridViewAluno_CellDoubleClick;
            // 
            // ButtonEditar
            // 
            ButtonEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonEditar.Depth = 0;
            ButtonEditar.HighEmphasis = true;
            ButtonEditar.Icon = null;
            ButtonEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonEditar.Location = new Point(620, 356);
            ButtonEditar.Margin = new Padding(4, 6, 4, 6);
            ButtonEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonEditar.Name = "ButtonEditar";
            ButtonEditar.NoAccentTextColor = Color.Empty;
            ButtonEditar.Size = new Size(71, 36);
            ButtonEditar.TabIndex = 3;
            ButtonEditar.Text = "Editar";
            ButtonEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonEditar.UseAccentColor = false;
            ButtonEditar.UseVisualStyleBackColor = true;
            ButtonEditar.Click += ButtonEditar_Click;
            // 
            // ButtonExcluir
            // 
            ButtonExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonExcluir.Depth = 0;
            ButtonExcluir.HighEmphasis = true;
            ButtonExcluir.Icon = null;
            ButtonExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonExcluir.Location = new Point(699, 356);
            ButtonExcluir.Margin = new Padding(4, 6, 4, 6);
            ButtonExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonExcluir.Name = "ButtonExcluir";
            ButtonExcluir.NoAccentTextColor = Color.Empty;
            ButtonExcluir.Size = new Size(80, 36);
            ButtonExcluir.TabIndex = 2;
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
            ButtonNovo.Location = new Point(548, 356);
            ButtonNovo.Margin = new Padding(4, 6, 4, 6);
            ButtonNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonNovo.Name = "ButtonNovo";
            ButtonNovo.NoAccentTextColor = Color.Empty;
            ButtonNovo.Size = new Size(64, 36);
            ButtonNovo.TabIndex = 1;
            ButtonNovo.Text = "Novo";
            ButtonNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonNovo.UseAccentColor = false;
            ButtonNovo.UseVisualStyleBackColor = true;
            ButtonNovo.Click += ButtonNovo_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // CadastroAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 498);
            Controls.Add(TabAlunos);
            DrawerTabControl = TabAlunos;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastroAluno";
            Text = "Cadastro Aluno";
            Load += CadastroAluno_Load;
            TabAlunos.ResumeLayout(false);
            TabCadastros.ResumeLayout(false);
            TabCadastros.PerformLayout();
            TabConsulta.ResumeLayout(false);
            TabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAluno).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl TabAlunos;
        private TabPage TabCadastros;
        private TabPage TabConsulta;
        private ReaLTaiizor.Controls.MaterialButton ButtonCancelar;
        private ReaLTaiizor.Controls.MaterialButton ButtonSalvar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextSenha;
        private ReaLTaiizor.Controls.MaterialComboBox ComboEstados;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextNome;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox TextNascimento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextMatricula;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialButton ButtonExcluir;
        private ReaLTaiizor.Controls.MaterialButton ButtonNovo;
        private ReaLTaiizor.Controls.MaterialButton ButtonEditar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextId;
        private DataGridView dataGridViewAluno;
    }
}