namespace Login_Windows_Forms
{
    partial class MenuRestrito
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
            groupBox_Acesso_Priv = new GroupBox();
            SuspendLayout();
            // 
            // groupBox_Acesso_Priv
            // 
            groupBox_Acesso_Priv.Location = new Point(12, 12);
            groupBox_Acesso_Priv.Name = "groupBox_Acesso_Priv";
            groupBox_Acesso_Priv.Size = new Size(340, 185);
            groupBox_Acesso_Priv.TabIndex = 0;
            groupBox_Acesso_Priv.TabStop = false;
            groupBox_Acesso_Priv.Text = "Acesso Privado";
            // 
            // MenuRestrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 209);
            Controls.Add(groupBox_Acesso_Priv);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MenuRestrito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Restrito";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Acesso_Priv;
    }
}