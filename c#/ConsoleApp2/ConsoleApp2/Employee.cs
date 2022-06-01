namespace ConsoleApp2{
    public abstract class Employee{
        public int Id {get;set;}
        public string FullName {get;set;}
        public string Email {get;set;}
        public string Phone {get;set;}
        public string Address {get;set;}

        public abstract void PerformWork();
        public virtual void  Virtualdemo(){
            Console.WriteLine("This is virtualdemo");
        }
    }

    public class FullTimeEmployee: Employee{
        public decimal BiWeekyPay {get;set;}
        public string Benefits {get;set;}
        public override void PerformWork()
        {
            Console.WriteLine("Full time employees works 40 hours per week");
        }
        public override void Virtualdemo()
        {
            Console.WriteLine("This is overridden virtualdemo");
        }
    }

    public sealed class PartTimeEmployee: Employee{
        public decimal HourlyPay {get;set;}
        // override is optional for virtual methods. If not override, the method from parent class will be implemented.
        //but override is forced for abstract methods.
        public override void PerformWork()
        {
            Console.WriteLine("Part time employees works 20 hours per week");
        }
    }

    public class Manager : FullTimeEmployee{
        public void AttendMeeting(){
            Console.WriteLine("Manangers must attend meetings!!!!!!");
        }
    }
}