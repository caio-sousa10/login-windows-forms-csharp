namespace Login_Windows_Forms
{
    partial class Forms_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpbox_formulario_login = new GroupBox();
            btn_entrar = new Button();
            btn_cancelar = new Button();
            txtb_inserir_senha = new TextBox();
            lbl_senha = new Label();
            txtb_inserir_user = new TextBox();
            lbl_user = new Label();
            gpbox_formulario_login.SuspendLayout();
            SuspendLayout();
            // 
            // gpbox_formulario_login
            // 
            gpbox_formulario_login.Controls.Add(btn_entrar);
            gpbox_formulario_login.Controls.Add(btn_cancelar);
            gpbox_formulario_login.Controls.Add(txtb_inserir_senha);
            gpbox_formulario_login.Controls.Add(lbl_senha);
            gpbox_formulario_login.Controls.Add(txtb_inserir_user);
            gpbox_formulario_login.Controls.Add(lbl_user);
            gpbox_formulario_login.Location = new Point(12, 12);
            gpbox_formulario_login.Name = "gpbox_formulario_login";
            gpbox_formulario_login.Size = new Size(339, 187);
            gpbox_formulario_login.TabIndex = 0;
            gpbox_formulario_login.TabStop = false;
            gpbox_formulario_login.Text = "Formulário de Login";
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = Color.SkyBlue;
            btn_entrar.Location = new Point(77, 128);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(75, 23);
            btn_entrar.TabIndex = 4;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(158, 128);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // txtb_inserir_senha
            // 
            txtb_inserir_senha.Location = new Point(108, 81);
            txtb_inserir_senha.Name = "txtb_inserir_senha";
            txtb_inserir_senha.Size = new Size(96, 23);
            txtb_inserir_senha.TabIndex = 3;
            txtb_inserir_senha.UseSystemPasswordChar = true;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(136, 63);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(42, 15);
            lbl_senha.TabIndex = 2;
            lbl_senha.Text = "Senha:";
            // 
            // txtb_inserir_user
            // 
            txtb_inserir_user.Location = new Point(108, 37);
            txtb_inserir_user.Name = "txtb_inserir_user";
            txtb_inserir_user.Size = new Size(96, 23);
            txtb_inserir_user.TabIndex = 1;
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Location = new Point(136, 19);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(50, 15);
            lbl_user.TabIndex = 0;
            lbl_user.Text = "Usuário:";
            // 
            // Forms_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 211);
            Controls.Add(gpbox_formulario_login);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Forms_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Área Login";
            gpbox_formulario_login.ResumeLayout(false);
            gpbox_formulario_login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbox_formulario_login;
        private Button btn_entrar;
        private Button btn_cancelar;
        private TextBox txtb_inserir_senha;
        private Label lbl_senha;
        private TextBox txtb_inserir_user;
        private Label lbl_user;
    }
}