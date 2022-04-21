// See https://aka.ms/new-console-template for more information
Console.Write("Enter a number;");  
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= number - 1; i++)  
            {  
                if (number % i == 0)  
                {  
                    Console.WriteLine( " not a Prime number");
                    break;
                }  
            
            if (i == number - 1)  
            {  
                Console.WriteLine( " Prime number");
                break;
            }  
            
        }
