namespace ExemploAula
{
    partial class frmvalido
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
            lblbemvindo = new Label();
            btnvoltar = new Button();
            SuspendLayout();
            // 
            // lblbemvindo
            // 
            lblbemvindo.AutoSize = true;
            lblbemvindo.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbemvindo.Location = new Point(275, 136);
            lblbemvindo.Name = "lblbemvindo";
            lblbemvindo.Size = new Size(249, 29);
            lblbemvindo.TabIndex = 0;
            lblbemvindo.Text = "seja bem-vindo ao menu!";
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(684, 401);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(75, 23);
            btnvoltar.TabIndex = 1;
            btnvoltar.Text = "voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // frmvalido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnvoltar);
            Controls.Add(lblbemvindo);
            Name = "frmvalido";
            Text = "menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblbemvindo;
        private Button btnvoltar;
    }
}