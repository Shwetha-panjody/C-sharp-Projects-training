using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystemProject
{
    internal class Student
    {
        public string Id { get; set; }
        public int Clas { get; set; }
        public string Name { get; set; }
        public double Mark1 { get; set; }
        public double Mark2 { get; set; }
        public double Mark3 { get; set; }

        private const int autoIncrementRegno=100;

        public static int[] classlistarr = new int[7];  //1-7 class in primary school
        public Student(String name, int clas, double mark1, double mark2, double mark3)
        {
            int reg;
            if (classlistarr[clas-1] == 0)
            {
                classlistarr[clas - 1] = autoIncrementRegno;
                reg = (++classlistarr[clas - 1]);
                
            }
            else
            {
                reg = (++classlistarr[clas - 1]);
            }
            Id = "EGDK" + clas;                     // EGDK3      EGDK4      EGDK3 
            Id = Id + reg;                          // EGDK3101   EGDK4101   EGDK3102  
            Name = name;
            Clas = clas;                            // 3        4          3
            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
        }

        public override string ToString()
        {
            return String.Format("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}", Id,Name,Clas,Mark1,Mark2,Mark3);
        }

    }
}
