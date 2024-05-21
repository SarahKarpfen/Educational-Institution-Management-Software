using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOPtr
{
    //sealed-מציינת מחלקה שלא ניתנת להורשה
    //בנוסף, הפונקציה יורשת את אי-קומפרבל עבור מיון
    public sealed class Student:IComparable<Student>
    {
        //הגדרת מאפיינים+פונקציות גישה:גט וסט
        public string FullName { get; set; }
        public string HighSchoolClass { get; set; }
        public string LastSchool { get; set; }
        public string NumberPhone { get; set; }
        public string Address { get; set; }
        public static int NUM_SIGNIN_STUDENTS { get; set; } = 0;


        //קונסטרקטורים
        //קונסטרקטור מלא
        public Student(string fullName, string highSchoolClass, string lastSchool, string numberPhon, string address)
        {
            this.FullName = fullName;
            this.HighSchoolClass = highSchoolClass; 
            this.LastSchool = lastSchool;
            this.NumberPhone = numberPhon;
            this.Address = address;
            NUM_SIGNIN_STUDENTS++;
        }

        //קונסטרקטור חלקי: ללא קבלה ואתחול של המאפיין כתובת
        public Student(string fullName, string highSchoolClass, string lastSchool, string numberPhon)
        {
            this.FullName = fullName;
            this.HighSchoolClass = highSchoolClass;
            this.LastSchool = lastSchool;
            this.NumberPhone = numberPhon;
            NUM_SIGNIN_STUDENTS++;
        }


        //פעולת טו-סטרינג המחזירה שם וכיתה של תלמידה
        public override string ToString()
        {
            return this.FullName + ", כיתה " + this.HighSchoolClass;
        }

        //פעולה המממשת את אי-קומפרבל ומבצעת מיון תלמידות לפי כיתה
        public int CompareTo(Student other)
        {
            return this.HighSchoolClass.CompareTo(other.HighSchoolClass);
        }
    }
}
