using System;
using System.Collections;

String[] arr ={"t","a"};
        String[] a = new String[4];
        a[1]="a";
        a[2]="g";
        for (int i=0;i<=a.Length;i++){
            Console.WriteLine(arr[1]);
        }

        ArrayList b = new ArrayList();
        b.Add("a");
        b.Add("d");
        b.Add("p");
        foreach(string item in b){
            Console.WriteLine(item);
        }
        b.Sort();
        foreach(string item in b){
            Console.WriteLine(item);
        }
