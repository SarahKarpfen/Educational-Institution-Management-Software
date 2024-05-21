namespace FinalOOPtr
{
    partial class BnotTzion_HighSchool
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
            this.btnStudentsMenag = new System.Windows.Forms.Button();
            this.btnTeamMenag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudentsMenag
            // 
            this.btnStudentsMenag.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStudentsMenag.Location = new System.Drawing.Point(101, 105);
            this.btnStudentsMenag.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentsMenag.Name = "btnStudentsMenag";
            this.btnStudentsMenag.Size = new System.Drawing.Size(116, 106);
            this.btnStudentsMenag.TabIndex = 0;
            this.btnStudentsMenag.Text = "ניהול תלמידות";
            this.btnStudentsMenag.UseVisualStyleBackColor = true;
            this.btnStudentsMenag.Click += new System.EventHandler(this.btnStudentMenag_Click);
            // 
            // btnTeamMenag
            // 
            this.btnTeamMenag.Font = new System.Drawing.Font("Campain", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnTeamMenag.Location = new System.Drawing.Point(253, 105);
            this.btnTeamMenag.Margin = new System.Windows.Forms.Padding(4);
            this.btnTeamMenag.Name = "btnTeamMenag";
            this.btnTeamMenag.Size = new System.Drawing.Size(116, 106);
            this.btnTeamMenag.TabIndex = 1;
            this.btnTeamMenag.Text = "ניהול צוות";
            this.btnTeamMenag.UseVisualStyleBackColor = true;
            this.btnTeamMenag.Click += new System.EventHandler(this.btnTeamMenag_Click);
            // 
            // BnotTzion_HighSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 323);
            this.Controls.Add(this.btnTeamMenag);
            this.Controls.Add(this.btnStudentsMenag);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BnotTzion_HighSchool";
            this.Text = "סמינר בנות ציון";
            this.Load += new System.EventHandler(this.BnotTzion_HighSchool_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudentsMenag;
        private System.Windows.Forms.Button btnTeamMenag;
    }
}

