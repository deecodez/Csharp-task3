using System;


namespace csharptask3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assigning userinput into a variable
            string userChoice;
            int userinput;

            int [] easyNumber = new int[6];
            int [] mediumNumber = new int[8];
            int [] hardNumber = new int[10];

            //storing the number value for easy level;
            easyNumber[0] = 1;
            easyNumber[1] = 3;
            easyNumber[2] = 8;
            easyNumber[3] = 4;
            easyNumber[4] = 5;
            easyNumber[5] = 10;

            //storing the number value for medium level;
            mediumNumber[0] = 8;
            mediumNumber[1] = 11;
            mediumNumber[2] = 6;
            mediumNumber[3] = 20;
            mediumNumber[4] = 18;
            mediumNumber[5] = 10;
            mediumNumber[5] = 13;
            mediumNumber[5] = 15;

            //storing the number value for hard level;
            hardNumber[0] = 10;
            hardNumber[1] = 21;
            hardNumber[2] = 49;
            hardNumber[3] = 31;
            hardNumber[4] = 45;
            hardNumber[5] = 32;
            hardNumber[5] = 40;
            hardNumber[5] = 11;
            hardNumber[5] = 5;
            hardNumber[5] = 15;
            
            Console.WriteLine("Welcome to our guessing game, Please enter the level u want to play by typing either easy, medium or hard");
            Console.WriteLine();

            Console.Write("Enter level of choice: ");
            userChoice = Console.ReadLine();


            // Easy level 
            if(userChoice == "easy")
            {
                
                for (int counter=0; counter <= 6; counter++)
                {
                        
                    if (counter == 6 )
                    {
                        Console.WriteLine("geme over"); 
                        break;
                    }
                    
                    Console.Write("Guess the number between 1-10: ");
                    userinput = int.Parse(Console.ReadLine());
                    Array.Exists(easyNumber, element => element == userinput); 

                    if(Array.Exists(easyNumber, element => element == userinput))
                    {
                        Console.WriteLine("You got it right");
                    
                    } 
               
                    else
                    {
                        Console.WriteLine("Congratulations, You gussed wrong");
                        Console.WriteLine("You have " + (5 - counter) + " attempts left");
                    }

                }

                    
            }
            

            // Medium level
             else if(userChoice == "medium")
            {
                
                for (int counter=0; counter <= 4; counter++)
                {
                        
                    if (counter == 4 )
                    {
                        Console.WriteLine("geme over"); 
                        break;
                    }
                    
                    Console.Write("Guess the number between 1-20: ");
                    userinput = int.Parse(Console.ReadLine());
                    Array.Exists(mediumNumber, element => element == userinput); 

                    if(Array.Exists(mediumNumber, element => element == userinput))
                    {
                        Console.WriteLine("You got it right");
                    
                    } 
               
                    else
                    {
                        Console.WriteLine("Congratulations, You gussed wrong");
                        Console.WriteLine("You have " + (3 - counter) + " attempts left");
                    }

                }

                    
            }


            // Hard level
            else if(userChoice == "hard")
            {
                
                for (int counter=0; counter <= 3; counter++)
                {
                        
                    if (counter == 3 )
                    {
                        Console.WriteLine("geme over"); 
                        break;
                    }
                    
                    Console.Write("Guess the number between 1-50: ");
                    userinput = int.Parse(Console.ReadLine());
                    Array.Exists( hardNumber, element => element == userinput); 

                    if(Array.Exists( hardNumber, element => element == userinput))
                    {
                        Console.WriteLine("You got it right");
                    
                    } 
               
                    else
                    {
                        Console.WriteLine("Congratulations, You gussed wrong");
                        Console.WriteLine("You have " + (2 - counter) + " attempts left");
                    }

                }

                    
            }else{
                Console.WriteLine("Checking Your spelling, Make sure u spell easy, medium, hard as spelled here");
            }
        }
    }
}
