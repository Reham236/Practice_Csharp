// See https://aka.ms/new-console-template for more information
using System;
//class Customer
//{
//    string FName;
//    string LName;
//    public Customer(string FirstName, string LastName)
//    {
//        FName = FirstName;
//        LName = LastName;
//    }
//    public Customer() : this("No FirstName", "No LastName")
//    {
//    }

//    public void PrintName() { 
//       Console.WriteLine("Full NAme is {0} {1}",FName, LName); 
//     }
//}
class Employee
{
    public string FName;
    public string LName;
    public string Email;
    public void PrintName()
    {
        Console.WriteLine(FName + " " + LName);
    }
}
class FullTime : Employee
{
    //public float YearlySalary;
    public new void PrintName()
    {
        Console.WriteLine(FName + " " + LName+" WEB");
    }
}
class PartTime : Employee
{
    // public float HourlySalary;
    public void PrintName()
    {
        Console.WriteLine(FName + " " + LName+" -contractor ");
    }
}
//class ParentClass
//{
//    public ParentClass() {
//        Console.WriteLine("Parent Class Constructor !");
//    }
//    public ParentClass(string name) {
//        Console.WriteLine("Hello {0} !", name);
//    }
//}
//class ChildClass : ParentClass
//{
//    public ChildClass() : base("Reham") 
//    {
//        Console.WriteLine("Child Class Constructor ");
//    }
//}
class Program
{
    static void Main(string[] args)
   {
        //INHERITANCE
        FullTime fullTime = new FullTime();
        fullTime.FName = "Reham";
        fullTime.LName = "Salah";
        fullTime.PrintName();

        PartTime partTime = new PartTime();
        partTime.FName = "Part";
        partTime.LName = "Time";
        partTime.PrintName();

       // ChildClass c = new ChildClass();




        //CLASSES
        //Customer c1=new Customer("Reham","SAlAh");
        //c1.PrintName();



        /* Console.WriteLine("please Enter Your First Name.");
         string Fname =Console.ReadLine();

         Console.WriteLine("please Enter Your Last Name.");
         string Lname = Console.ReadLine();


         Console.WriteLine("Hello, {0} {1}",Fname,Lname);*/














        //Console.WriteLine("Min ={0}", int.MinValue);
        //Console.WriteLine("Max ={0}", int.MaxValue);

        //string name = "\"Reham\"";
        //string name = @"\\hello\\!";
        //Console.WriteLine(name)

        //int num = 110;
        //bool is10;
        //if(num==10)
        //{
        //    is10=true;
        //}
        //else
        //{
        //    is10 = false;
        //}
        //Console.WriteLine("is10 is {0}",is10);

        //int totalCoffeCost = 0;
        //string userInput="";
        //do {
        //    Console.WriteLine("Choose 1-Small  2-Medium  3-Large");
        //    int UserChoice = int.Parse(Console.ReadLine());
        //    switch (UserChoice)
        //    {
        //        case 1:
        //            totalCoffeCost += 1;
        //            break;
        //        case 2:
        //            totalCoffeCost += 2;
        //            break;
        //        case 3:
        //            totalCoffeCost += 3;
        //            break;
        //        default:
        //            Console.WriteLine("Your Choice {0) is invalid", UserChoice);
        //            break;

        //    }

        //        Console.WriteLine("Do you want to buy another Yes - No");
        //        userInput = Console.ReadLine();

        //}

        //while (userInput.ToUpper() == "YES") ;

        //Console.WriteLine("Thank You for Shopping with us");
        //Console.WriteLine("Bill amount= {0}", totalCoffeCost);




        //Program program = new Program();

        //program.EvenNums(10);
        //int sum = 0, mul = 0;
        //Program.Add(5,4,out sum ,out mul);

        //Console.WriteLine(sum+" "+mul);
        //int[] nums=new int[3];
        //nums[0] = 1;
        //nums[1] = 2;
        //nums[2] = 3;
        //Program.ArrayMethod(nums);
    }
    //public void EvenNums(int num)
    //{
    //    for (int i = 0; i <= num; i+=2) { 
    //        Console.WriteLine(i);
    //    }
    //}
    //public static void Add(int a, int b,out int sum,out int mul)
    //{
    //    sum = a + b;
    //    mul =a* b;
       
    //}
    //public static void ArrayMethod(int[] arr) {
    //    Console.WriteLine("There are {0} elements",arr.Length);

    //    foreach (int i in arr)
    //    {
    //        Console.WriteLine(i);
    //    }
    //}
}
