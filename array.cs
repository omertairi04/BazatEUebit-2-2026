using System;
public class array
{
  public static void Main(string[] args)
  {
    
    // int[] numrat = new int[5];
    // numrat[0] = 2;
    // numrat[1] = 10;
    // numrat[2] = -5;
    // numrat[3] = numrat[1] + numrat[2];
    // numrat[4] = -10 + numrat[0] - numrat[1];

    // for (int i=0; i<=4;i++)
    // {
    //   Console.WriteLine(numrat[i]);
    // }

    // string emri = "Omer";
    // char[] emri = {'O', 'm', 'e', 'r'};

    // // Console.WriteLine(emri.Length); // 5

    // for (int i=0; i<emri.Length; i++)
    // {
    //  Console.WriteLine(emri[i]); 
    // }
                // 0123
    // string emri = "Omer";
    // char[] eChar = emri.ToCharArray();
    // ['O' , 'm', 'e', 'r']
    
    // eChar[1] = 'e';

    // for (int i=0; i<eChar.Length; i++)
    // {
    //   Console.WriteLine(eChar[i]); 
    // }
              // 0  1    2    3    4     5
    int[] nr = {10, 1 , -5 , 20 , 100, -10};

    int max = nr[0];
    for (int i=1;i<nr.Length;i++)
    {
      if (nr[i] > max)
      {
        max = nr[i];
      }
    }

    Console.WriteLine(max);

    

  }
}