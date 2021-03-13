
namespace Form2ClassWork
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.birthdateLbl = new System.Windows.Forms.Label();
            this.nameTxtb = new System.Windows.Forms.TextBox();
            this.surnameTxtb = new System.Windows.Forms.TextBox();
            this.emailTxtb = new System.Windows.Forms.TextBox();
            this.phoneMtxtb = new System.Windows.Forms.MaskedTextBox();
            this.birthdateDtp = new System.Windows.Forms.DateTimePicker();
            this.changeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.usersLstb = new System.Windows.Forms.ListBox();
            this.fileTxtb = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(12, 21);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(78, 29);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLbl.Location = new System.Drawing.Point(12, 70);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(110, 29);
            this.surnameLbl.TabIndex = 1;
            this.surnameLbl.Text = "Surname";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(12, 117);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(74, 29);
            this.emailLbl.TabIndex = 2;
            this.emailLbl.Text = "Email";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.Location = new System.Drawing.Point(12, 163);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(83, 29);
            this.phoneLbl.TabIndex = 3;
            this.phoneLbl.Text = "Phone";
            // 
            // birthdateLbl
            // 
            this.birthdateLbl.AutoSize = true;
            this.birthdateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateLbl.Location = new System.Drawing.Point(12, 213);
            this.birthdateLbl.Name = "birthdateLbl";
            this.birthdateLbl.Size = new System.Drawing.Size(109, 29);
            this.birthdateLbl.TabIndex = 4;
            this.birthdateLbl.Text = "Birthdate";
            // 
            // nameTxtb
            // 
            this.nameTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtb.Location = new System.Drawing.Point(171, 18);
            this.nameTxtb.Name = "nameTxtb";
            this.nameTxtb.Size = new System.Drawing.Size(229, 34);
            this.nameTxtb.TabIndex = 5;
            // 
            // surnameTxtb
            // 
            this.surnameTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTxtb.Location = new System.Drawing.Point(171, 67);
            this.surnameTxtb.Name = "surnameTxtb";
            this.surnameTxtb.Size = new System.Drawing.Size(229, 34);
            this.surnameTxtb.TabIndex = 6;
            // 
            // emailTxtb
            // 
            this.emailTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxtb.Location = new System.Drawing.Point(171, 114);
            this.emailTxtb.Name = "emailTxtb";
            this.emailTxtb.Size = new System.Drawing.Size(229, 34);
            this.emailTxtb.TabIndex = 7;
            // 
            // phoneMtxtb
            // 
            this.phoneMtxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneMtxtb.Location = new System.Drawing.Point(171, 160);
            this.phoneMtxtb.Mask = "+(000)00-000-00-00";
            this.phoneMtxtb.Name = "phoneMtxtb";
            this.phoneMtxtb.Size = new System.Drawing.Size(229, 34);
            this.phoneMtxtb.TabIndex = 8;
            // 
            // birthdateDtp
            // 
            this.birthdateDtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateDtp.Location = new System.Drawing.Point(171, 213);
            this.birthdateDtp.Name = "birthdateDtp";
            this.birthdateDtp.Size = new System.Drawing.Size(229, 27);
            this.birthdateDtp.TabIndex = 9;
            // 
            // changeBtn
            // 
            this.changeBtn.AutoSize = true;
            this.changeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBtn.Location = new System.Drawing.Point(295, 290);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(105, 42);
            this.changeBtn.TabIndex = 10;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.AutoSize = true;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(269, 355);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(131, 66);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // usersLstb
            // 
            this.usersLstb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersLstb.FormattingEnabled = true;
            this.usersLstb.ItemHeight = 25;
            this.usersLstb.Location = new System.Drawing.Point(592, 18);
            this.usersLstb.Name = "usersLstb";
            this.usersLstb.Size = new System.Drawing.Size(245, 304);
            this.usersLstb.TabIndex = 12;
            this.usersLstb.SelectedIndexChanged += new System.EventHandler(this.usersLstb_SelectedIndexChanged);
            // 
            // fileTxtb
            // 
            this.fileTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileTxtb.Location = new System.Drawing.Point(592, 328);
            this.fileTxtb.Name = "fileTxtb";
            this.fileTxtb.Size = new System.Drawing.Size(245, 30);
            this.fileTxtb.TabIndex = 13;
            // 
            // saveBtn
            // 
            this.saveBtn.AutoSize = true;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(592, 376);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(109, 45);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.AutoSize = true;
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.Location = new System.Drawing.Point(728, 376);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(109, 45);
            this.loadBtn.TabIndex = 15;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 530);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.fileTxtb);
            this.Controls.Add(this.usersLstb);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.birthdateDtp);
            this.Controls.Add(this.phoneMtxtb);
            this.Controls.Add(this.emailTxtb);
            this.Controls.Add(this.surnameTxtb);
            this.Controls.Add(this.nameTxtb);
            this.Controls.Add(this.birthdateLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label birthdateLbl;
        private System.Windows.Forms.TextBox nameTxtb;
        private System.Windows.Forms.TextBox surnameTxtb;
        private System.Windows.Forms.TextBox emailTxtb;
        private System.Windows.Forms.MaskedTextBox phoneMtxtb;
        private System.Windows.Forms.DateTimePicker birthdateDtp;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox usersLstb;
        private System.Windows.Forms.TextBox fileTxtb;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
    }
}

