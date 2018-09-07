using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Unit = System.ValueTuple;

namespace FunctionalCSharp {
   

   public static class Program {
      static void Main(string[] args) {
         Int32[] numeros = { 1 ,2, 3, 4, 5};
         Console.WriteLine(numeros.ToString());
         Console.ReadLine();
      }

      public static String GetName(String name) {
         return name;
      }
   }

}