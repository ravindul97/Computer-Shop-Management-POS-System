namespace Thilakarathna_PC_Software
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.passw = new System.Windows.Forms.TextBox();
            this.loginb = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 255);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(296, 343);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // user_name
            // 
            this.user_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(495, 255);
            this.user_name.Margin = new System.Windows.Forms.Padding(4);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(324, 35);
            this.user_name.TabIndex = 2;
            this.user_name.TextChanged += new System.EventHandler(this.user_name_TextChanged);
            // 
            // passw
            // 
            this.passw.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passw.Location = new System.Drawing.Point(495, 345);
            this.passw.Margin = new System.Windows.Forms.Padding(4);
            this.passw.Name = "passw";
            this.passw.Size = new System.Drawing.Size(324, 35);
            this.passw.TabIndex = 3;
            this.passw.TextChanged += new System.EventHandler(this.passw_TextChanged);
            // 
            // loginb
            // 
            this.loginb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginb.ForeColor = System.Drawing.Color.Black;
            this.loginb.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.loginb.Location = new System.Drawing.Point(300, 521);
            this.loginb.Margin = new System.Windows.Forms.Padding(4);
            this.loginb.Name = "loginb";
            this.loginb.Size = new System.Drawing.Size(133, 49);
            this.loginb.TabIndex = 4;
            this.loginb.Text = "Login";
            this.loginb.UseVisualStyleBackColor = true;
            this.loginb.Click += new System.EventHandler(this.button1_Click);
            // 
            // clear
            // 
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.Black;
            this.clear.Location = new System.Drawing.Point(495, 521);
            this.clear.Margin = new System.Windows.Forms.Padding(4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(133, 49);
            this.clear.TabIndex = 5;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(687, 521);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(133, 49);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1109, 668);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.loginb);
            this.Controls.Add(this.passw);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1127, 715);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1127, 715);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox passw;
        private System.Windows.Forms.Button loginb;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
    }
}