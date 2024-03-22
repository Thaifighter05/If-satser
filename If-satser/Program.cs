
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
      x+=1;
  }
      

    
    while(x==2)
  {


    Console.WriteLine("what is your password");
    string password = Console.ReadLine();
    password = password.ToLower();

    if (password != "nopass")
    {

    Console.WriteLine("Wrong password");
    
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
        //  if(i> 32)
        //  {
        //   x+=1;
        //  }

      }
    }
    x+=1;
    if (x==3)
    {
      break;
    }
  }
    
    for(int a = 0; a <= 5; a++)
    {
  
      Console.WriteLine("Skriv in en siffra");
      string siffra = Console.ReadLine();
      siffra = siffra.ToLower();
      int sif;
      if ((int.TryParse(siffra, out sif) ) )
      {
        if (sif > 5)
        {
        Console.WriteLine("högre än 5!");
        }
      }
      else 
      {
      Console.WriteLine("testa en annan siffra");
      }
    }
} 






