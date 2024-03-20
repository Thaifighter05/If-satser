
if (6>=3)

Console.WriteLine("Hello, World!");
Console.ReadLine();



int x=1;
while(x==1)
{
  Console.WriteLine("What's your name");
  string name = Console.ReadLine();
  name = name.ToLower();

  if (name != "noname")
  {
  Console.WriteLine("Wrong username");
  Console.ReadLine();
  }

  else if (name == "noname")
  {
    Console.WriteLine("correct");
    Console.ReadLine();
  }
      

    
  while(x==2)
  {


  Console.WriteLine("what is your password");
string password = Console.ReadLine();
password = password.ToLower();

if (password != "nopass")
  {

    Console.WriteLine("Wrong password");
    Console.WriteLine("what is your password");
    password = password.ToLower();
    Console.ReadLine();
  }
   else if(password == "nopass")
    {
      Console.WriteLine("correct");
    }

if( name == "noname" & password == "nopass") 
{ 
Console.WriteLine("Welcome");
Console.ReadLine();


  for (int i= 0; i <= 32; i++)
  {
   Console.WriteLine("Hello world");
  }
}

  }
    } 






// while (i > 0)
// {
//     Console.WriteLine("Hello world");
// }