using System;
using System.Runtime.CompilerServices;

public class Recap
{
  public static void Main(string[] args)
  {
    
    int mosha = 21;
    double gjatsija = 180.0;
    bool majmOr = true;
    string emriAkademis = "Edumind Academy 2026";




    Console.WriteLine("Vendosni moshen: ");
    string mosha = Console.ReadLine();
    int moshaRe = Convert.ToInt32(mosha);
    
    Console.WriteLine("Mosha juaj esht: " + moshaRe);

    moshaRe = moshaRe +  5;
    Console.WriteLine("Mosha juaj pas 5 viteve esht: " + moshaRe);

    double gjatsija = 180.5;
    bool majmOr = true;
    string emriAkademis = "Edumind Academy 2026";

    Console.WriteLine("Vendosni peshen tuaj: ");
    string pesha = Console.ReadLine();
    double peshaDouble = Convert.ToDouble(pesha);
    peshaDouble = peshaDouble - 2;
    Console.WriteLine(peshaDouble);


  }
}
