namespace Mini_Project_2
{
    partial class FormDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDescription));
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoginP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(397, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(805, 73);
            this.label3.TabIndex = 9;
            this.label3.Text = "PROJECT DESCRIPTION";
            // 
            // btnLoginP
            // 
            this.btnLoginP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginP.ForeColor = System.Drawing.Color.Coral;
            this.btnLoginP.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLoginP.Location = new System.Drawing.Point(1126, 697);
            this.btnLoginP.Name = "btnLoginP";
            this.btnLoginP.Size = new System.Drawing.Size(219, 63);
            this.btnLoginP.TabIndex = 54;
            this.btnLoginP.Text = "Continue";
            this.btnLoginP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoginP.UseVisualStyleBackColor = true;
            this.btnLoginP.Click += new System.EventHandler(this.btnLoginP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(49, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1262, 528);
            this.label1.TabIndex = 55;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // FormDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::Mini_Project_2.Properties.Resources.don_bosco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoginP);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDescription";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoginP;
        private System.Windows.Forms.Label label1;
    }
}