

using System.Data.SqlClient;

namespace StudentManagementSystemSQL
{
    internal class Program
    {
        public static StudentManagementSystem createobj()
        {
            return new StudentManagementSystemImplimentation();
        }
    }
}