
namespace Sistema_Lanchonete
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEntrarFormLogin = new System.Windows.Forms.Button();
            this.btnSairLoginForm = new System.Windows.Forms.Button();
            this.txtUsuarioFormLogin = new System.Windows.Forms.TextBox();
            this.txtSenhaFormLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // btnEntrarFormLogin
            // 
            this.btnEntrarFormLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrarFormLogin.Location = new System.Drawing.Point(167, 209);
            this.btnEntrarFormLogin.Name = "btnEntrarFormLogin";
            this.btnEntrarFormLogin.Size = new System.Drawing.Size(75, 23);
            this.btnEntrarFormLogin.TabIndex = 2;
            this.btnEntrarFormLogin.Text = "Entrar";
            this.btnEntrarFormLogin.UseVisualStyleBackColor = true;
            // 
            // btnSairLoginForm
            // 
            this.btnSairLoginForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSairLoginForm.Location = new System.Drawing.Point(301, 209);
            this.btnSairLoginForm.Name = "btnSairLoginForm";
            this.btnSairLoginForm.Size = new System.Drawing.Size(75, 23);
            this.btnSairLoginForm.TabIndex = 3;
            this.btnSairLoginForm.Text = "Sair";
            this.btnSairLoginForm.UseVisualStyleBackColor = true;
            // 
            // txtUsuarioFormLogin
            // 
            this.txtUsuarioFormLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuarioFormLogin.Location = new System.Drawing.Point(289, 79);
            this.txtUsuarioFormLogin.Name = "txtUsuarioFormLogin";
            this.txtUsuarioFormLogin.Size = new System.Drawing.Size(100, 23);
            this.txtUsuarioFormLogin.TabIndex = 4;
            // 
            // txtSenhaFormLogin
            // 
            this.txtSenhaFormLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaFormLogin.Location = new System.Drawing.Point(289, 148);
            this.txtSenhaFormLogin.Name = "txtSenhaFormLogin";
            this.txtSenhaFormLogin.Size = new System.Drawing.Size(100, 23);
            this.txtSenhaFormLogin.TabIndex = 5;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(584, 331);
            this.Controls.Add(this.txtSenhaFormLogin);
            this.Controls.Add(this.txtUsuarioFormLogin);
            this.Controls.Add(this.btnSairLoginForm);
            this.Controls.Add(this.btnEntrarFormLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEntrarFormLogin;
        private System.Windows.Forms.Button btnSairLoginForm;
        private System.Windows.Forms.TextBox txtUsuarioFormLogin;
        private System.Windows.Forms.TextBox txtSenhaFormLogin;
    }
}