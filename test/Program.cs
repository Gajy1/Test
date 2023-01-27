Console.Clear();

string[] arrString;
arrString = new string[4];


static void FilArr(string[] arrString)
    {
  
      for (int i = 0; i < arrString.Length; i++)
      {
        Console.WriteLine("Введите строку:");
        string s = Console.ReadLine();
          arrString[i] = s;
      }
      
    }
    
    
     void PrintArr(string[] arrString)
    {
  
      for (int i = 0; i < arrString.Length; i++)
      {
        if(i < arrString.Length - 1)
         Console.Write($" {arrString[i]}, ");

         if(i == arrString.Length - 1)
         Console.Write($" '{arrString[i]}' ");
      }
    }

    static void PrintArrB(string[] arrString)
    {
  
      for (int i = 0; i < arrString.Length; i++)
      {
        if(arrString[i].Length < 4)
        {
          Console.Write($" '{arrString[i]}' ");
        }
      }
      
    }
    
    FilArr(arrString);
    Console.WriteLine();
    Console.Write("["); PrintArr(arrString);  Console.Write("]");
    Console.WriteLine();
    Console.Write("["); PrintArrB(arrString);  Console.Write("]");
  

    