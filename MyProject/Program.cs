using System;
namespace cproject{
    class Program{
        public void getToken(){
            Console.WriteLine("Iam the method");
        }
        static void Main (String [] args){

            Console.WriteLine("Hello World");
            // static datatypes
            int a= 5;
            string name = "tony";
            double b= 34.0;
            Console.WriteLine(a + name);

            // dynamic datatypes
            var age  =55;                                      
            //  in this it will automatically get the data type at runtime
            dynamic hieght = 76;
            // again i can assign value to the same varialbe hieght because it is dynamic datatype
            hieght = 100;
            Console.WriteLine(hieght);



        }
    }
}