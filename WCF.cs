using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespaceWindowServiceClient
{
   classProgram
   {
      staticvoid Main(string[] args)
      {
      
         MyServiceClient client = newMyServiceClient();
         Console.WriteLine("Client calling the service...");
         Console.WriteLine("Sum of two numbers 5,6");
         Console.WriteLine(client.Add(5, 6));
        
         Console.WriteLine("Subtraction of two numbers 6,5");
         Console.WriteLine(client.Add(6, 5));
        
         Console.WriteLine("Multiplication of two numbers 6,5");
         Console.WriteLine(client.Add(6, 5));
        
         Console.WriteLine("Division of two numbers 6,3");
         Console.WriteLine(client.Add(6, 3));

         Console.Read();
      }
   }
}