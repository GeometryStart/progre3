
namespace WindowsFormsApp2
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
            this.SuspendLayout();
            // 
            // btnTervita
            // 
            this.btnTervita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTervita.Location = new System.Drawing.Point(373, 189);
            this.btnTervita.Name = "btnTervita";
            this.btnTervita.Size = new System.Drawing.Size(75, 23);
            this.btnTervita.TabIndex = 0;
            this.btnTervita.Text = "Tervita";
            this.btnTervita.UseVisualStyleBackColor = true;
            this.btnTervita.Click += new System.EventHandler(this.BtnTervita_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTervita);
            this.Name = "MainForm";
            this.Text = "Minu esimene WInForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTervita;
    }
}

