using System;

namespace HowPowMethodWorks
{
    class Program
    {
        static int Pow2(int a,int b){
            if(b==0){
                return 1;
            }
            else {
                return  a*Pow2(a,b-1);
            }
        }
        static void Main(string[] args)
        {
            int a =int.Parse(Console.ReadLine());
            int b =int.Parse(Console.ReadLine());
            
            Console.WriteLine(Pow2(a,b));
            Console.ReadLine();
        }
    }
}
