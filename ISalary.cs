using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOPtr
{
    //ממשק זה מכיל חתימות של פונקציות הנדרסות וממומשות במחלקות אחרות בצורות שונות
    public interface ISalary
    {
        //הפונקציות
        double GetSalary();

        // in: משתנה שאינו ניתן לשינוי במהלך הפונקציה אליו הוא נשלח
        double GetTotalSalary(in int bonos);
    }
}
