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
    public partial class StudentsMenagForm : Form
    {
        //יצירת אובייקט סמינר עבור שימושים שונים
        HighSchool hs = new HighSchool();
        
        public StudentsMenagForm()
        {
            InitializeComponent();

            //הגדרת לייבל שם הסמינר להיות שווה למשתנה הקונסט המכיל את שם הסמינר שהוגדר במחלקת סמינר
            lblHighSchoolName.Text = HighSchool.Name;

            //הגדרת לייבל הכתובת להיות שווה למשתנה הריד-אונלי המכיל את כתובת הסמינר שהוגדר במחלקת סמינר
            lblHighSchoolAddress.Text = hs.Address;

            //הגדרת לייבל מספר הנרשמות להיות שווה למשתנה הסטטי המכיל את מספר הנרשמות שהוגדר במחלקת תלמידה
            lblNumSignInStudents.Text = Student.NUM_SIGNIN_STUDENTS.ToString();

            //הגדרת לייבל מספר הנרשמות שהתקבלו להיות שווה למשתנה הסטטי המכיל את מספר הנרשמות שהתקבלו שהוגדר במחלקת סמינר
            lblNumGotOKStudents.Text = HighSchool.NUM_GOTOK_STUDENTS.ToString();

        }

        
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //שליחת פרטי התלמידה שנרשמה לפונקציה המוסיפה תלמידה חדשה למחסנית התלמידות, המוגדרת במחלקת סמינר
            //הפרמטרים שנשלח בסוגריים יהיו הנתונים שהוקשו בשדות תיבת ההרשמה שבטופס 
            hs.SignIn_AddStudent(txtFullName.Text, txtHighSchoolClass.Text, txtLastSchool.Text, txtNumberPhone.Text, txtAddress.Text);

            //איפוס שדות תיבת ההרשמה
            txtFullName.Text = "";
            txtHighSchoolClass.Text = "";
            txtLastSchool.Text = "";
            txtNumberPhone.Text = "";
            txtAddress.Text = "";

            //הצגת הודעה מתאימה
            MessageBox.Show("הרשמה בוצעה בהצלחה!","אישור הרשמה", MessageBoxButtons.OK);

            //עדכון לייבל מספר הנרשמות להיות שווה למשתנה הסטטי המכיל את מספר הנרשמות שהוגדר במחלקת תלמידה
            lblNumSignInStudents.Text = Student.NUM_SIGNIN_STUDENTS.ToString();
        }

        private void btnOKlist_Click(object sender, EventArgs e)
        {
            //זימון הפונקציה העוברת על מחסנית הנרשמות ומציגה הודעה מתאימה
            hs.ScanNewStudentsStack();

            //עדכון לייבל מספר הנרשמות שהתקבלו להיות שווה למשתנה הסטטי המכיל את מספר הנרשמות שהתקבלו שהוגדר במחלקת סמינר 
            lblNumGotOKStudents.Text = HighSchool.NUM_GOTOK_STUDENTS.ToString();
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            //הצגת פרטי התלמידיות שהתקבלו לסמינר
            dataGVSignInStudentsDetails.DataSource = null;
            dataGVSignInStudentsDetails.DataSource = hs.GotOKStudents;
        }

        private void btnSortByClass_Click(object sender, EventArgs e)
        {
            hs.GotOKStudents.Sort();
            dataGVSignInStudentsDetails.DataSource = null;
            dataGVSignInStudentsDetails.DataSource= hs.GotOKStudents;   
        }

        private void btnReturnOKlist_Click(object sender, EventArgs e)
        {
            //זימון הפונקציה העוברת על תור הנרשמות הממתינות לאישור חוזר ומציגה הודעה מתאימה
            hs.ScanWaitingForOKStudentsQueue();

            //עדכון לייבל מספר הנרשמות שהתקבלו להיות שווה למשתנה הסטטי המכיל את מספר הנרשמות שהתקבלו שהוגדר במחלקת סמינר 
            lblNumGotOKStudents.Text = HighSchool.NUM_GOTOK_STUDENTS.ToString();
        }

        private void StudentsMenagForm_Load(object sender, EventArgs e)
        {
            //חזרה לטופס הפתיחה בלחיצה על יציאה (איקס אדום בצד ימין למעלה)
        }
    }
}
