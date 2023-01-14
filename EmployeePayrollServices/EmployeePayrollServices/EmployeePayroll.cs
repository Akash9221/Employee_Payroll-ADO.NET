using System;

namespace EmployeePayrollProblems
{
    public class EmployeePayroll
    {
        public int ID { get; set; }

        public string Name { get; internal set; }
        public DateTime Start { get; internal set; }
        public long Salary { get; internal set; }
        public string Gender { get; internal set; }
        public string Address { get; internal set; }
        public string PhoneNumber { get; internal set; }
      
    }
}