using System;

public class IfConditions
{
  public static void Main(string[] args)
  {
    /*
    if (kushti) {
      kodi
    } else if (kushti) {
      kodi
    } else {
      kodi
    }
    */  

    // string input = Console.ReadLine();
    // Console.WriteLine(input.ToLower());
    // if (input.ToLower() == "admin") {
    //     Console.WriteLine("Ti je administrator"); // 1
    // } else {
    //     Console.WriteLine("Ti je user"); // 2
    // }
    
    string pass1 = Console.ReadLine();
    string pass2 = Console.ReadLine();

    // nqoftse pass1 e barabart me pass2 , at here printoni "VAZHDO"
    // perndryshe printoni "X"

    if (pass1 == pass2)
    {
      Console.WriteLine("VAZHDO");
    } else
    {
      Console.WriteLine("NUK JAN TE NJEJT");
    }


  }
}