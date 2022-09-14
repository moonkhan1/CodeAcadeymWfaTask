
namespace WFAAppCodeAcademy
{
    partial class Form2
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
            this.SecondFormText = new System.Windows.Forms.Label();
            this.CloseText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SecondFormText
            // 
            this.SecondFormText.BackColor = System.Drawing.Color.Lime;
            this.SecondFormText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SecondFormText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.8F);
            this.SecondFormText.ForeColor = System.Drawing.Color.Teal;
            this.SecondFormText.Location = new System.Drawing.Point(95, 99);
            this.SecondFormText.Name = "SecondFormText";
            this.SecondFormText.Size = new System.Drawing.Size(602, 73);
            this.SecondFormText.TabIndex = 1;
            this.SecondFormText.Text = "Giriş işlemi başarılı";
            this.SecondFormText.Click += new System.EventHandler(this.SecondFormText_Click);
            // 
            // CloseText
            // 
            this.CloseText.BackColor = System.Drawing.Color.DarkRed;
            this.CloseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.CloseText.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CloseText.Location = new System.Drawing.Point(135, 296);
            this.CloseText.Name = "CloseText";
            this.CloseText.Size = new System.Drawing.Size(511, 104);
            this.CloseText.TabIndex = 2;
            this.CloseText.Text = "Bu pencere 3 saniye içinde kendi kendini imha edecek";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseText);
            this.Controls.Add(this.SecondFormText);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label SecondFormText;
        private System.Windows.Forms.Label CloseText;
    }
}