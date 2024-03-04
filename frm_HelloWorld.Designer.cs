namespace WindowsFormsApp1
{
    partial class Frm_HelloWorld
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_title = new System.Windows.Forms.Label();
            this.Btn_leave = new System.Windows.Forms.Button();
            this.Btn_modifyLabel = new System.Windows.Forms.Button();
            this.Txt_LabelContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_title
            // 
            this.Lbl_title.AutoSize = true;
            this.Lbl_title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_title.Location = new System.Drawing.Point(30, 30);
            this.Lbl_title.Name = "Lbl_title";
            this.Lbl_title.Size = new System.Drawing.Size(263, 24);
            this.Lbl_title.TabIndex = 0;
            this.Lbl_title.Text = "Visual Studio .NET Version";
            // 
            // Btn_leave
            // 
            this.Btn_leave.Location = new System.Drawing.Point(638, 398);
            this.Btn_leave.Name = "Btn_leave";
            this.Btn_leave.Size = new System.Drawing.Size(150, 40);
            this.Btn_leave.TabIndex = 1;
            this.Btn_leave.Text = "Sair";
            this.Btn_leave.UseVisualStyleBackColor = true;
            this.Btn_leave.Click += new System.EventHandler(this.Btn_leave_Click);
            // 
            // Btn_modifyLabel
            // 
            this.Btn_modifyLabel.Location = new System.Drawing.Point(34, 77);
            this.Btn_modifyLabel.Name = "Btn_modifyLabel";
            this.Btn_modifyLabel.Size = new System.Drawing.Size(260, 40);
            this.Btn_modifyLabel.TabIndex = 2;
            this.Btn_modifyLabel.Text = "Modificar Título";
            this.Btn_modifyLabel.UseVisualStyleBackColor = true;
            this.Btn_modifyLabel.Click += new System.EventHandler(this.Btn_modifyLabel_Click);
            // 
            // Txt_LabelContent
            // 
            this.Txt_LabelContent.Location = new System.Drawing.Point(33, 123);
            this.Txt_LabelContent.Name = "Txt_LabelContent";
            this.Txt_LabelContent.Size = new System.Drawing.Size(260, 22);
            this.Txt_LabelContent.TabIndex = 3;
            // 
            // Frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_LabelContent);
            this.Controls.Add(this.Btn_modifyLabel);
            this.Controls.Add(this.Btn_leave);
            this.Controls.Add(this.Lbl_title);
            this.Name = "Frm_HelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_title;
        private System.Windows.Forms.Button Btn_leave;
        private System.Windows.Forms.Button Btn_modifyLabel;
        private System.Windows.Forms.TextBox Txt_LabelContent;
    }
}

