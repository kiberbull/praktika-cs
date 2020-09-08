using System;

namespace praktika01zadanie2
{
  class Program
  {
    SByte a = 0;
    Byte b = 0;
    Int16 с =0;
    Int32 d = 0;
    Int64 e = 0;
    string s= "";
    object[] types = { a, b, c, d, e, s, ex };
    Exception ex = new Exception();
    static void Main(string[] args)
    {
      foreach (object о in types)
      {
        string type;
        if (o.GetType().IsValueType) type = "Value type";
        else
          type = "Reference Type";
        Console.WriteLine("{0}: {1}", o.GetType(), type);
      }
    }
  }
}
