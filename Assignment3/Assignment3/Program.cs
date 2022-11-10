using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Assignment3.EmpSystem;

namespace Assignment3
{
    public class cshaass3
    {
        public int EmpNo;
        public string EmpName;
        public static void Main()
        {
            cshaass3 emp = new cshaass3();
            Console.WriteLine("EMPLOYEE SALARY DETAILS");
            Console.WriteLine("Please Enter The Employee Number : ");
            emp.EmpNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Employee Name : ");
            emp.EmpName = Console.ReadLine();

            Manager M1 = new Manager();
            M1.Salary = 50000;
            M1.TA = 1000;
            M1.HRA = 1000;
            M1.DA = 500;
            M1.Calculate();
            M1.SalaryCalculate();
            Console.ReadLine();

            MarketingExecutive obj = new MarketingExecutive();
            obj.Salary = 40000;
            obj.TA = 1000;
            obj.HRA = 500;
            obj.DA = 1000;
            obj.Cal();
            obj.SalaryCalculate();
            Console.ReadLine();



        }



    }

    interface Iprintable
    {
        void SalaryCalculate()
    }
    public class EmpSystem : Iprintable
    {
        public double TA;
        public int EmpNo;
        public double HRA;
        public double DA;
        public double Salary;
        double NetSalary;
        double GrossSalary;

        public virtual void SalaryCalculate()
        {
            NetSalary = GrossSalary - (TA + HRA + DA);
            Console.WriteLine(NetSalary);
        }



        public class Manager : EmpSystem
        {
            private double PetrolAllowance;
            private double FoodAllowance;
            private double OtherAllowances;

            public void Calculate()
            {
                PetrolAllowance = 8 * Salary / 100;
                FoodAllowance = 13 * Salary / 100;
                OtherAllowances = 3 * Salary / 100;

                GrossSalary = PetrolAllowance + FoodAllowance + OtherAllowances;
                Console.WriteLine("GrossSalary of Managr = {0}", GrossSalary);

            }
            public override void SalaryCalculate()
            {
                NetSalary = GrossSalary - (TA + HRA + DA);
                Console.WriteLine("NetSalary of Manager = {0}", NetSalary);
            }
        }


        public class MarketingExecutive : EmpSystem

        {
            private double KilometerTravel = 5000;
            private double TourAllowances = 5 * 5000;
            private double TelephoneAllowances = 1000;

            public void Cal()
            {
                GrossSalary = KilometerTravel + TourAllowances + TelephoneAllowances;
                Console.WriteLine("marketexecutive GrossSalary = {0}", GrossSalary);
            }
            public override void SalaryCalculate()
            {
                NetSalary = GrossSalary - (TA + HRA + DA);
                Console.WriteLine("marketexecutiveSalary = {0}", NetSalary);

            }
        }

    }
  
}