﻿using System;
using System.Collections.Generic;
using System.Text;

namespace final_program
{
    class GPA
    {
        public void GetGpa()
        {
        //GPA Calculator Start
        //User Input

         Console.WriteLine("GPA Calculator\n===============\nRead The Following Instructions Then Enter\n==========================================");
         Console.WriteLine("How many classes are you taking?  ");


               //Use Formulas
         string many = Console.ReadLine();
                int x = 0;
         if (int.TryParse(many.Trim(), out x)); //Best solution so far
             String[] Grade = new string[x];
             Double[] G = new double[x];
             Double Sum = 0;

         Console.WriteLine("\nEnter your grade as (A,a)");
               for (int i = 0; i<x; i++)
               {
                   Console.Write(" {0} : ", i + 1);
                   Grade[i] = Console.ReadLine();
                      if (Grade[i] == "A" || Grade[i] == "a")
                       {
                           Grade[i] = "4";
                       }
                      else if (Grade[i] == "B" || Grade[i] == "b")
                      {
                            Grade[i] = "3";
                      }
                      else if (Grade[i] == "C" || Grade[i] == "c")
                      {
                            Grade[i] = "2";
                      }
                      else if (Grade[i] == "D" || Grade[i] == "d")
                      {
                           Grade[i] = "1";
                      }
                      else if (Grade[i] == "F" || Grade[i] == "f")
                      {
                           Grade[i] = "0";
                      }
                      else
                      {
                           Console.WriteLine("Error , Please enter your grade as (A,a)");
                           Grade[i] = "0";
                      }
                      G[i] = Convert.ToDouble(Grade[i]);
                        Sum += G[i];
               }

                 //Output to users
          Double Result = Sum / x;
          Console.WriteLine("\nYour (GPA) is : {0:F2}", Result);

          Console.ReadKey();
                  
                  //GPA Calculator End
        }

    }
}
