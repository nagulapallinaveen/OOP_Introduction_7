using System;
namespace OOP_Introduction_7
{
    class GraduateStudent : Student, BestPractices
    {
        public string Study()
        {
            return "Completed assignments. Exam week is too close!";
        }

        public string Rest()
        {
            return "Late to bed, no time to rest";
        }
    }
}

