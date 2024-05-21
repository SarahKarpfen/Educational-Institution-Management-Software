using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalOOPtr
{
    public class HighSchool
    {
        //הגדרת מאפיינים+פונקציות גישה:גט וסט
        public const string Name="סמינר בנות ציון";
        public readonly string Address = "רחוב הפלמחים 12";
        public Stack<Student>NewStudents { get; set; } = new Stack<Student>();
        public Queue<Student>WaitingForOKStudents { get; set; } = new Queue<Student>();
        public List<Student>GotOKStudents { get; set; } = new List<Student>();  
        public static int NUM_GOTOK_STUDENTS= 0;
        public List<Employee> HighSchoolEmployees { get; set; } = new List<Employee>();



        //פונקציות:
        //1. פונקצית הרשמת-הוספת תלמידה
        public void SignIn_AddStudent(string fullName, string highSchoolClass, string lastSchool, string numberPhon, string address) 
        {
            //יצירת תלמידה
            Student s;

            //כיון שהגדרנו שני קונסטרקטורים, נבצע בדיקה לאיזה קונסטרקטור עלינו לשלוח את התלמידה החדשה שנרשמה
            if (address == "") 
                //יצירת תלמידה על-יידי שימוש בקונסטרקטור החלקי-שאינו מקבל כתובת
                s = new Student(fullName, highSchoolClass, lastSchool, numberPhon);

            else
                //יצירת תלמידה על-יידי שימוש בקונסטרקטור המלא-שמקבל ומאתחל כתובת
                s = new Student(fullName, highSchoolClass, lastSchool, numberPhon, address);

            
            //הוספת התלמידה החדשה למחסנית התלמידות החדשות
            NewStudents.Push(s);
        }


        //2.פונקציית מעבר על מחסנית הנרשמות. עבור כל נרשמת תוצג הודעת קבלה ושני כפתורים: שלילי וחיובי
        public void ScanNewStudentsStack()
        {
            while(NewStudents.Count> 0)
            {
                DialogResult chooseButton=MessageBox.Show(NewStudents.Peek().ToString(), ":אישור קבלה לסמינר", MessageBoxButtons.YesNo);

                //במידה והתלמידה הנוכחית קבלה אישור קבלה-הכנסתה לרשימת הבנות שהתקבלו והגדלת מונה הבנות שהתקבלו
                if (chooseButton == DialogResult.Yes)
                {
                    GotOKStudents.Add(NewStudents.Pop());
                    NUM_GOTOK_STUDENTS++;
                }

                //במידה והתלמידה הנוכחית לא קבלה אישור קבלה-הכנסתה לתור הבנות הממתינות לאישור
                else
                    WaitingForOKStudents.Enqueue(NewStudents.Pop());          
            }
        }


        //3. פונקציית מעבר על תור הממתינות לאישור חוזר. עבור כל נרשמת תוצג הודעה מתאימה ושני כפתורים: שלילי וחיובי
        public void ScanWaitingForOKStudentsQueue()
        {
            while (WaitingForOKStudents.Count > 0)
            {
                //שמירת התלמידה שהוצאה מראש התור ע"מ שלא תימחק-כיון שאין אופציה של הצצה לראש התור-כמו במחסנית, אלא רק הוצאה ומחיקה
                Student s = WaitingForOKStudents.Dequeue();

                DialogResult chooseButton = MessageBox.Show(s.ToString(), ":אישור קבלה לסמינר", MessageBoxButtons.YesNo);

                //במידה והתלמידה הנוכחית קבלה אישור קבלה-הכנסתה לרשימת הבנות שהתקבלו והגדלת מונה הבנות שהתקבלו
                if (chooseButton == DialogResult.Yes)
                {
                    GotOKStudents.Add(s);
                    NUM_GOTOK_STUDENTS++;
                }

                //במידה והתלמידה הנוכחית לא קבלה אישור קבלה-הכנסתה חזרה לתור הבנות הממתינות לאישור
                else
                    WaitingForOKStudents.Enqueue(s);

            }

        }


        //4. פונקציה המקבלת סוג של עובדת ואת פרטיה ומוסיפה אותה לרשימת העובדות
        public void AddEmployee(string workerType, string fullName, string address, string email, double workHoursInMunth) 
        {
            //יצירת מופע מסוג עובדת-האבא ממנו יורשים סוגי העובדות: מנהלת, מורה ומזכירה
            Employee e;

            //בדיקת סוג העובדת ויצירת מופע מסוגו
            switch (workerType)
            {
                case "Manager":
                    e = new Manager(fullName, address, email, workHoursInMunth);
                    break;

                case "Teacher":
                    e = new Teacher(fullName, address, email, workHoursInMunth);
                    break;

                case "Employee":
                    e = new Employee(fullName, address, email, workHoursInMunth);
                    break ;

                default: //מדובר במזכירה
                    switch (workerType) //בדיקת סוג משרת המזכירה
                    {
                        case "Morning":
                            e = new Secretary(fullName, address, email, workHoursInMunth, workType.Morning);
                            break;

                        case "Noon":
                            e = new Secretary(fullName, address, email, workHoursInMunth, workType.Noon);
                            break;

                        case "Evening":
                            e = new Secretary(fullName, address, email, workHoursInMunth, workType.Evening);
                            break;

                        default:
                            e = new Secretary(fullName, address, email, workHoursInMunth, workType.Phonly);
                            break;
                    }

                    break;
            }

            //הוספת העובדת לרשימת העובדות
            HighSchoolEmployees.Add(e);
        }


    }
}
