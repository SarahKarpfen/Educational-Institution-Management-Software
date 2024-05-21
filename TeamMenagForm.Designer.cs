namespace FinalOOPtr
{
    partial class TeamMenagForm
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
            this.lblHighSchoolAddress = new System.Windows.Forms.Label();
            this.lblHighSchoolName = new System.Windows.Forms.Label();
            this.btnChangeTitle = new System.Windows.Forms.Button();
            this.btnIsSecratery = new System.Windows.Forms.Button();
            this.dataGVWorkersDetails = new System.Windows.Forms.DataGridView();
            this.lblWorkersDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpBoxAddWorker = new System.Windows.Forms.GroupBox();
            this.numUDHuresWork = new System.Windows.Forms.NumericUpDown();
            this.lblHuresWork = new System.Windows.Forms.Label();
            this.lblWorkType = new System.Windows.Forms.Label();
            this.rdBPhonly = new System.Windows.Forms.RadioButton();
            this.rdBEvening = new System.Windows.Forms.RadioButton();
            this.rdBNoon = new System.Windows.Forms.RadioButton();
            this.rdBMorning = new System.Windows.Forms.RadioButton();
            this.rdBSecratery = new System.Windows.Forms.RadioButton();
            this.rdBWorker = new System.Windows.Forms.RadioButton();
            this.rdBTeacher = new System.Windows.Forms.RadioButton();
            this.lblWorkerType = new System.Windows.Forms.Label();
            this.rdBManager = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVWorkersDetails)).BeginInit();
            this.grpBoxAddWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDHuresWork)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHighSchoolAddress
            // 
            this.lblHighSchoolAddress.AutoSize = true;
            this.lblHighSchoolAddress.Font = new System.Drawing.Font("Campain", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHighSchoolAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHighSchoolAddress.Location = new System.Drawing.Point(297, -64);
            this.lblHighSchoolAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHighSchoolAddress.Name = "lblHighSchoolAddress";
            this.lblHighSchoolAddress.Size = new System.Drawing.Size(0, 23);
            this.lblHighSchoolAddress.TabIndex = 11;
            // 
            // lblHighSchoolName
            // 
            this.lblHighSchoolName.AutoSize = true;
            this.lblHighSchoolName.Font = new System.Drawing.Font("Campain", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHighSchoolName.Location = new System.Drawing.Point(233, -110);
            this.lblHighSchoolName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHighSchoolName.Name = "lblHighSchoolName";
            this.lblHighSchoolName.Size = new System.Drawing.Size(0, 47);
            this.lblHighSchoolName.TabIndex = 10;
            // 
            // btnChangeTitle
            // 
            this.btnChangeTitle.Font = new System.Drawing.Font("Campain", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnChangeTitle.Location = new System.Drawing.Point(44, 48);
            this.btnChangeTitle.Name = "btnChangeTitle";
            this.btnChangeTitle.Size = new System.Drawing.Size(201, 47);
            this.btnChangeTitle.TabIndex = 18;
            this.btnChangeTitle.Text = "שינוי הכותרת";
            this.btnChangeTitle.UseVisualStyleBackColor = true;
            this.btnChangeTitle.Click += new System.EventHandler(this.btnChangeTitle_Click);
            // 
            // btnIsSecratery
            // 
            this.btnIsSecratery.Font = new System.Drawing.Font("Campain", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnIsSecratery.Location = new System.Drawing.Point(250, 570);
            this.btnIsSecratery.Name = "btnIsSecratery";
            this.btnIsSecratery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnIsSecratery.Size = new System.Drawing.Size(226, 51);
            this.btnIsSecratery.TabIndex = 20;
            this.btnIsSecratery.Text = "האם מזכירה?";
            this.btnIsSecratery.UseVisualStyleBackColor = true;
            this.btnIsSecratery.Click += new System.EventHandler(this.btnIsSecratery_Click);
            // 
            // dataGVWorkersDetails
            // 
            this.dataGVWorkersDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVWorkersDetails.Location = new System.Drawing.Point(46, 189);
            this.dataGVWorkersDetails.Name = "dataGVWorkersDetails";
            this.dataGVWorkersDetails.RowHeadersWidth = 51;
            this.dataGVWorkersDetails.RowTemplate.Height = 24;
            this.dataGVWorkersDetails.Size = new System.Drawing.Size(605, 375);
            this.dataGVWorkersDetails.TabIndex = 19;
            this.dataGVWorkersDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVWorkersDetails_CellContentClick);
            // 
            // lblWorkersDetails
            // 
            this.lblWorkersDetails.AutoSize = true;
            this.lblWorkersDetails.Font = new System.Drawing.Font("Campain", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWorkersDetails.Location = new System.Drawing.Point(271, 158);
            this.lblWorkersDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkersDetails.Name = "lblWorkersDetails";
            this.lblWorkersDetails.Size = new System.Drawing.Size(169, 28);
            this.lblWorkersDetails.TabIndex = 17;
            this.lblWorkersDetails.Text = "פרטי עובדות";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Campain", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(385, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Campain", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.Location = new System.Drawing.Point(287, 48);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(0, 47);
            this.lblTitle.TabIndex = 13;
            // 
            // grpBoxAddWorker
            // 
            this.grpBoxAddWorker.Controls.Add(this.numUDHuresWork);
            this.grpBoxAddWorker.Controls.Add(this.lblHuresWork);
            this.grpBoxAddWorker.Controls.Add(this.lblWorkType);
            this.grpBoxAddWorker.Controls.Add(this.rdBPhonly);
            this.grpBoxAddWorker.Controls.Add(this.rdBEvening);
            this.grpBoxAddWorker.Controls.Add(this.rdBNoon);
            this.grpBoxAddWorker.Controls.Add(this.rdBMorning);
            this.grpBoxAddWorker.Controls.Add(this.rdBSecratery);
            this.grpBoxAddWorker.Controls.Add(this.rdBWorker);
            this.grpBoxAddWorker.Controls.Add(this.rdBTeacher);
            this.grpBoxAddWorker.Controls.Add(this.lblWorkerType);
            this.grpBoxAddWorker.Controls.Add(this.rdBManager);
            this.grpBoxAddWorker.Controls.Add(this.btnAdd);
            this.grpBoxAddWorker.Controls.Add(this.txtAddress);
            this.grpBoxAddWorker.Controls.Add(this.lblAddress);
            this.grpBoxAddWorker.Controls.Add(this.txtEmail);
            this.grpBoxAddWorker.Controls.Add(this.lblEmail);
            this.grpBoxAddWorker.Controls.Add(this.txtFullName);
            this.grpBoxAddWorker.Controls.Add(this.lblFullName);
            this.grpBoxAddWorker.Font = new System.Drawing.Font("Campain", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grpBoxAddWorker.Location = new System.Drawing.Point(691, 158);
            this.grpBoxAddWorker.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxAddWorker.Name = "grpBoxAddWorker";
            this.grpBoxAddWorker.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxAddWorker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpBoxAddWorker.Size = new System.Drawing.Size(380, 463);
            this.grpBoxAddWorker.TabIndex = 12;
            this.grpBoxAddWorker.TabStop = false;
            this.grpBoxAddWorker.Text = "הכנסת עובדת";
            // 
            // numUDHuresWork
            // 
            this.numUDHuresWork.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numUDHuresWork.Location = new System.Drawing.Point(23, 153);
            this.numUDHuresWork.Name = "numUDHuresWork";
            this.numUDHuresWork.Size = new System.Drawing.Size(198, 27);
            this.numUDHuresWork.TabIndex = 22;
            // 
            // lblHuresWork
            // 
            this.lblHuresWork.AutoSize = true;
            this.lblHuresWork.Font = new System.Drawing.Font("Campain", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHuresWork.Location = new System.Drawing.Point(228, 157);
            this.lblHuresWork.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHuresWork.Name = "lblHuresWork";
            this.lblHuresWork.Size = new System.Drawing.Size(126, 23);
            this.lblHuresWork.TabIndex = 21;
            this.lblHuresWork.Text = "שעות עבודה";
            // 
            // lblWorkType
            // 
            this.lblWorkType.AutoSize = true;
            this.lblWorkType.Font = new System.Drawing.Font("Campain", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWorkType.Location = new System.Drawing.Point(204, 273);
            this.lblWorkType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkType.Name = "lblWorkType";
            this.lblWorkType.Size = new System.Drawing.Size(71, 23);
            this.lblWorkType.TabIndex = 20;
            this.lblWorkType.Text = "משרה";
            this.lblWorkType.Visible = false;
            // 
            // rdBPhonly
            // 
            this.rdBPhonly.AutoSize = true;
            this.rdBPhonly.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rdBPhonly.Location = new System.Drawing.Point(97, 336);
            this.rdBPhonly.Name = "rdBPhonly";
            this.rdBPhonly.Size = new System.Drawing.Size(97, 24);
            this.rdBPhonly.TabIndex = 19;
            this.rdBPhonly.TabStop = true;
            this.rdBPhonly.Text = "טלפונית";
            this.rdBPhonly.UseVisualStyleBackColor = true;
            this.rdBPhonly.Visible = false;
            // 
            // rdBEvening
            // 
            this.rdBEvening.AutoSize = true;
            this.rdBEvening.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rdBEvening.Location = new System.Drawing.Point(132, 315);
            this.rdBEvening.Name = "rdBEvening";
            this.rdBEvening.Size = new System.Drawing.Size(66, 24);
            this.rdBEvening.TabIndex = 18;
            this.rdBEvening.TabStop = true;
            this.rdBEvening.Text = "ערב";
            this.rdBEvening.UseVisualStyleBackColor = true;
            this.rdBEvening.Visible = false;
            // 
            // rdBNoon
            // 
            this.rdBNoon.AutoSize = true;
            this.rdBNoon.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rdBNoon.Location = new System.Drawing.Point(109, 294);
            this.rdBNoon.Name = "rdBNoon";
            this.rdBNoon.Size = new System.Drawing.Size(88, 24);
            this.rdBNoon.TabIndex = 17;
            this.rdBNoon.TabStop = true;
            this.rdBNoon.Text = "צהריים";
            this.rdBNoon.UseVisualStyleBackColor = true;
            this.rdBNoon.Visible = false;
            // 
            // rdBMorning
            // 
            this.rdBMorning.AutoSize = true;
            this.rdBMorning.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rdBMorning.Location = new System.Drawing.Point(127, 273);
            this.rdBMorning.Name = "rdBMorning";
            this.rdBMorning.Size = new System.Drawing.Size(70, 24);
            this.rdBMorning.TabIndex = 16;
            this.rdBMorning.TabStop = true;
            this.rdBMorning.Text = "בוקר";
            this.rdBMorning.UseVisualStyleBackColor = true;
            this.rdBMorning.Visible = false;
            // 
            // rdBSecratery
            // 
            this.rdBSecratery.AutoSize = true;
            this.rdBSecratery.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rdBSecratery.Location = new System.Drawing.Point(217, 249);
            this.rdBSecratery.Name = "rdBSecratery";
            this.rdBSecratery.Size = new System.Drawing.Size(89, 24);
            this.rdBSecratery.TabIndex = 15;
            this.rdBSecratery.TabStop = true;
            this.rdBSecratery.Text = "מזכירה";
            this.rdBSecratery.UseVisualStyleBackColor = true;
            this.rdBSecratery.CheckedChanged += new System.EventHandler(this.rdBSecratery_CheckedChanged);
            // 
            // rdBWorker
            // 
            this.rdBWorker.AutoSize = true;
            this.rdBWorker.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rdBWorker.Location = new System.Drawing.Point(223, 229);
            this.rdBWorker.Name = "rdBWorker";
            this.rdBWorker.Size = new System.Drawing.Size(85, 24);
            this.rdBWorker.TabIndex = 14;
            this.rdBWorker.TabStop = true;
            this.rdBWorker.Text = "עובדת";
            this.rdBWorker.UseVisualStyleBackColor = true;
            // 
            // rdBTeacher
            // 
            this.rdBTeacher.AutoSize = true;
            this.rdBTeacher.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rdBTeacher.Location = new System.Drawing.Point(237, 209);
            this.rdBTeacher.Name = "rdBTeacher";
            this.rdBTeacher.Size = new System.Drawing.Size(71, 24);
            this.rdBTeacher.TabIndex = 13;
            this.rdBTeacher.TabStop = true;
            this.rdBTeacher.Text = "מורה";
            this.rdBTeacher.UseVisualStyleBackColor = true;
            // 
            // lblWorkerType
            // 
            this.lblWorkerType.AutoSize = true;
            this.lblWorkerType.Font = new System.Drawing.Font("Campain", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWorkerType.Location = new System.Drawing.Point(314, 189);
            this.lblWorkerType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkerType.Name = "lblWorkerType";
            this.lblWorkerType.Size = new System.Drawing.Size(45, 23);
            this.lblWorkerType.TabIndex = 12;
            this.lblWorkerType.Text = "סוג";
            // 
            // rdBManager
            // 
            this.rdBManager.AutoSize = true;
            this.rdBManager.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rdBManager.Location = new System.Drawing.Point(220, 189);
            this.rdBManager.Name = "rdBManager";
            this.rdBManager.Size = new System.Drawing.Size(87, 24);
            this.rdBManager.TabIndex = 11;
            this.rdBManager.TabStop = true;
            this.rdBManager.Text = "מנהלת";
            this.rdBManager.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 385);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(330, 46);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "הוספה";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtAddress.Location = new System.Drawing.Point(23, 117);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(260, 27);
            this.txtAddress.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Campain", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAddress.Location = new System.Drawing.Point(288, 121);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(71, 23);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "כתובת";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtEmail.Location = new System.Drawing.Point(23, 81);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Campain", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEmail.Location = new System.Drawing.Point(289, 85);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(70, 23);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "אימייל";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFullName.Location = new System.Drawing.Point(23, 46);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(244, 27);
            this.txtFullName.TabIndex = 1;
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
            // TeamMenagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 662);
            this.Controls.Add(this.btnChangeTitle);
            this.Controls.Add(this.btnIsSecratery);
            this.Controls.Add(this.dataGVWorkersDetails);
            this.Controls.Add(this.lblWorkersDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpBoxAddWorker);
            this.Controls.Add(this.lblHighSchoolAddress);
            this.Controls.Add(this.lblHighSchoolName);
            this.Name = "TeamMenagForm";
            this.Text = "ניהול צוות";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVWorkersDetails)).EndInit();
            this.grpBoxAddWorker.ResumeLayout(false);
            this.grpBoxAddWorker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDHuresWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHighSchoolAddress;
        private System.Windows.Forms.Label lblHighSchoolName;
        private System.Windows.Forms.Button btnChangeTitle;
        private System.Windows.Forms.Button btnIsSecratery;
        private System.Windows.Forms.DataGridView dataGVWorkersDetails;
        private System.Windows.Forms.Label lblWorkersDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpBoxAddWorker;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblWorkType;
        private System.Windows.Forms.RadioButton rdBPhonly;
        private System.Windows.Forms.RadioButton rdBEvening;
        private System.Windows.Forms.RadioButton rdBNoon;
        private System.Windows.Forms.RadioButton rdBMorning;
        private System.Windows.Forms.RadioButton rdBSecratery;
        private System.Windows.Forms.RadioButton rdBWorker;
        private System.Windows.Forms.RadioButton rdBTeacher;
        private System.Windows.Forms.Label lblWorkerType;
        private System.Windows.Forms.RadioButton rdBManager;
        private System.Windows.Forms.NumericUpDown numUDHuresWork;
        private System.Windows.Forms.Label lblHuresWork;
    }
}