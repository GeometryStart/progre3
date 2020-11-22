
namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.btnTervita = new System.Windows.Forms.Button();
            this.lblNimi = new System.Windows.Forms.Label();
            this.txtNimi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTervita
            // 
            this.btnTervita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTervita.Location = new System.Drawing.Point(383, 205);
            this.btnTervita.Name = "btnTervita";
            this.btnTervita.Size = new System.Drawing.Size(75, 23);
            this.btnTervita.TabIndex = 0;
            this.btnTervita.Text = "Tervita";
            this.btnTervita.UseVisualStyleBackColor = true;
            this.btnTervita.Click += new System.EventHandler(this.btnTervita_Click);
            // 
            // lblNimi
            // 
            this.lblNimi.AutoSize = true;
            this.lblNimi.Location = new System.Drawing.Point(350, 158);
            this.lblNimi.Name = "lblNimi";
            this.lblNimi.Size = new System.Drawing.Size(27, 13);
            this.lblNimi.TabIndex = 1;
            this.lblNimi.Text = "Nimi";
            this.lblNimi.UseMnemonic = false;
            // 
            // txtNimi
            // 
            this.txtNimi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNimi.Location = new System.Drawing.Point(383, 155);
            this.txtNimi.Name = "txtNimi";
            this.txtNimi.Size = new System.Drawing.Size(169, 20);
            this.txtNimi.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNimi);
            this.Controls.Add(this.lblNimi);
            this.Controls.Add(this.btnTervita);
            this.Name = "MainForm";
            this.Text = "Minu esimene WinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTervita;
        private System.Windows.Forms.Label lblNimi;
        private System.Windows.Forms.TextBox txtNimi;
    }
}

