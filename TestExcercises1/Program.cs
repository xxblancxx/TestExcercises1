using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExcercises1
{
    public class Program
    {
        public enum VisitType { Hospital,Doctor}
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int GetPercentageReimbursed(bool deductibleMet, VisitType visit)
        {
            if (deductibleMet)
            {
                if (visit == VisitType.Doctor)
                {
                    return 50;
                }
                else if (visit == VisitType.Hospital) // kind of overkill with enum for 2 options, as bool would suffice. But this proves understanding of test cases.
                {
                    return 80;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        public static int GetNumDaysInMonth(int month, int year)
        {
            if (month < 1 || month > 12 || year < 0 || year > Int32.MaxValue) // Int32.MaxValue is the same as 2^31-1
            {
                throw new ArgumentOutOfRangeException("Invalid month or year");
            }
            else if (year > 9999) // explicitly put this up so the difference is visible.
            {
                throw new ArgumentOutOfRangeException("Max value of static method to calculate days is year 9999");
            }
            int daysInMonth = DateTime.DaysInMonth(year, month);
            return daysInMonth;
        }
    }
}
