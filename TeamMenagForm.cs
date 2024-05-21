using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalOOPtr
{
    public partial class TeamMenagForm : Form
    {
        //יצירת אובייקט סמינר עבור שימושים שונים
        HighSchool hs = new HighSchool();

        public TeamMenagForm()
        {
            InitializeComponent();

            //הגדרת לייבל כותרת הטופס 
            lblTitle.Text = "שלום לך עובדת יקרה!";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //הגדרת משתנה המכיל את סוג העובד
            string workerType;

            //בדיקת סוג העובד
            if (rdBManager.Checked == true)
                workerType = "Manager";

            else if (rdBTeacher.Checked == true)
                workerType = "Teacher";

            else if (rdBWorker.Checked == true)
                workerType = "Employee";

            else //מדובר במזכירה
            {
                //בדיקת סוג משרת המזכירה
                if (rdBMorning.Checked == true)
                    workerType = "Morning";

                else if (rdBNoon.Checked == true)
                    workerType = "Noon";

                else if (rdBEvening.Checked == true)
                    workerType = "Evening";

                else
                    workerType = "Phonly";
            }


            //שליחת סוג העובדת ואת פרטיה לפונקציה המוסיפה עובדת למערך העובדות, המוגדרת במחלקת סמינר
            hs.AddEmployee(workerType, txtFullName.Text, txtAddress.Text, txtEmail.Text, Convert.ToDouble(numUDHuresWork.Value));

            //איפוס שדות תיבת הכנסת העובדת
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            numUDHuresWork.Value = 0;
            rdBManager.Checked = false;
            rdBTeacher.Checked = false;
            rdBWorker.Checked = false;
            rdBSecratery.Checked = false;
            lblWorkType.Visible = false;
            rdBMorning.Checked = false;
            rdBMorning.Visible = false;
            rdBNoon.Checked = false;
            rdBNoon.Visible = false;
            rdBEvening.Checked = false;
            rdBEvening.Visible = false;
            rdBPhonly.Checked = false;
            rdBPhonly.Visible = false;

            //הצגת הודעה מתאימה
            MessageBox.Show("העובדת נוספה בהצלחה!", "אישור הוספה", MessageBoxButtons.OK);

            //הצגת פרטי העובדות השונות בדתה-גרידוויו
            dataGVWorkersDetails.DataSource = null;
            dataGVWorkersDetails.DataSource = hs.HighSchoolEmployees;
        }

        private void dataGVWorkersDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //חיפוש העובדת עליה לחצו ברשימת העובדים והצגת הודעה בה יוצג סוג העובדת-ע"י קריאה לפונקציה טו-סטרינג של העובדת

            //חיפוש העובדת שנלחצה והכנסת פרטיה למופע מסוג עובדת
            Employee selectedWorker = hs.HighSchoolEmployees.Find(x => x.FullName == dataGVWorkersDetails.CurrentCell.Value.ToString());

            //הצגת הודעה מתאימה
            MessageBox.Show(selectedWorker.ToString(), "סוג העובדת", MessageBoxButtons.OK);
        }

        private void btnIsSecratery_Click(object sender, EventArgs e)
        {
            //מעבר על רשימת העובדות, בדיקת סוגן והצגת הודעה מתאימה
            foreach (Employee employee in hs.HighSchoolEmployees)
            {
                if (employee is Secretary)
                {
                    //המרת העובדת למזכירה
                    Secretary s = employee as Secretary;
                    MessageBox.Show(s.ToString()+" בעלת משרת "+s.WorkType.ToString(), s.FullName, MessageBoxButtons.OK);
                }

                else
                    MessageBox.Show("אינני מזכירה", employee.FullName, MessageBoxButtons.OK);
            }
        }


        //פונקציה המשנה את ערך כותרת הטופס
        public void SetTitle (ref string title) 
        {
            title = "שלום לך עובדת יקרה וברוכה הבאה!";
        }

        private void btnChangeTitle_Click(object sender, EventArgs e)
        {
            string title = "";
            SetTitle(ref title);
            lblTitle.Text = title;
        }

        private void rdBSecratery_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBSecratery.Checked == true) 
            {
                lblWorkType.Visible = true;
                rdBMorning.Visible = true;
                rdBNoon.Visible = true;
                rdBEvening.Visible = true;
                rdBPhonly.Visible = true;
            }

        }
    }
}
