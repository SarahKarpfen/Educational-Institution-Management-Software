using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOPtr
{
    //המחלקה יורשת ממחלקת עובדת
    public class Manager: Employee
    {
        //הגדרת מאפיינים+פונקציות גישה:גט וסט
        public static double MANAGER_HOUR_SALARY { get; set; } = 185;

        //קונסטרקטור מלא
        public Manager(string fullName, string address, string email, double workHoursInMunth): base(fullName, address, email, workHoursInMunth)
        {
        }


        //פעולת טו-סטרינג המחזירה מחרוזת "אני מנהלת"
        public override string ToString()
        {
            return "אני מנהלת";
        }



        //דריסה ומימוש הפונקציות המוגדרות בממשק אי-סלרי
        //1. פונקציה הדורסת את זו שהוגדרה במחלקת האבא-מחלקת עובד ומחזירה את שכר העובד עפ"י החישוב: שעות עבודה בחודש * שכר שעתי
        public override double GetSalary()
        {
            return base.WorkHoursInMunth * MANAGER_HOUR_SALARY;
        }

        //2. פונקציה הדורסת את זו שהוגדרה במחלקת האבא-מחלקת עובד, המקבלת ערך ברירת מחדל לשכר בונוס שאינו ניתן לשינוי: 50 ומחזירה את שכר העובד עפ"י החישוב: שעות עבודה בחודש * שכר שעתי + בונוס
        // in: משתנה שאינו ניתן לשינוי במהלך הפונקציה אליו הוא נשלח
        public override double GetTotalSalary(in int bonos = 50)
        {
            return base.WorkHoursInMunth * MANAGER_HOUR_SALARY + bonos;
        }
    }
}
