using System;

public class detyraZgjidhje
{
  public static void Main(string[] args)
  {

    // D1
    /*
    Console.WriteLine("Vendos nje numer!");
        string input = Console.ReadLine();
        
        double vlera = Convert.ToDouble(input);
        
        if (vlera > 0) {
            Console.WriteLine("Numer pozitiv");
        } else if (vlera == 0) {
            Console.WriteLine("Numeri eshte 0");
        } else {
            Console.WriteLine("Numri negativ");
        }
        */

        // D2
        /*
        Console.WriteLine("Vendos numer");
        string input = Console.ReadLine(); // 231
        int mbetja = Convert.ToInt32(input);
        int vlera = mbetja % 2;
        if (vlera == 0) {
            Console.WriteLine("Numer cift");
        } else {
            Console.WriteLine("Numer Tek");
        }
        */

        // D3
        /*
        string input = Console.ReadLine();
        int vitet = Convert.ToInt32(input);
        
        if (vitet >= 18) {
            Console.WriteLine("Mund te vozitesh");
        } else if (vitet >= 16 && vitet < 18){
            Console.WriteLine("Mund ti mbash oret");
        } else {
            Console.WriteLine("Nuk mund te vozitesh");
        }
        */

        // string username = Console.ReadLine();
        // string password = Console.ReadLine();
        
        // if (username == "ADMIN" && password == "ADMIN") {
        //     Console.WriteLine("TI JE ADMIN");
        // } else {
        //     Console.WriteLine("Ti je perdorues");
        // }
        
        if (!true) {
            Console.WriteLine("1"); // 1
        } else {
            Console.WriteLine("2"); // 2
        }

        string input = Console.ReadLine();
        double pikt = Convert.ToDouble(input);
        
        if (pikt >= 90 && pikt <= 100) {
            Console.WriteLine("Shkelqyshem"); // 1
        } else if (pikt >= 70 && pikt <= 89) {
            Console.WriteLine("Shum mir"); 
        } else if (pikt >= 50 && pikt <= 69) {
              Console.WriteLine("Mjaftushem"); 
        } else {
              Console.WriteLine("Deshtim"); 
        }

        Console.WriteLine("Nqoftse je student, pergjigju PO");
        string input = Console.ReadLine();
        bool eshtStudent = false;
        if (input == "PO") {
            eshtStudent = true;
        }
        int shpenzime = 8; // euro
        
        if (eshtStudent == true || shpenzime >= 10) {
            shpenzime -= 2;
        }
        
        Console.WriteLine("Per te paguar: " + shpenzime);
        
        

  }
}