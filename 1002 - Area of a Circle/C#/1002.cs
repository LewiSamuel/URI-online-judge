using System;
class MainClass {
  public static void Main (string[] args) {
    double raio=0;
    double area=0;
    
  	raio = Convert.ToDouble(Console.ReadLine());
    
    area = (3.14159*(raio*raio));

    string.Format("{0:0,0.0000}", area);

    Console.WriteLine("X = "+ area);
  }
}