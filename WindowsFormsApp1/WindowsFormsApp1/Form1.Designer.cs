﻿namespace WindowsFormsApp1
{
    partial class Form1
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
            this.studentgrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.txtstudentlastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfathername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstudenid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstudentaddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // studentgrid
            // 
            this.studentgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentgrid.Location = new System.Drawing.Point(12, 318);
            this.studentgrid.Name = "studentgrid";
            this.studentgrid.RowHeadersWidth = 51;
            this.studentgrid.RowTemplate.Height = 24;
            this.studentgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentgrid.Size = new System.Drawing.Size(791, 236);
            this.studentgrid.TabIndex = 0;
            this.studentgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentgrid_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(396, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(601, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 6, 6, 0);
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // txtstudentname
            // 
            this.txtstudentname.Location = new System.Drawing.Point(115, 33);
            this.txtstudentname.Multiline = true;
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(125, 33);
            this.txtstudentname.TabIndex = 6;
            // 
            // txtstudentlastname
            // 
            this.txtstudentlastname.Location = new System.Drawing.Point(115, 88);
            this.txtstudentlastname.Multiline = true;
            this.txtstudentlastname.Name = "txtstudentlastname";
            this.txtstudentlastname.Size = new System.Drawing.Size(125, 30);
            this.txtstudentlastname.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 6, 6, 0);
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // txtfathername
            // 
            this.txtfathername.Location = new System.Drawing.Point(115, 152);
            this.txtfathername.Multiline = true;
            this.txtfathername.Name = "txtfathername";
            this.txtfathername.Size = new System.Drawing.Size(125, 30);
            this.txtfathername.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 6, 6, 0);
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Father Name";
            // 
            // txtstudenid
            // 
            this.txtstudenid.Location = new System.Drawing.Point(376, 33);
            this.txtstudenid.Multiline = true;
            this.txtstudenid.Name = "txtstudenid";
            this.txtstudenid.Size = new System.Drawing.Size(165, 33);
            this.txtstudenid.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 33);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 6, 6, 0);
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "StudentReg";
            // 
            // txtstudentaddress
            // 
            this.txtstudentaddress.Location = new System.Drawing.Point(376, 85);
            this.txtstudentaddress.Multiline = true;
            this.txtstudentaddress.Name = "txtstudentaddress";
            this.txtstudentaddress.Size = new System.Drawing.Size(165, 33);
            this.txtstudentaddress.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 85);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 6, 6, 0);
            this.label5.Size = new System.Drawing.Size(64, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Address";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(815, 567);
            this.Controls.Add(this.txtstudentaddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtstudenid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfathername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtstudentlastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtstudentname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.studentgrid);
            this.Name = "Form1";
            this.Text = "Student Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentgrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.TextBox txtstudentlastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfathername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtstudenid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstudentaddress;
        private System.Windows.Forms.Label label5;
    }
}

