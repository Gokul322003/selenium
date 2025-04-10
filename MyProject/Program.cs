using System;
using project1;
namespace project
{
    class Program
    
    {   string name;

        public Program(String name)
        {
            this.name = name;
        }

        static void Main(String[]args){
            Console.WriteLine("I am Program ");
            Program1 p = new Program1();
            p.setData();
            p.setData1();
           
        }
        public void getData(){
            Console.WriteLine(this.name);

        }

        
       
     }
        
}