using System;

public class Functions {

    public static void pershendetje() {
        Console.WriteLine("Hello World");
        Console.WriteLine("Tekst 231");
    }
    
    public static int rezultati() {
        return 2 + 2;
    }
    
    public static double gjejRadius(double rrezja) {
        return 3.14 * (rrezja * rrezja);
    }
    
    public static int fuqija(int numri, int fuqi) {
        int rez = 1;
        for (int i=0;i<fuqi;i++) {
            rez *= numri;
        }
        
        return rez;
    }
    
    public static int shumaEArray(int[] array) {
        int shuma = 0;
        for (int i=0; i < array.Length;i++) {
            shuma += array[i];
        }
        return shuma;
    }
    
    public static bool gjejNumrin(int[] array, int vlera) {
        for (int i=0; i<array.Length;i++) {
            if (array[i] == vlera) {
                return true;
            }
        }
        return false;
    }
    
    public static bool palindrom(string fjala) {
        bool eshtPalindrom = false;
        char[] fjalaChar = fjala.ToCharArray();
        
        for (int i=0;i<fjalaChar.Length/2 ; i++) {
            
        }
    }
    
    public static void Main(string[] args)
    {
        // pershendetje();
        // rezultati();
        // int res = rezultati() + 2 ;
        // Console.WriteLine(res);
        
        // double radius = gjejRadius(3);
        // double radius1 = gjejRadius(10);
        // Console.WriteLine(radius);
        //  Console.WriteLine(radius1);
        
        // Console.WriteLine(fuqija(2, 2));
        // Console.WriteLine(fuqija(3, 3));
        // Console.WriteLine(fuqija(5, 4));
        
        int[] array = {9, 1 , -2 , 4 , 5 , 5 , 3};
        int[] array1 = {8, 7  , -5, 2 , 1 ,3};
        
        // Console.WriteLine(shumaEArray(array));
        // Console.WriteLine(shumaEArray(array1));
        
        Console.WriteLine(gjejNumrin(array, 3));
        Console.WriteLine(gjejNumrin(array1, -5));
        Console.WriteLine(gjejNumrin(array1, 10));
        
    }
}