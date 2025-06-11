namespace ExemploAula
{
    partial class Form1
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
            lbllogin = new Label();
            lblusuario = new Label();
            lblsenha = new Label();
            txtusuario = new TextBox();
            txtsenha = new TextBox();
            btnlogar = new Button();
            SuspendLayout();
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lbllogin.Location = new Point(124, 29);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(54, 23);
            lbllogin.TabIndex = 0;
            lbllogin.Text = "Login";
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblusuario.Location = new Point(60, 90);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(69, 23);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "Usuário";
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblsenha.Location = new Point(60, 145);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(58, 23);
            lblsenha.TabIndex = 2;
            lblsenha.Text = "Senha";
            // 
            // txtusuario
            // 
            txtusuario.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            txtusuario.Location = new Point(156, 90);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(100, 29);
            txtusuario.TabIndex = 3;
            // 
            // txtsenha
            // 
            txtsenha.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            txtsenha.Location = new Point(156, 145);
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.Size = new Size(100, 29);
            txtsenha.TabIndex = 4;
            // 
            // btnlogar
            // 
            btnlogar.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            btnlogar.Location = new Point(124, 218);
            btnlogar.Name = "btnlogar";
            btnlogar.Size = new Size(75, 34);
            btnlogar.TabIndex = 5;
            btnlogar.Text = "Logar";
            btnlogar.UseVisualStyleBackColor = true;
            btnlogar.Click += btnlogar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogar);
            Controls.Add(txtsenha);
            Controls.Add(txtusuario);
            Controls.Add(lblsenha);
            Controls.Add(lblusuario);
            Controls.Add(lbllogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllogin;
        private Label lblusuario;
        private Label lblsenha;
        private TextBox txtusuario;
        private TextBox txtsenha;
        private Button btnlogar;
    }
}
