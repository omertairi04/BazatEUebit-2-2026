using System;

public class ForLoops
{
  public static void Main(string[] args)
  {
    
    int numri = 0;
    
    // for (vlera fillestare e ciklit; 
    // kushti per me u ekzekutu kodi;
    // per sa e rrismi ciklin
    // ) {
    // pjese e kodit qe egzekutohet xhdo cikel
    // }

    // for (int zh=1; zh<=50;zh++)
    // {
    //   if(zh % 2 == 0)
    //   {
    //     Console.WriteLine("Numri " + zh + " esht cift");
    //   } 
    //   else
    //   {
    //     Console.WriteLine("Numri " + zh + " esht tek");
    //   }
    // }


    // for (int i=20; i>=1;i--) {
    //       Console.WriteLine(i);
      
          
    //   }

      
    // Console.WriteLine(numri);

    int vlera = 1;
    for (int i=1; i <= 50; i++)
    {
      if (i % 2 == 1  )
      {
        Console.WriteLine("Ky numer esht tek " + i);
      }
    }



  }
}