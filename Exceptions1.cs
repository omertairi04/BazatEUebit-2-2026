using System;

public class TekstiJoValid : ApplicationException
{
  public TekstiJoValid()
  {
    Console.WriteLine("Teksti esht me i shkurt se 8 shkronja");
  }
}

public class MungonNumerException : ApplicationException
{
  public MungonNumerException()
  {
    Console.WriteLine("Teksit nuk permban numer!");
  }
}

public class Exceptions1
{ 
  public static void Main(string[] args)
  {
    
    string text = Console.ReadLine();

    if (text.Length < 8)
    {
      throw new TekstiJoValid();
    }

    char[] tekstiChar = text.ToCharArray();
    bool egzistonNumer = false;

    for (int i=0; i < tekstiChar.Length; i++)
    {
      if (tekstiChar[i] >= '0' && tekstiChar <= '9')
      {
        egzistonNumer = true;
      }
    }

    if (egzistonNumer == false)
    {
      throw new MungonNumerException();
    }



  }
}