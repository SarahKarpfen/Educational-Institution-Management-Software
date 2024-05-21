using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOPtr
{
    //המחלקה משתמשת בממשק אי-סלרי, כלומר-מממשת את הפונקציות המוגדרות בממשק
    public class Employee: ISalary
    {
        //הגדרת מאפיינים+פונקציות גישה:גט וסט
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public double WorkHoursInMunth { get; set; }
        public static double EMPLOYEE_HOUR_SALARY { get; set; } = 45;


        //קונסטרקטור מלא
        public Employee(string fullName, string address, string email, double workHoursInMunth)
        {
            this.FullName = fullName;
            this.Address = address;
            this.Email = email;
            this.WorkHoursInMunth = workHoursInMunth;
        }


        //פעולת טו-סטרינג המחזירה מחרוזת "אני עובדת"
        public override string ToString()
        {
            return "אני עובדת";
        }


        //דריסה ומימוש הפונקציות המוגדרות בממשק אי-סלרי
        //1. פונקציה הניתנת לדריסה ומחזירה את שכר העובד עפ"י החישוב: שעות עבודה בחודש * שכר שעתי
        public virtual double GetSalary()
        {
            return WorkHoursInMunth * EMPLOYEE_HOUR_SALARY;
        }

        //2. פונקציה הניתנת לדריסה, המקבלת ערך ברירת מחדל לשכר בונוס שאינו ניתן לשינוי: 50 ומחזירה את שכר העובד עפ"י החישוב: שעות עבודה בחודש * שכר שעתי + בונוס
        // in: משתנה שאינו ניתן לשינוי במהלך הפונקציה אליו הוא נשלח
        public virtual double GetTotalSalary(in int bonos=50)
        {
            return WorkHoursInMunth * EMPLOYEE_HOUR_SALARY + bonos;
        }
    }
}
