using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Collections
{
    //Using List with complex Objects by a Class
    //#Ex3
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Refer to Ex3

            //way1
            /*List<Product> products = new List<Product> {
                new Product {Name = "Apple", Price = 0.88},
                new Product {Name = "Banana", Price = 0.33},
                new Product {Name = "Orange", Price = 0.25}
            };

            //way2
            products.Add(new Product { Name = "Barries", Price = 2.99 });

            //List.Where() and getting a first touch with LINQ
            //It filters the elements of a list based on a condition.

            //return something calld IEnumerable
            //we made a list of it by type product -> ToList();
            List<Product> cheapProduct = products.Where(P => P.Price < 1.0).ToList();

            Console.WriteLine("Available Products for less than $1: ");
            foreach (Product product in cheapProduct) {
                Console.WriteLine($"Product name: {product.Name} for {product.Price}");
            }*/

            //================================================
            //Declear a List and initializing it
            /*List<string> colors = new List<string>();

            colors.Add("Red");
            colors.Add("blue");
            colors.Add("Yellow");
            colors.Add("green");*/

            //Declear a List and initializing it wothout a new
            /*List<string> colors = ["Red", "blue", "Yellow", "green"];

            colors.Add("Black");

            //how to read the list, best way to use foreah loop
            Console.WriteLine("Current colors in the List: ");

            foreach (string items in colors) {
                Console.WriteLine(items);
            }

            bool isDeletedItems = colors.Remove("blue");
            while (isDeletedItems) { 
                isDeletedItems = colors.Remove("blue");
            }

            foreach (string items in colors)
            {
                Console.WriteLine(items);
            }

            //Ex1
            List<int> nums = [ 1, 2, 3 ];
            foreach (int item in nums) {
                Console.Write(item + " ");
            } */

            //=============================================
            //#Sort(), FindAll()

            /*List<int> nums = new List<int> {10,5,15,3,9,25,18 };

            Console.WriteLine("Unsorted list");

            foreach (int i in nums) {
                Console.WriteLine(i);
            }

            //this will return a list of nums that are 10 and higher
            List<int> higher10 = nums.FindAll(x => x >= 10);



            Console.WriteLine("All numbers 10 or higher!");

            foreach (int i in higher10)
            {
                Console.WriteLine(i);
            }*/

            //=============================================
            //#Lambdas Expression
            //A lambda expression is a concise way to create a
            //one-time-use method, ideal for quick results without
            //needing to define a separate method for repeated use.

            //this line of code: x => x * x; same as:

            /*static int Squaring(int x) { 
                return x * x;
            }*/

            //this exampel is how to apply in
            //List<int> higher10 = nums.FindAll(x => x >= 10);

            //Predicate variable is to check if its true or false


            //Ex2 -> Delegate
            /*
             * Predicate<> underthehood is a delegate
             In C#, a delegate is like a pointer or a reference to a method.
             It allows you to pass methods as arguments to other methods,
             store them in variables, and call them later.
             This is useful when you want your code to be flexible and
             able to handle different behaviors that aren't predetermined.

             */

            /*List<int> nums = new List<int> { 10,15,52,2,7,6,9,32 };
            
            //here we call the method without using ()
            Predicate<int> isGraterThen10 = IsGraterThanTen;
            List<int> higher10 = nums.FindAll(IsGraterThanTen);

            Console.WriteLine("All numbers 10 or higher!");

            foreach (int i in higher10)
            {
                Console.WriteLine(i);
            }

            //Ex: Any() method would retunr a bool true or false
            bool hasLargNumber = nums.Any(x => x > 70);
            if (hasLargNumber)
            {
                Console.WriteLine("There are large numbers in the list");
            } else
            {
                Console.WriteLine("No large numbers in the list!");
            }*/

            //EX4 -> Legacy ArrayList -> old way but has to be known

            //declaring an ArrayList with undefind amount of object
            ArrayList myArray = new ArrayList();

            //declaring an ArrayList with defind amount of object
            ArrayList myArray2 = new ArrayList(100);

            myArray.Add(25);        //index 0
            myArray.Add("Hello");   //index 1
            myArray.Add(4.5);       //index 2 and etc..
            myArray.Add(13);
            myArray.Add(128);
            myArray.Add(25.3);
            myArray.Add(13);

            myArray.Remove(13);

            // delete a specific element index
            myArray.RemoveAt(0);

            //knowing the count of the objects
            Console.WriteLine(myArray.Count);

            double sum = 0;

            foreach(object obj in myArray)
            {
                if (obj is int)
                {
                    //adding sum: sum + sum for counting
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    //using casting
                    sum += (double)obj;
                }
                else if (obj is string) {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);

            /*
             The casting (double)obj is necessary to convert the object 
             into a double, enabling you to add it to the sum variable 
             in a type-safe manner.
             
             */



            //================================================
            //#Legacy Hashtables EX5

            //Key - Value
            //Auto - Car

            Hashtable studentTable = new Hashtable();

            Student std1 = new Student(1, "Osama", 98);
            Student std2 = new Student(2, "Omar", 76);
            Student std3 = new Student(3, "Ahemd", 43);
            Student std4 = new Student(4, "Khaled", 55);

            studentTable.Add(std1.Id, std1);
            studentTable.Add(std2.Id, std2);
            studentTable.Add(std3.Id, std3);
            studentTable.Add(std4.Id, std4);

            //retreive individual item with known ID 
            Student stordStudent = (Student)studentTable[std1.Id];


            //way1 -> retreive all values from Hashtable
            /*foreach(DictionaryEntry entry in studentTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID: {0}", temp.Id);
                Console.WriteLine("Student Name: {0}", temp.Name);
                Console.WriteLine("Student GPA: {0}", temp.GPA);
            }*/

            //way2
            /*foreach(Student value in studentTable.Values)
            {
                Console.WriteLine("Student ID: {0}", value.Id);
                Console.WriteLine("Student Name: {0}", value.Name);
                Console.WriteLine("Student GPA: {0}", value.GPA);
            }*/

            //Console.WriteLine("Student ID:{0}, Name:{1}, GPA{2}", stordStudent.Id, stordStudent.Name, stordStudent.GPA);


            //====================================================
            //#Nullables in C#
            /*
             Nullable types are particularly useful in scenarios 
             where a variable may not be applicable
             or where values are missing. 
             For example:

             1. Database Interaction:
                    - Database fields may return null if they are not set.
                    - Nullable types are perfect for handling such cases.
             
             2. Form Data:
                    - When dealing with forms where users may not provide all fields (like optional survey responses).
                    - Nullable types can indicate whether a response was given

            ------------------------------------------
            #Benefits of Using Nullable Types

            1. Safety:
                    - Prevents runtime errors that can occur when dealing with types that may not have values.
        
            2. Clarity:
                    - Makes it clear in your code that a variable might not always have a value
                    - Improves code readability and maintainability.


             */

            //this become a nullable int -> int?
            /*int? age = null;
            int myAge = 26;

            if (age.HasValue)
            {
                Console.WriteLine("Age is: " + age.Value);
                int sum4 = age.Value + myAge;


            }
            else
            {
                Console.WriteLine("Age is not specified!" + age);
            }*/





            //======================================================================================
            //#Dictinoaries Part 1 -> Declaring, initializing and adding items
            //Key - Value

            // Declaring, initializing
            //int -> key type, string -> value type
            /*Dictionary<int, string> employees = new Dictionary<int, string>();*/

            //Adding
            /*employees.Add(101, "Osama Ahemd");
            employees.Add(102, "Omar Idrss");
            employees.Add(103, "Sara Ahmed");
            employees.Add(104, "Ahmed Kahled");
            employees.Add(105, "Rawon Albaydani");


            //access item in Dictionary
            string name = employees[101];
            Console.WriteLine(name);


            //#Dictinoaries Part 2 ->
            //update
            employees[102] = "Adbullah Khaled";

            //remove
            employees.Remove(104);*/



            //note that you can't add item in the same key
            //here how you can handle dublcate check if item is exist or not.
            /*if (!employees.ContainsKey(104))
            {
                employees.Add(104, "Azoz Albaydhani");
            }*/

            //Another way to keep adding
            /*bool added = employees.TryAdd(102, "Saad");
            if (!added) {
                Console.WriteLine("Employee is already Exists!");
            }*/

            //this way is to keep adding while you counting the num of the IDs
            /*int counter = 101;
            while (employees.ContainsKey(counter)) { 
                counter++;
            }

            employees.Add(counter, "Omar");*/

            //KeyValuePair: is a collection type to iterat the dicitonry
            /*foreach (KeyValuePair<int, string> employy in employees)
            {
                Console.WriteLine($"ID: {employy.Key}, Name: {employy.Value}");
            }*/


            //======================================================================================
            //#Using a Complex object as the value of Dictionry

            /*Dictionary<int, Employee> employees = new Dictionary<int, Employee>();



            employees.Add(1, new Employee("Osama Albaydani", 26, 100000));
            employees.Add(2, new Employee("Omar Idress", 22, 90000));
            employees.Add(3, new Employee("Kahled Bamtref", 18, 80000));
            employees.Add(4, new Employee("Assma Albaydani", 33, 70000));

            Employee emp = employees[2];
            Console.WriteLine(emp.Age);

            //so by declaring the object value as Dictionary no need for KeyValuePair to iterat the items 
            foreach (var item in employees)
            {
                Console.WriteLine($"ID: {item.Key}, Name: {item.Value.Name}, Age: {item.Value.Age}, Salary: {item.Value.Salary}");
            }*/


            //======================================================================================
            //#Another way to declare and initalize dicts plus string as key

            /*var codes = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["CA"] = "California",
                ["TX"] = "Texas"
            };

            if(codes.TryGetValue("NY", out string state)){
                Console.WriteLine(state);
            }

            foreach(var item in codes)
            {
                Console.WriteLine($"The Sate code is: {item.Key} and the state name is: {item.Value}");
            }*/


            //======================================================================================
            //#Ex_1

            /*Create a simple C# program that declares a dictionary 
             *with string keys and values of type List<int>, initializes it 
             *with one key-value pair, and prints the values of the list for 
             *the given key to the console.

            Alert!
            The result of execution for the default string should be: "1 2 3"

            */

            /*Dictionary<string, List<int>> num = new Dictionary<string, List<int>>();

            num.Add("1 2 3", new List<int> { 1, 2, 3 });


            foreach (KeyValuePair<string, List<int>> item in num)
            {
                foreach (int number in item.Value)
                {
                    Console.Write($"{number} ");
                }
            }*/

            //======================================================================================
            //#Exercise_2
            /*Dictionary<string, Student2> studentInfo = new Dictionary<string, Student2>();

            studentInfo.Add("1", new Student2(1, "John", 85));
            studentInfo.Add("2", new Student2(2, "Alice", 90));
            studentInfo.Add("3", new Student2(3, "Bob", 78));

            foreach (var std in studentInfo)
            {
                Console.WriteLine($"Name: {std.Value.Name}, Id: {std.Key}, Grade: {std.Value.Grade}");
            }*/

            

            Console.ReadKey();
                
        }


        //refare to Ex2
        public static bool IsGraterThanTen(int x)
        {
            return x > 10;
        }
    }

    //#Refer to Exercise_2
    class Student2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student2(int id, string name, int grade)
        {
            this.Id = id;
            this.Name = name;
            this.Grade = grade;
        }

    }

    //Class refer to Dictionary example
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }


    //#Class refer to EX5
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float gpa)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = gpa;
        }

    }

}
