using System;

public class OperatoretLogjik
{
  public static void Main(string[] args)
  {
    /*

    EDHE = && => kushti1 edhe kushti2
    OSE = || => kushti1 ose kushti2
    JO = ! => jo kushti
    */

    if (false && true)
    {
      Console.WriteLine("Ky esht true"); // 1
    } else if (true || false)
    {
      Console.WriteLine("Ky esht true"); // 2
    } else {
      Console.WriteLine("Ky esht true"); // 3
    }
  }
}