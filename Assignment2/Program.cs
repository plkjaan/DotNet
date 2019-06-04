﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

        //Employee Class
            Employee e1 = new Employee("Priyanka", 123456, 1);
            e1.Display();
            e1.GetNetSalary();
            Console.WriteLine("");
        //Manager class
            Manager m1 = new Manager("Roshan", 10, 120321, "Manager");
            m1.Display();

            Console.WriteLine("");
        //Programmer Class
            Programmer p1 = new Programmer("palak", 3, 6000);
            p1.Display();
            Console.WriteLine("");
        //GEnaral Manager Class
            GeneralManager g1 = new GeneralManager("Piyu", 4, 53210, "Manager", " Senior ");
            g1.Display();

            Console.ReadLine();
        }
    }
    //Interface IDBFunction
    public interface IDbFunctions
    {
         void Display();
        decimal GetNetSalary();
    }
    //Employee Class
    public class Employee :IDbFunctions
    {
        #region Properties
        //variables
            public static int X;
            public int empId;

        //Properties
            public int EmpId
            {
                get
                {

                    return empId; //returns variable
                }
            }

        //Variable
            public String empName;

        //Property
            public String EmpName
            {
                set
                {
                    if (value != "")
                    {
                        empName = value;
                        //Console.WriteLine("Employee Name " + empName);
                        // Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Enter Employee Name");
                        Console.WriteLine("");
                    }
                }
                get
                {
                    return empName;
                }
            }

        //Variable
            public decimal salary;

        //Property
            public  decimal Salary
            {
                set
                {
                    if (value > 1000)
                    {
                        salary = value;
                    }
                    else 
                    {
                    Console.WriteLine("Invalid Salary");   
                    }
                }
                get
                {
                    return salary;      //return Variable
                }
            }

        //Variables
            public short departmentNo;

        //Property
            public short DepatementNo
            {
                set
                {
                    if (value > 0)
                    {
                        departmentNo = value;
                    }
                    else
                    {
                        Console.WriteLine("Deapatemnet no is InValid!!!");
                    }
                }
                get
                {
                    return departmentNo;  //return Variable
                }
            }

            #endregion

        #region GetNetSalary Method

            decimal netSal;


        public decimal GetNetSalary()
        {
            netSal = salary - (salary * 2) / 100;

            Console.WriteLine("Employess net salary is " + netSal);
            Console.WriteLine("");
            return netSal;
        }


        #endregion

        #region Interface Method

        public void Display()
        {
            Console.WriteLine("Employee Id : " + EmpId);
            Console.WriteLine("Employee Name : " + EmpName);
            Console.WriteLine("Employee Salary : " + Salary);
            Console.WriteLine("Employee Department No : " + DepatementNo);
        }

        #endregion

        #region Constructor


        public Employee()
        {

        }

        public Employee(string EmpName = "", decimal Salary = 0, short DepatementNo = 0)
            {
                empId = ++X;
                this.EmpName = EmpName;
                this.Salary = Salary;
                this.DepatementNo = DepatementNo;
           
            }
        
        #endregion
    }

    //Manager Class
    public class Manager : Employee , IDbFunctions
    {
        public string desingnation;
        #region Property
        public string Desingnation
        {
            set
            {
                if(value != "")
                {
                    desingnation = value;
                }
                else
                {
                    Console.WriteLine("Designation is InValid...");
                }
            }
            get
            {
                return desingnation;
            }
        }
        #endregion

        #region GetNetSalary Method

        decimal netSal;


        public decimal GetNetSalary()
        {
            netSal = salary - (salary * 2) / 100;

            Console.WriteLine("Employess net salary is " + netSal);
            Console.WriteLine("");
            return netSal;
        }


        #endregion

        #region IDBFunction Method

        public new void Display()
        {
            Console.WriteLine("Employee Id : " + EmpId);
            Console.WriteLine("Employee Name : " + EmpName);
            Console.WriteLine("Employee Salary : " + Salary);
            Console.WriteLine("Employee Department No : " + DepatementNo);
            Console.WriteLine("Designation is : " + Desingnation);
        }

        #endregion

        #region Constructor

        public Manager()
        {

        }

        public Manager( string EmpName="",short DepatementNo = 0, decimal Salary=10000,string Desingnation="Manager"):base(EmpName ,Salary ,DepatementNo )

        {
            
            this.Desingnation = Desingnation;
            
           
        }
        
        #endregion
    }

    //Programmer CLass
    public class Programmer : Employee , IDbFunctions
    {
        public string technologiesKnown;

        #region Property

        public string TechnologiesKnown
        {
            set
            {
                if(value != "")
                {
                    technologiesKnown = value;
                }
                else
                {
                    Console.WriteLine("Enter Valid Technologies");
                }
            }
            get
            {
                return technologiesKnown;
            }
        }

        #endregion

        #region GetNetSalary Method

        decimal netSal;


        public decimal GetNetSalary()
        {
            netSal = salary - (salary * 2) / 100;

            Console.WriteLine("Employess net salary is " + netSal);
            Console.WriteLine("");
            return netSal;
        }


        #endregion

        #region IDBFunction Methods

        public void Display()
        {
            Console.WriteLine("Employee Id : " + EmpId);
            Console.WriteLine("Employee Name : " + EmpName);
            Console.WriteLine("Employee Salary : " + Salary);
            Console.WriteLine("Employee Department No : " + DepatementNo);
            Console.WriteLine("Department No : " + DepatementNo);

        }

        #endregion

        #region Constructor


        public Programmer(string EmpName = "", short DepatementNo = 2, decimal Salary = 5000, string technologiesKnown="") :base( EmpName, Salary, DepatementNo)
        {
            this.TechnologiesKnown = TechnologiesKnown;
          
        }
        
        #endregion
    }

    //GeneralManager 
    public class GeneralManager : Manager ,IDbFunctions
    {
        public string additionalInfo;

        #region Property
        public  string AdditionalInfo
        {
            set
            {
                if(value != "")
                {
                    additionalInfo = value;
                }
                else
                {
                    Console.WriteLine("Invalid Statement..");
                }
            }
            get
            {
                return additionalInfo;
            }
        }
        #endregion

        #region GetNetSalary Method

        decimal netSal;


        public new decimal GetNetSalary()
        {
            netSal = salary - (salary * 2) / 100;

            Console.WriteLine("Employess net salary is " + netSal);
            Console.WriteLine("");
            return netSal;
        }


        #endregion

        #region IDBFunction Method

        public new void Display()
        {
            Console.WriteLine("Employee Id : " + EmpId);
            Console.WriteLine("Employee Name : " + EmpName);
            Console.WriteLine("Employee Salary : " + Salary);
            Console.WriteLine("Employee Department No : " + DepatementNo);
            Console.WriteLine("Designation is : " + Desingnation);
            Console.WriteLine("AdditionalInfo is :" + AdditionalInfo);
        }

        #endregion

        #region Constructor

        public GeneralManager(string EmpName = "", short DepatementNo = 0, decimal Salary = 10000, string Desingnation = "Manager",string AdditionalInfo=""):base(EmpName, DepatementNo , Salary, Desingnation)
        {
            
            this.AdditionalInfo = AdditionalInfo;
            
            

        }
        
        #endregion
    }
}
    