using System;
using System.Collections.Generic;

namespace structures
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Cümle giriniz : ");
            string s=Console.ReadLine();
           
            string[] kelimeler=s.Split(" ");
            

            ReplaceFirstLast(kelimeler);
        }

        public static void ReplaceFirstLast(string[] words){
            foreach(var x in words){
                char xFirst,xLast;
                xFirst=x[0];
                xLast=x[x.Length-1];
                int counter=0;

                foreach(var y in x){
                    if(counter==0||counter==x.Length-1){
                        if(x.Length!=1){
                            if(counter==0){Console.Write(xLast);}
                            if(counter==x.Length-1){Console.Write(xFirst);}
                        }else{
                             Console.Write(y);
                        }
                        
                    }else{
                        Console.Write(y);
                    }
                    
                    counter++;
                }
                Console.Write(" ");                

            }
        }
    }
}