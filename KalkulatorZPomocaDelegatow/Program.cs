using KalkulatorZPomocaDelegatow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorZPomocaDelegatow
{
   public class Program
    {
        
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Menager menager = new Menager(calculator);
            menager.MenuWriter();
          
        }
    }
}
public class Calculator
{
   
    
    public int Add(int x, int y)
    {
        return x + y;
        
        
    }
    public int Substraction(int x, int y)
    {
        return x - y;
    }
    public int Multiply(int x, int y)
    {
        return x * y;
    }
    public int Division(int x, int y)
    {
        return x / y;
    }

}
public class Menager
{
    public static  Func<int, int, int> FuncDelegate;
    Calculator calculator1;
    public Menager(Calculator calculator)
    {
        calculator1 = calculator;
    }
    public void MenuWriter()
    {
        
        Console.WriteLine("Wybierz jedno z działań 1: dodawanie \n 2: odejmowanie \n 3: mnożenie \n 4:dzielenie ");
        string a = Console.ReadLine();
        switch (a)
        {
            case "1": FuncDelegate = calculator1.Add; break;
            case "2": FuncDelegate = calculator1.Substraction; break;
            case "3": FuncDelegate = calculator1.Multiply; break;
            case "4": FuncDelegate = calculator1.Division; break;


        }
        Console.WriteLine("Podaj pierwsza i druga cyfre");
        int w = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        int wynik = FuncDelegate.Invoke(w, f);
        Console.WriteLine("Wynik to " + wynik);
        Console.ReadLine();
    }
}