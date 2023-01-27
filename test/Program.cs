Console.Clear();

string[] arrString;
arrString = new string[4];


static void FilArr(string[] arrString)
    {
  
      for (int i = 0; i < arrString.Length; i++)
      {
        Console.WriteLine("Введите строку:");
        string s = Console.ReadLine();
        if(s.Length < 4)
          arrString[i] = s;
      }
      
    }
    
    
     void PrintArr(string[] arrString)
    {
  
      for (int i = 0; i < arrString.Length; i++)
      {
        if(arrString[i] != null)
         Console.Write($" {arrString[i]}, ");
      }
    }
    
    FilArr(arrString);
    Console.WriteLine();
    Console.Write("["); PrintArr(arrString);  Console.Write("]");
  

    