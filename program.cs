//class name needs to be in caps 

using System; // if written then no need to write System.
class Test{




public static void Main(string[] args)
{
System.Console.WriteLine("123");
System.Console.WriteLine("ahnaf rashid");
Console.WriteLine("no need for system.");
Console.Write(678); // no new line made
Console.Write("GG"); // or use \n \t for space in line  "\n  use \" for printing "
// typecasting

 double salary =12314.1221;
 int salary2 = (int)salary;
 Console.WriteLine("\n"+salary2); // char ->int ->long ->float ->double auto reverse is manual needs (int) 
 
 //string interpolation - string er bhitre varialbe 
Console.WriteLine($"salary =  {salary}");  // use $"string{var}" 

int no = Convert.ToInt32(salary); 
Console.WriteLine($"slalat uis {no}");

//parse - convert
string no1="999";
int store =  int.Parse(no1);
Console.WriteLine(store);

//try parse 
bool isSuccess = int.TryParse(no1, out int result);
Console.WriteLine(result);

//input from user
string? inpu; // ? mane nullable
inpu=Console.ReadLine();
Console.WriteLine(inpu);

}
} 