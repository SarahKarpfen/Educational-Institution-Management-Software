using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOPtr
{
    //הגדרת אי-נם המכיל את משרת המזכירה
    public enum workType
    {
       Morning,
       Noon,
       Evening,
       Phonly
    }


    //המחלקה יורשת ממחלקת עובדת
    public class Secretary: Employee
    {
        //הגדרת מאפיינים+פונקציות גישה:גט וסט
        public workType WorkType { get; set; } //הפעולה סט ממומשת בהמשך
        public static double SECRETARY_HOUR_SALARY { get; set; } = 48;


        //קונסטרקטור מלא
        public Secretary(string fullName, string address, string email, double workHoursInMunth, workType workType): base(fullName, address, email, workHoursInMunth)
        {
            this.WorkType = workType;   
        }


        //פעולת סט לסוג המשרה, המקבלת מזכירה ומשנה את סוג משרתה למשרת בוקר
        public void setWorkType(Secretary s)
        { 
            s.WorkType = workType.Morning;
        }


        //פעולת טו-סטרינג המחזירה מחרוזת "אני מזכירה"
        public override string ToString()
        {
            return "אני מזכירה";
        }



        //דריסה ומימוש הפונקציות המוגדרות בממשק אי-סלרי
        //1. פונקציה הדורסת את זו שהוגדרה במחלקת האבא-מחלקת עובד ומחזירה את שכר העובד עפ"י החישוב: שעות עבודה בחודש * שכר שעתי
        public override double GetSalary()
        {
            return base.WorkHoursInMunth * SECRETARY_HOUR_SALARY;
        }

        //2. פונקציה הדורסת את זו שהוגדרה במחלקת האבא-מחלקת עובד, המקבלת ערך ברירת מחדל לשכר בונוס שאינו ניתן לשינוי: 50 ומחזירה את שכר העובד עפ"י החישוב: שעות עבודה בחודש * שכר שעתי + בונוס
        // in: משתנה שאינו ניתן לשינוי במהלך הפונקציה אליו הוא נשלח
        public override double GetTotalSalary(in int bonos = 50)
        {
            return base.WorkHoursInMunth * SECRETARY_HOUR_SALARY + bonos;
        }
    }
}
