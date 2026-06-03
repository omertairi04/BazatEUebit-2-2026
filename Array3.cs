using System;
public class Arrays3
{
  public static void Main(string[] args)
  {

    string emri = "Omer Tairi";

    // Om3r Tairi

    char[] emriChar = emri.ToCharArray();
    emriChar[2] = "3";

    for (int i=0;i < emriChar.Length;i++)
    {
      Console.WriteLine(emriChar[i]);
    }

  }
}