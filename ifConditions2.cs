using System;

public class IfConditions
{
  public static void Main(string[] args)
  {
    
    /*

    if (kushti) {
      kjo pjesa egzekutohet nqoftse kushti esht TRUE
    } else if (kushti) {
      kjo pjesa egzekutohet nqoftse kushti esht TRUE
    } 
    else {
      kjo pjes egzekutohet nqoftse if apo else if esht FALSE
    }
    */

    // string gjinija = Console.ReadLine();
    
    // if (gjinija == "MASHKULL")
    // {
    //   Console.WriteLine("Ti je mashkull");
    // } else
    // {
    //   Console.WriteLine("Ti je femer");
    // }

    string input = Console.ReadLine();
    int numri = Convert.ToInt32(input);

    if (numri < 0)
    {
      Console.WriteLine("Numri negativ");
    } else if (numri == 0)
    {
      Console.WriteLine("Numri esht 0");
    } else
    {
      Console.WriteLine("Numri esht pozitiv");
    }


  }
}
