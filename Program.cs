using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;

namespace proj2
{
    class Program{

    }
}

/* ================
Sealed Class - sealed class cannot be inherited by any other class
sealed class Class1 {}
class class2 : Class1{} //invalid
***
The method that is defined in a parent class, if that method cannot be overridden under a child class, 
we call it a sealed method. 
By default, every method is a sealed method because overriding is not possible 
unless the method is not declared as virtual in the parent class
***
* A sealed class is completely opposite to an abstract class.
* This sealed class cannot contain abstract methods.
* It should be the bottom-most class within the inheritance hierarchy.
* A sealed class can never be used as a base class.
* The sealed class is specially used to avoid further inheritance.
* The keyword sealed can be used with classes, instance methods, and properties.
================ */
// namespace SealedDemo
// {
//     class class1
//     {
//         public virtual void show() { }
//     }
//     class class2 : class1
//     {
//         public sealed override void show() { }
//     }
//     class class3 : class2
//     {
//         //'class3.show()': cannot override inherited member 'class2.show()' because it is sealed
//         public override void show() { } //Invalid
//     }
// }










/* ================
Method Hiding - If Same methods are implemented in both Parent and Childclass, 
then the ChildClasse will hide the inherited methods and executes the methods as per the logic in the Childclass.
using the 'new' keyword in the Subclass method will override the Parentclass method.
*/

/* When a method in a subclass has the same name, same parameters or signature, 
and same return type(or sub-type) as a method in its super-class, 
then the method in the subclass is said to override the method in the super-class.
================ */
// public static void Main(string[] args){
//         ClassB cb = new ClassB();
//         cb.Show();
//     }
// }
// class ClassA{
//     public virtual void Show(){
//     Console.WriteLine("Parent");
//     }
// }
// class ClassB: ClassA{
//     public new void Show(){
//     Console.WriteLine("Child");
//     }


/* ================
Method Overriding - If Same methods are implemented in both Parent and Childclass, 
then the ChildClasse will hide the inherited methods and executes the methods as per the logic in the Childclass.

When a method in a subclass has the same name, same parameters or signature, 
and same return type(or sub-type) as a method in its super-class, 
then the method in the subclass is said to override the method in the super-class.
================ */
// public static void Main(string[] args){
//         ClassB cb = new ClassB();
//         cb.Show();
//     }
// }
// class ClassA{
//     public virtual void Show(){
//     Console.WriteLine("Parent");
//     }
// }
// class ClassB: ClassA{
//     public override void Show(){
//     base.Show(); // Using 'base' keyword to call the parent class method
//     Console.WriteLine("Child");
//     }


/* ================
Recursive - a function is calling itself
================ */
// public static void Main (string[] args){
//     Test1(5);
// }
// public static void Test1(int a){
//  if(a > 0){
//      Test1(a - 1);
//     Console.WriteLine(a);
//  }   
// }

/* ================
Method Overloading - Same Function Name, Different Parameters or Arguments
================ */

// public static void Main(string[] args){
//     Sum(10, 40);
//     Sum(10, 69, 64);
// }
// static int Sum(int a, int b){
//     int result = a + b;
//     System.Console.WriteLine("First SUM Function = "+ result);
//     return result;
// }
// static int Sum(int a, int b, int c){
//     int result = a + b + c;
//     System.Console.WriteLine("Second SUM Function = " + result);
//     return result;
// }

/* ================
Delegate_2
================ */
// public delegate string Delegate_Greeting(string name);

// public static void Main(string[] args){
//     Delegate_Greeting del_greet = delegate (string name) {
//         return "Hello " + name;
//     };
//     string greeting = del_greet("JIO");
//     System.Console.WriteLine(greeting);
// }

/* ================
Delegate_1
================ */

// public delegate string Delegate_Greeting(string name);

// public static void Main (string[] args){
//     Delegate_Greeting del_greet = new Delegate_Greeting(Test.Greeting);
//     string greeting = del_greet("JIO");
//     System.Console.WriteLine(greeting);
// }
        
// public static string Greeting(string name){
//     return "Hello " + name;
// }

/* ================
Indexers_2
================ */
// public static void Main (string[] args){
//     Company cmp = new Company();
//     Console.WriteLine("Before changing the Gender of all the male employees to Female");
//     Console.WriteLine();
//     // Get accessor of string indexer is invoked to return the total count of male employees
//     Console.WriteLine("Total Number Employees with Gender = Male:" + cmp["Male"]);
//     Console.WriteLine();
//     Console.WriteLine("Total Number Employees with Gender = Female:" + cmp["Female"]);
//     Console.WriteLine();
            
//     // Set accessor of string indexer is invoked to change the gender all "Male" employees to "Female"
//     cmp["Male"] = "Female";
//     Console.WriteLine("After changing the Gender of all male employees to Female");
//     Console.WriteLine();
//     Console.WriteLine("Total Employees with Gender = Male:" + cmp["Male"]);
//     Console.WriteLine();
//     Console.WriteLine("Total Employees with Gender = Female:" + cmp["Female"]);
            
//     Console.ReadLine();
// }
// public class Employee{
//     public int EmployeeId { get; set; }
//     public string Name { get; set; }
//     public string Gender { get; set; }
//     public double Salary { get; set; }
// }

// public class Company{
//     private List<Employee> listEmployees;

//     public Company(){
//         listEmployees = new List<Employee>();
//         listEmployees.Add(new Employee
//             { EmployeeId = 101, Name = "Pranaya", Gender = "Male", Salary = 1000 });
//         listEmployees.Add(new Employee
//             { EmployeeId = 102, Name = "Preety", Gender = "Female", Salary = 2000 });
//         listEmployees.Add(new Employee
//             { EmployeeId = 103, Name = "Anurag", Gender = "Male", Salary = 5000 });
//         listEmployees.Add(new Employee
//             { EmployeeId = 104, Name = "Priyanka", Gender = "Female", Salary = 4000 });
//         listEmployees.Add(new Employee
//             { EmployeeId = 105, Name = "Hina", Gender = "Female", Salary = 3000 });
//         listEmployees.Add(new Employee
//             { EmployeeId = 106, Name = "Sambit", Gender = "Male", Salary = 6000 });
//         listEmployees.Add(new Employee
//             { EmployeeId = 107, Name = "Tarun", Gender = "Male", Salary = 8000 });
//         listEmployees.Add(new Employee
//             { EmployeeId = 108, Name = "Santosh", Gender = "Male", Salary = 7000 });
//         listEmployees.Add(new Employee
//             { EmployeeId = 109, Name = "Trupti", Gender = "Female", Salary = 5000 });
//     }

//     public string this[int empId]{
//         get{
//             return listEmployees.FirstOrDefault(x => x.EmployeeId == empId).Name;
//         }
//         set{
//             listEmployees.FirstOrDefault(x => x.EmployeeId == empId).Name = value;
//         }   
//     }

//     public string this[string gender]
//     {
//         get{
//             return listEmployees.Count(x => x.Gender.ToLower() == gender.ToLower()).ToString();
//         }
//         set{
//             foreach (Employee employee in listEmployees){
//                 if (employee.Gender == gender){
//                     employee.Gender = value;
//                 }
//             }
//         }
//     }
// } 

/* ================
Indexers_1
================ */

// public static void Main(string[] args){
//     Employee emp = new Employee(101, "Pranaya", "SSE", 10000, "Mumbai", "IT", "Male");
//     //Accessing Employee Properties using Indexers i.e. using Index positions
//     Console.WriteLine("EID = " + emp[0]);
//     Console.WriteLine("Name = " + emp[1]);
//     Console.WriteLine("Job = " + emp[2]);
//     Console.WriteLine("Salary = " + emp[3]);
//     Console.WriteLine("Location = " + emp[4]);
//     Console.WriteLine("Department = " + emp[5]);
//     Console.WriteLine("Gender = " + emp[6]);
            
//     Console.ReadLine();
// }
    
// public class Employee{
//     public int ID {get; set;}
//     public string Name {get; set;}
//     public string Gender {get; set;}
//     public string Job {get; set;}
//     public string Location {get; set;}
//     public string Department {get; set;}
//     public int Salary {get; set;}

//     public Employee(int id, string name, string job, int salary, string location, string dept, string gender){
//                         this.ID = id;
//                         this.Name = name;
//                         this.Gender = gender;
//                         this.Job = job;
//                         this.Location = location;
//                         this.Department = dept;
//                         this.Salary = salary;
//                     }

//     public object this [int index]
//     {
//         //The get accessor is used for returning a value
//         get
//         {
//             if (index == 0) return ID;
//             else if (index == 1) return Name;
//             else if (index == 2) return Job;
//             else if (index == 3) return Salary;
//             else if (index == 4) return Location;
//             else if (index == 5) return Department;
//             else if (index == 6) return Gender;
//             else return null;
//         }
            
//         // The set accessor is used to assigning a value
//         set
//         {
//             if (index == 0)  ID = Convert.ToInt32(value);
//             else if (index == 1) Name = value.ToString();
//             else if (index == 2) Job = value.ToString();
//             else if (index == 3) Salary = Convert.ToInt32(value);
//             else if (index == 4) Location = value.ToString();
//             else if (index == 5) Department = value.ToString();
//             else if (index == 6) Gender = value.ToString();
//         }
//     }
// }

/* ================
Optional Parameters
================ */
// public static void Main(string[] args){
//     AddNumbers(10, 20);
//     AddNumbers(10, 20, new int[] {30, 688686});
// }

// public static void AddNumbers(int FN, int SN, [Optional] int[] RestOfNumbers)
// {
//     int result = FN + SN;
//     if(RestOfNumbers != null){
//         foreach (int RoN in RestOfNumbers)
//         {
//             result += RoN;
//         }
//     }
//     System.Console.WriteLine("Total is: " + result);
// }

/* ================
FileSystem
================ */
// FileStream fs = new FileStream("employee.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
// // fs.Close();
// System.Console.WriteLine("New File has been created...");

// byte[] data = Encoding.Default.GetBytes("Hello World");
// fs.Write(data, 0, data.Length);
// fs.Close();
// System.Console.WriteLine("Data has been written to the file...");

         
/* ================
Arrays
================ */


// public static void Main(string[] args)
// {
//     int[] arr = { 17, 23, 4, 59, 27, 36, 96, 9, 1, 3, 88 };
//     System.Console.WriteLine("----------------------------");
//     System.Console.WriteLine("Original Array is: ");

//     for (int i=0; i<arr.Length; i++){
//         Console.Write(arr[i] + " ");
//     }
//     System.Console.WriteLine("\n----------------------------");


//     Array.Sort(arr);
//     System.Console.WriteLine("Sorted Array is: ");
//     foreach (int i in arr)
//     {
//         Console.Write(i + " ");
//     }
//     System.Console.WriteLine("\n----------------------------");

//     Array.Reverse(arr);
//     System.Console.WriteLine("Reversed Array is: ");
//     foreach (int i in arr)
//     {
//         Console.Write(i + " ");
//     }
//     System.Console.WriteLine("\n----------------------------");

//     System.Console.WriteLine("Index of the number 59 is: " + Array.IndexOf(arr, 59));
//     System.Console.WriteLine("\n----------------------------");

//     System.Console.WriteLine("Array Length is: " + arr.GetLength(0));
//     System.Console.WriteLine("\n----------------------------");
// }