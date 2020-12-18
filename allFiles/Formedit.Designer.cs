namespace ПОПОИСКВАКАНСИЙ2
{
    partial class Formedit
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
            this.zptextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.descriptiontextBox = new System.Windows.Forms.TextBox();
            this.mailtextBox = new System.Windows.Forms.TextBox();
            this.teltextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.create1 = new System.Windows.Forms.Button();
            this.path1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zptextBox
            // 
            this.zptextBox.Location = new System.Drawing.Point(72, 108);
            this.zptextBox.Name = "zptextBox";
            this.zptextBox.Size = new System.Drawing.Size(161, 20);
            this.zptextBox.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "Зарплата:";
            // 
            // descriptiontextBox
            // 
            this.descriptiontextBox.Location = new System.Drawing.Point(15, 78);
            this.descriptiontextBox.Name = "descriptiontextBox";
            this.descriptiontextBox.Size = new System.Drawing.Size(347, 20);
            this.descriptiontextBox.TabIndex = 82;
            // 
            // mailtextBox
            // 
            this.mailtextBox.Location = new System.Drawing.Point(198, 39);
            this.mailtextBox.Name = "mailtextBox";
            this.mailtextBox.Size = new System.Drawing.Size(164, 20);
            this.mailtextBox.TabIndex = 81;
            // 
            // teltextBox
            // 
            this.teltextBox.Location = new System.Drawing.Point(38, 39);
            this.teltextBox.Name = "teltextBox";
            this.teltextBox.Size = new System.Drawing.Size(120, 20);
            this.teltextBox.TabIndex = 80;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(55, 16);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(164, 20);
            this.nametextBox.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "описание работы:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Тел:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "ФИО:";
            // 
            // create1
            // 
            this.create1.Location = new System.Drawing.Point(15, 134);
            this.create1.Name = "create1";
            this.create1.Size = new System.Drawing.Size(348, 23);
            this.create1.TabIndex = 85;
            this.create1.Text = "Создать вакансию";
            this.create1.UseVisualStyleBackColor = true;
            this.create1.Click += new System.EventHandler(this.create1_Click);
            // 
            // path1
            // 
            this.path1.AutoSize = true;
            this.path1.Location = new System.Drawing.Point(174, 163);
            this.path1.Name = "path1";
            this.path1.Size = new System.Drawing.Size(97, 13);
            this.path1.TabIndex = 86;
            this.path1.Text = "\"D:\\data base.txt\";";
            // 
            // Formedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 172);
            this.Controls.Add(this.path1);
            this.Controls.Add(this.create1);
            this.Controls.Add(this.zptextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.descriptiontextBox);
            this.Controls.Add(this.mailtextBox);
            this.Controls.Add(this.teltextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Formedit";
            this.Text = "Formedit";
            this.Load += new System.EventHandler(this.Formedit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zptextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox descriptiontextBox;
        private System.Windows.Forms.TextBox mailtextBox;
        private System.Windows.Forms.TextBox teltextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button create1;
        public System.Windows.Forms.Label path1;
    }
}