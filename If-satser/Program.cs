
if (6>=3)

Console.WriteLine("Hello, World!");
Console.ReadLine();

Console.WriteLine("What's your name");
string name = Console.ReadLine();
name = name.ToLower();


while(name != "noname")
{
  Console.WriteLine("Wrong username");
  Console.WriteLine("")
  Console.ReadLine();

  if (name == "noname")
  {
    Console.WriteLine("correct");
    Console.ReadLine();
  }
}

Console.WriteLine("what is your password");
string password = Console.ReadLine();
password = password.ToLower();

while ( password != "nopass")
{
    Console.WriteLine("What's your password");
    Console.ReadLine();
    if(password == "nopass")
    {
      Console.WriteLine("correct");
    }

}

// if( name == "noname" & password == "nopass") 
// { 
// Console.WriteLine("Welcome");
// Console.ReadLine();
// }




for (int i= 0; i <= 32; i++)
{
  Console.WriteLine("Hello world");

}

// while (i > 0)
// {
//     Console.WriteLine("Hello world");
// }