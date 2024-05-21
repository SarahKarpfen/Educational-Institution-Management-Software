namespace FinalOOPtr
{
    partial class StudentsMenagForm
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.grpBoxSignIn = new System.Windows.Forms.GroupBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtNumberPhone = new System.Windows.Forms.TextBox();
            this.lblNumberPhone = new System.Windows.Forms.Label();
            this.txtLastSchool = new System.Windows.Forms.TextBox();
            this.lblLastSchool = new System.Windows.Forms.Label();
            this.txtHighSchoolClass = new System.Windows.Forms.TextBox();
            this.lblHighSchoolClass = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblHighSchoolName = new System.Windows.Forms.Label();
            this.lblHighSchoolAddress = new System.Windows.Forms.Label();
            this.grpBoxSignInDetails = new System.Windows.Forms.GroupBox();
            this.lblNumGotOKStudents = new System.Windows.Forms.Label();
            this.lblNumSignInStudents = new System.Windows.Forms.Label();
            this.lblGotOKStudents = new System.Windows.Forms.Label();
            this.lblNewStudents = new System.Windows.Forms.Label();
            this.btnOKlist = new System.Windows.Forms.Button();
            this.btnReturnOKlist = new System.Windows.Forms.Button();
            this.lblSignInStudentsDetails = new System.Windows.Forms.Label();
            this.dataGVSignInStudentsDetails = new System.Windows.Forms.DataGridView();
            this.btnSortByClass = new System.Windows.Forms.Button();
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.grpBoxSignIn.SuspendLayout();
            this.grpBoxSignInDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSignInStudentsDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Campain", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFullName.Location = new System.Drawing.Point(272, 47);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(87, 23);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "שם מלא";
            // 
            // grpBoxSignIn
            // 
            this.grpBoxSignIn.Controls.Add(this.btnSignIn);
            this.grpBoxSignIn.Controls.Add(this.txtAddress);
            this.grpBoxSignIn.Controls.Add(this.lblAddress);
            this.grpBoxSignIn.Controls.Add(this.txtNumberPhone);
            this.grpBoxSignIn.Controls.Add(this.lblNumberPhone);
            this.grpBoxSignIn.Controls.Add(this.txtLastSchool);
            this.grpBoxSignIn.Controls.Add(this.lblLastSchool);
            this.grpBoxSignIn.Controls.Add(this.txtHighSchoolClass);
            this.grpBoxSignIn.Controls.Add(this.lblHighSchoolClass);
            this.grpBoxSignIn.Controls.Add(this.txtFullName);
            this.grpBoxSignIn.Controls.Add(this.lblFullName);
            this.grpBoxSignIn.Font = new System.Drawing.Font("Campain", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grpBoxSignIn.Location = new System.Drawing.Point(841, 170);
            this.grpBoxSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxSignIn.Name = "grpBoxSignIn";
            this.grpBoxSignIn.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxSignIn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpBoxSignIn.Size = new System.Drawing.Size(380, 336);
            this.grpBoxSignIn.TabIndex = 1;
            this.grpBoxSignIn.TabStop = false;
            this.grpBoxSignIn.Text = "הרשמה";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(23, 262);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(330, 46);
            this.btnSignIn.TabIndex = 10;
            this.btnSignIn.Text = "הרשמה";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtAddress.Location = new System.Drawing.Point(21, 201);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(260, 27);
            this.txtAddress.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Campain", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAddress.Location = new System.Drawing.Point(288, 207);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(71, 23);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "כתובת";
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNumberPhone.Location = new System.Drawing.Point(21, 161);
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.Size = new System.Drawing.Size(274, 27);
            this.txtNumberPhone.TabIndex = 7;
            // 
            // lblNumberPhone
            // 
            this.lblNumberPhone.AutoSize = true;
            this.lblNumberPhone.Font = new System.Drawing.Font("Campain", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumberPhone.Location = new System.Drawing.Point(296, 167);
            this.lblNumberPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberPhone.Name = "lblNumberPhone";
            this.lblNumberPhone.Size = new System.Drawing.Size(63, 23);
            this.lblNumberPhone.TabIndex = 6;
            this.lblNumberPhone.Text = "טלפון";
            // 
            // txtLastSchool
            // 
            this.txtLastSchool.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtLastSchool.Location = new System.Drawing.Point(21, 121);
            this.txtLastSchool.Name = "txtLastSchool";
            this.txtLastSchool.Size = new System.Drawing.Size(178, 27);
            this.txtLastSchool.TabIndex = 5;
            // 
            // lblLastSchool
            // 
            this.lblLastSchool.AutoSize = true;
            this.lblLastSchool.Font = new System.Drawing.Font("Campain", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLastSchool.Location = new System.Drawing.Point(206, 127);
            this.lblLastSchool.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastSchool.Name = "lblLastSchool";
            this.lblLastSchool.Size = new System.Drawing.Size(142, 23);
            this.lblLastSchool.TabIndex = 4;
            this.lblLastSchool.Text = "בית ספר קודם";
            // 
            // txtHighSchoolClass
            // 
            this.txtHighSchoolClass.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtHighSchoolClass.Location = new System.Drawing.Point(21, 81);
            this.txtHighSchoolClass.Name = "txtHighSchoolClass";
            this.txtHighSchoolClass.Size = new System.Drawing.Size(274, 27);
            this.txtHighSchoolClass.TabIndex = 3;
            // 
            // lblHighSchoolClass
            // 
            this.lblHighSchoolClass.AutoSize = true;
            this.lblHighSchoolClass.Font = new System.Drawing.Font("Campain", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHighSchoolClass.Location = new System.Drawing.Point(302, 87);
            this.lblHighSchoolClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHighSchoolClass.Name = "lblHighSchoolClass";
            this.lblHighSchoolClass.Size = new System.Drawing.Size(57, 23);
            this.lblHighSchoolClass.TabIndex = 2;
            this.lblHighSchoolClass.Text = "כיתה";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFullName.Location = new System.Drawing.Point(23, 46);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(244, 27);
            this.txtFullName.TabIndex = 1;
            // 
            // lblHighSchoolName
            // 
            this.lblHighSchoolName.AutoSize = true;
            this.lblHighSchoolName.Font = new System.Drawing.Font("Campain", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHighSchoolName.Location = new System.Drawing.Point(471, 32);
            this.lblHighSchoolName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHighSchoolName.Name = "lblHighSchoolName";
            this.lblHighSchoolName.Size = new System.Drawing.Size(0, 47);
            this.lblHighSchoolName.TabIndex = 2;
            // 
            // lblHighSchoolAddress
            // 
            this.lblHighSchoolAddress.AutoSize = true;
            this.lblHighSchoolAddress.Font = new System.Drawing.Font("Campain", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHighSchoolAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHighSchoolAddress.Location = new System.Drawing.Point(535, 78);
            this.lblHighSchoolAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHighSchoolAddress.Name = "lblHighSchoolAddress";
            this.lblHighSchoolAddress.Size = new System.Drawing.Size(0, 23);
            this.lblHighSchoolAddress.TabIndex = 3;
            // 
            // grpBoxSignInDetails
            // 
            this.grpBoxSignInDetails.Controls.Add(this.lblNumGotOKStudents);
            this.grpBoxSignInDetails.Controls.Add(this.lblNumSignInStudents);
            this.grpBoxSignInDetails.Controls.Add(this.lblGotOKStudents);
            this.grpBoxSignInDetails.Controls.Add(this.lblNewStudents);
            this.grpBoxSignInDetails.Font = new System.Drawing.Font("Campain", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grpBoxSignInDetails.Location = new System.Drawing.Point(841, 588);
            this.grpBoxSignInDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxSignInDetails.Name = "grpBoxSignInDetails";
            this.grpBoxSignInDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxSignInDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpBoxSignInDetails.Size = new System.Drawing.Size(380, 115);
            this.grpBoxSignInDetails.TabIndex = 4;
            this.grpBoxSignInDetails.TabStop = false;
            this.grpBoxSignInDetails.Text = "פרטי רישום כלליים";
            // 
            // lblNumGotOKStudents
            // 
            this.lblNumGotOKStudents.AutoSize = true;
            this.lblNumGotOKStudents.Font = new System.Drawing.Font("Campain", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumGotOKStudents.Location = new System.Drawing.Point(58, 70);
            this.lblNumGotOKStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumGotOKStudents.Name = "lblNumGotOKStudents";
            this.lblNumGotOKStudents.Size = new System.Drawing.Size(0, 23);
            this.lblNumGotOKStudents.TabIndex = 4;
            // 
            // lblNumSignInStudents
            // 
            this.lblNumSignInStudents.AutoSize = true;
            this.lblNumSignInStudents.Font = new System.Drawing.Font("Campain", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumSignInStudents.Location = new System.Drawing.Point(58, 47);
            this.lblNumSignInStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumSignInStudents.Name = "lblNumSignInStudents";
            this.lblNumSignInStudents.Size = new System.Drawing.Size(0, 23);
            this.lblNumSignInStudents.TabIndex = 3;
            // 
            // lblGotOKStudents
            // 
            this.lblGotOKStudents.AutoSize = true;
            this.lblGotOKStudents.Font = new System.Drawing.Font("Campain", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGotOKStudents.Location = new System.Drawing.Point(182, 70);
            this.lblGotOKStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGotOKStudents.Name = "lblGotOKStudents";
            this.lblGotOKStudents.Size = new System.Drawing.Size(162, 23);
            this.lblGotOKStudents.TabIndex = 2;
            this.lblGotOKStudents.Text = "מתוכן התקבלו:";
            // 
            // lblNewStudents
            // 
            this.lblNewStudents.AutoSize = true;
            this.lblNewStudents.Font = new System.Drawing.Font("Campain", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNewStudents.Location = new System.Drawing.Point(186, 47);
            this.lblNewStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewStudents.Name = "lblNewStudents";
            this.lblNewStudents.Size = new System.Drawing.Size(162, 23);
            this.lblNewStudents.TabIndex = 0;
            this.lblNewStudents.Text = "מספר נרשמות:";
            // 
            // btnOKlist
            // 
            this.btnOKlist.Font = new System.Drawing.Font("Campain", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOKlist.Location = new System.Drawing.Point(1036, 528);
            this.btnOKlist.Name = "btnOKlist";
            this.btnOKlist.Size = new System.Drawing.Size(189, 38);
            this.btnOKlist.TabIndex = 6;
            this.btnOKlist.Text = "רשימת בנות לאישור";
            this.btnOKlist.UseVisualStyleBackColor = true;
            this.btnOKlist.Click += new System.EventHandler(this.btnOKlist_Click);
            // 
            // btnReturnOKlist
            // 
            this.btnReturnOKlist.Font = new System.Drawing.Font("Campain", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnReturnOKlist.Location = new System.Drawing.Point(841, 528);
            this.btnReturnOKlist.Name = "btnReturnOKlist";
            this.btnReturnOKlist.Size = new System.Drawing.Size(189, 38);
            this.btnReturnOKlist.TabIndex = 5;
            this.btnReturnOKlist.Text = "רשימת בנות לאישור חוזר";
            this.btnReturnOKlist.UseVisualStyleBackColor = true;
            this.btnReturnOKlist.Click += new System.EventHandler(this.btnReturnOKlist_Click);
            // 
            // lblSignInStudentsDetails
            // 
            this.lblSignInStudentsDetails.AutoSize = true;
            this.lblSignInStudentsDetails.Font = new System.Drawing.Font("Campain", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSignInStudentsDetails.Location = new System.Drawing.Point(275, 170);
            this.lblSignInStudentsDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignInStudentsDetails.Name = "lblSignInStudentsDetails";
            this.lblSignInStudentsDetails.Size = new System.Drawing.Size(313, 28);
            this.lblSignInStudentsDetails.TabIndex = 5;
            this.lblSignInStudentsDetails.Text = "פרטי תלמידות שהתקבלו";
            // 
            // dataGVSignInStudentsDetails
            // 
            this.dataGVSignInStudentsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVSignInStudentsDetails.Location = new System.Drawing.Point(51, 201);
            this.dataGVSignInStudentsDetails.Name = "dataGVSignInStudentsDetails";
            this.dataGVSignInStudentsDetails.RowHeadersWidth = 51;
            this.dataGVSignInStudentsDetails.RowTemplate.Height = 24;
            this.dataGVSignInStudentsDetails.Size = new System.Drawing.Size(750, 445);
            this.dataGVSignInStudentsDetails.TabIndex = 6;
            // 
            // btnSortByClass
            // 
            this.btnSortByClass.Font = new System.Drawing.Font("Campain", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSortByClass.Location = new System.Drawing.Point(51, 652);
            this.btnSortByClass.Name = "btnSortByClass";
            this.btnSortByClass.Size = new System.Drawing.Size(241, 51);
            this.btnSortByClass.TabIndex = 7;
            this.btnSortByClass.Text = "מיון על-פי כיתה";
            this.btnSortByClass.UseVisualStyleBackColor = true;
            this.btnSortByClass.Click += new System.EventHandler(this.btnSortByClass_Click);
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.Font = new System.Drawing.Font("Campain", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnShowStudents.Location = new System.Drawing.Point(634, 652);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(167, 51);
            this.btnShowStudents.TabIndex = 8;
            this.btnShowStudents.Text = "הצגה";
            this.btnShowStudents.UseVisualStyleBackColor = true;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudents_Click);
            // 
            // StudentsMenagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 745);
            this.Controls.Add(this.btnOKlist);
            this.Controls.Add(this.btnReturnOKlist);
            this.Controls.Add(this.btnShowStudents);
            this.Controls.Add(this.btnSortByClass);
            this.Controls.Add(this.dataGVSignInStudentsDetails);
            this.Controls.Add(this.lblSignInStudentsDetails);
            this.Controls.Add(this.grpBoxSignInDetails);
            this.Controls.Add(this.lblHighSchoolAddress);
            this.Controls.Add(this.lblHighSchoolName);
            this.Controls.Add(this.grpBoxSignIn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentsMenagForm";
            this.Text = "ניהול תלמידות";
            this.Load += new System.EventHandler(this.StudentsMenagForm_Load);
            this.grpBoxSignIn.ResumeLayout(false);
            this.grpBoxSignIn.PerformLayout();
            this.grpBoxSignInDetails.ResumeLayout(false);
            this.grpBoxSignInDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSignInStudentsDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.GroupBox grpBoxSignIn;
        private System.Windows.Forms.Label lblHighSchoolName;
        private System.Windows.Forms.Label lblHighSchoolAddress;
        private System.Windows.Forms.TextBox txtHighSchoolClass;
        private System.Windows.Forms.Label lblHighSchoolClass;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtLastSchool;
        private System.Windows.Forms.Label lblLastSchool;
        private System.Windows.Forms.TextBox txtNumberPhone;
        private System.Windows.Forms.Label lblNumberPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox grpBoxSignInDetails;
        private System.Windows.Forms.Label lblGotOKStudents;
        private System.Windows.Forms.Label lblNewStudents;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblNumSignInStudents;
        private System.Windows.Forms.Label lblNumGotOKStudents;
        private System.Windows.Forms.Button btnOKlist;
        private System.Windows.Forms.Button btnReturnOKlist;
        private System.Windows.Forms.Label lblSignInStudentsDetails;
        private System.Windows.Forms.DataGridView dataGVSignInStudentsDetails;
        private System.Windows.Forms.Button btnSortByClass;
        private System.Windows.Forms.Button btnShowStudents;
    }
}