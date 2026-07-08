using System;

public class ErrorPerEmrin : ApplicationException
{
  public ErrorPerEmrin()
  {
    Console.WriteLine("Ndodhi Exception, nuk mund te egzistoj fjala Omer");
  } 
}

public class Exceptions
{
  
  public static void Main(string[] args)
  {
    try
    {
      // Kodi qe dojm me egzekutu
      string text = "Tairi";
      string txt1 = "Omer";
      if (txt1 == "Omer")
      {
        throw new ErrorPerEmrin();
      }
    } catch (Exception e)
    {
      // Shka printojm moment qe kemi exception
      Console.WriteLine("Ndodhi error");
      Console.WriteLine(e);
    }

  }
}