namespace ConsoleApp2{
    public class Employee{
        public int Id {get;set;}
        public string FullName {get;set;}
        public string Email {get;set;}
        public string Phone {get;set;}
        public string Address {get;set;}

        public virtual void PerformWork(){
            Console.WriteLine("All employees should arrive before 10am in work days");
        }
    }

    public class FullTimeEmployee: Employee{
        public decimal BiWeekyPay {get;set;}
        public string Benefits {get;set;}
        public override void PerformWork()
        {
            Console.WriteLine("Full time employees works 40 hours per week");
        }
    }

    public class PartTimeEmployee: Employee{
        public decimal HourlyPay {get;set;}
        // override is optional. If not override, the method from parent class will be implemented.
        // public override void PerformWork()
        // {
        //     Console.WriteLine("Part time employees works 20 hours per week");
        // }
        
    }
}