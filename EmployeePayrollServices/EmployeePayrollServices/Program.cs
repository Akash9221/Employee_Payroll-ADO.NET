using System;

namespace EmployeePayrollProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeePayrollServices employeePayrollServices = new EmployeePayrollServices();
            bool flag = true;
            while (flag)
            {
                Console.Write("Enter the option : 1.AddEmployeePayroll \n 2.RetrieveEntriesFromEmployeePayDB\n 3.UpdateData \n 4.Delete Data");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        EmployeePayroll employee = new EmployeePayroll()
                        {
                            ID = 1,
                            Name = "Amit",
                            PhoneNumber = "123456789",
                            Address = "Rampuri Colony",
                            Gender = "M",
                            Start = DateTime.Now
                        };
                        employeePayrollServices.AddEmployeeInDB(employee);
                        break;
                    case 2:
                        employeePayrollServices.RetrieveEntriesFromEmployeePayDB();
                        break;
                    case 3:
                        EmployeePayroll employeePayroll = new EmployeePayroll
                        {
                            Name = "Akash",
                            Address = "Mumbai",
                            PhoneNumber = "7249624543",
                        };
                        employeePayrollServices.UpdateDataInDatabase(employeePayroll);
                        break;
                    case 4:
                        employeePayrollServices.DeleteDataFromDatabase("Akash");
                        break;

                    default:
                        flag = false;
                        break;
                }
            }

        }
    }
}

