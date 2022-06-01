namespace ConsoleApp2
{
    public class Customer
    {
        //Two ways to write propery part:
        //1. full version property: private data fields + setter and getter
        private string name;
        public string Name
        {
            get { return name; }
            set {name = value; }
        }
        //2. auto-generate property
        //public string Name { get; set; }

        public int Age { get; set; }


        //encapsulation: hide data implementation
        // advantage: hide data; flexiablity
        private int id;
        public int Id  { get { return id;} private set { id = value;} }
        //public int Id { get; set; }

        //constructor :
        //1. a special method which shares the same name of the class and doesn't have any return type, not even void.
        // 2. constuctor is used to create an object of the class and initialize class members.
        // 3. if there is no constructor in the class, C# compiler will provide a default constructor.
        //// public Customer (){}
        // 4. if we create any constructors, the default constructor will be replaced.
        // 5. constructor can be overloaded.
        public Customer (string input_Name, int input_Age, int input_Id){
            name = input_Name;
            Age= input_Age;
            id = input_Id;
        }
        
    }
}