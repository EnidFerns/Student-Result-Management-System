
namespace Mini_Project_2
{
    partial class FormStudentForgot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentForgot));
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnCode = new System.Windows.Forms.Button();
            this.txtemailid = new System.Windows.Forms.TextBox();
            this.textcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoginP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmail
            // 
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.ForeColor = System.Drawing.Color.Coral;
            this.btnEmail.Location = new System.Drawing.Point(909, 213);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(243, 46);
            this.btnEmail.TabIndex = 0;
            this.btnEmail.Text = "Send Passcode";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnCode
            // 
            this.btnCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCode.ForeColor = System.Drawing.Color.Coral;
            this.btnCode.Location = new System.Drawing.Point(909, 408);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(243, 46);
            this.btnCode.TabIndex = 0;
            this.btnCode.Text = "Confirm";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // txtemailid
            // 
            this.txtemailid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailid.Location = new System.Drawing.Point(797, 152);
            this.txtemailid.Name = "txtemailid";
            this.txtemailid.Size = new System.Drawing.Size(235, 35);
            this.txtemailid.TabIndex = 1;
            // 
            // textcode
            // 
            this.textcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcode.Location = new System.Drawing.Point(797, 348);
            this.textcode.Name = "textcode";
            this.textcode.Size = new System.Drawing.Size(235, 35);
            this.textcode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(462, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Email Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(462, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Sent Passcode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "FORGOT PASSWORD PAGE";
            // 
            // btnLoginP
            // 
            this.btnLoginP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginP.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginP.ForeColor = System.Drawing.Color.Coral;
            this.btnLoginP.Image = ((System.Drawing.Image)(resources.GetObject("btnLoginP.Image")));
            this.btnLoginP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginP.Location = new System.Drawing.Point(635, 688);
            this.btnLoginP.Name = "btnLoginP";
            this.btnLoginP.Size = new System.Drawing.Size(277, 62);
            this.btnLoginP.TabIndex = 3;
            this.btnLoginP.Text = "    Login Page";
            this.btnLoginP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoginP.UseVisualStyleBackColor = true;
            this.btnLoginP.Click += new System.EventHandler(this.btnLoginP_Click);
            // 
            // FormStudentForgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::Mini_Project_2.Properties.Resources.don_bosco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoginP);
            this.Controls.Add(this.textcode);
            this.Controls.Add(this.txtemailid);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.btnEmail);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStudentForgot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmailverification";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.TextBox txtemailid;
        private System.Windows.Forms.TextBox textcode;
        private System.Windows.Forms.Button btnLoginP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}