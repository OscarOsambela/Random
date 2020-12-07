using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
    
    Random dado = new Random();
    int numCara;
    for(int i = 0; i < 1; i++){
      numCara = dado.Next(1,7); 
      Console.WriteLine("El número aleatorio entre 1 y 6 es = {0}", numCara);
    }
		
    Console.WriteLine("Haz una pregunta");
    Console.ReadLine();
    Random rueda = new Random();
    int resultado;
    resultado = rueda.Next(1, 4);
    if(resultado == 1) Console.WriteLine("Si");
    else if(resultado == 2) Console.WriteLine("Quizás");
    else Console.WriteLine("No");
  }
}
