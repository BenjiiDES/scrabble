using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scrabble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            controller();
        
        
        
        
        
        }   
    
       static string view() 
        {

            Console.WriteLine("velkommen til scrabble");
            Console.WriteLine("du skal skrive et ord og så fortæller jeg hvor mange points dit ord er");
            Console.WriteLine("hvert bogstave giver en væse mængde poinge  ");
            Console.WriteLine("");
            Console.WriteLine("bogstaver der giver 1 point er: E,A.N,R ");
            Console.WriteLine("bogstaver der giver 2 point er: D, L, O, S, T");
            Console.WriteLine("bogstaver der giver 3 point er: B, I, K, F, G, M, U, V");
            Console.WriteLine("bogstaver der giver 4 point er: H, J, P, Y, Æ, Ø, Å");
            Console.WriteLine("bogstaver der giver 8 point er: C, X, Z, W, Q");
            Console.WriteLine("hvad er dit ord");
            string Word = Console.ReadLine().ToUpper();
            return Word;
            
        
        }
        static void controller() 
        {
           string Word = Program.view();
          int Value = 0;

            foreach(char kode in Word)
            switch (kode) 
            {
              case 'E':
              Value = Value + 1;
               break;
                    case 'A':
                        Value = Value + 1;
                        break;
                    case 'N':
                        Value = Value + 1;
                        break;
                    case 'R':
                        Value = Value + 2;
                        break;
                    case 'D':
                        Value = Value + 2;
                        break;
                    case 'L':
                        Value = Value + 2;
                        break;
                    case 'O':
                        Value = Value + 2;
                        break;
                    case 'S':
                        Value = Value + 2;
                        break;
                    case 'T':
                        Value = Value + 2;
                        break;
                    case 'B':
                        Value = Value + 3;
                        break;
                    case 'I':
                        Value = Value + 3;
                        break;
                    case 'K':
                        Value = Value + 3;
                        break;
                    case 'F':
                        Value = Value + 3;
                        break;
                    case 'G':
                        Value = Value + 3;
                        break;
                    case 'M':
                        Value = Value + 3;
                        break;
                    case 'U':
                        Value = Value + 3;
                        break;
                    case 'V':
                        Value = Value + 3;
                        break;
                    case 'H':
                        Value = Value + 4;
                        break;
                    case 'J':
                        Value = Value + 4;
                        break;
                    case 'P':
                        Value = Value + 4;
                        break;
                    case 'Y':
                        Value = Value + 4;
                        break;
                    case 'Æ':
                        Value = Value + 4;
                        break;
                    case 'Ø':
                        Value = Value + 4;
                        break;
                    case 'Å':
                        Value = Value + 4;
                        break;
                    case 'C':
                        Value = Value + 8;
                        break;
                    case 'W':
                        Value = Value + 8;
                        break;
                    case 'X':
                        Value = Value + 8;
                        break;
                    case 'Z':
                        Value = Value + 8;
                        break;
                    case 'Q':
                        Value = Value + 8;
                        break;

                    default:
                        break;


                        






























                }



            Console.WriteLine("Dit ord er " + Word);
            Console.WriteLine("Og værdien er " + Value);
            Console.ReadKey();


                }
            }
 
        }
    
    
    
