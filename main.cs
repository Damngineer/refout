using System;
                     
public class refoutexample
{
   public static void Main()
    {
        int refValue=5;     //Başlangıç değeri atanması zorunludur.
        int outValue;       //Başlangıç değeri atanması zorunlu değildir.
 
        refout(ref refValue, out outValue);
 
        Console.WriteLine("ChangeMethod'dan sonra refValue: " + refValue); // 7
        Console.WriteLine("ChangeMethod'dan sonra outValue: " + outValue);  // 8
    }
 
    static void refout(ref int i,out int j)
    {
          i = i + 2;  // ref için değer atanması zorunlu değil
          j = 8;      // out için değer atanması zorunlu
    }
}
