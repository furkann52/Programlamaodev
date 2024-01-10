namespace Programlamaodev
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                try
                {
                    Console.WriteLine("Enter the starting number : ");
                    byte str = byte.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the ending number : ");
                    byte fns = byte.Parse(Console.ReadLine());
                    Console.WriteLine("How many numbers do you want it to be? : ");
                    byte numbers = byte.Parse(Console.ReadLine());

                    Random rnd = new Random();
                    int[] sayi = new int[numbers];
                    int number;
                    for (int i = 0; i < sayi.Length; i++)
                    {
                        number = rnd.Next(str, fns);
                        if (i == 0)
                        {
                            sayi[i] = number;
                        }

                        for (int j = 0; j < i; j++)
                        {
                            if (sayi[j] == number)
                            {
                                i--;
                                break;
                            }
                            else
                            {
                                sayi[i] = number;
                            }
                        }
                    }
                    Array.Sort(sayi);
                    for (int i = 0; i < sayi.Length; i++)
                    {
                        Console.WriteLine(sayi[i]);
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please enter a value between 0-255!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter numbers in numerals!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There's been a mistake!");
                    Console.WriteLine($"Error details: \nDate:{DateTime.Now} \nMessage: {ex.Message} \nDetail: {ex.StackTrace}");
                }
                    Console.ReadKey();
            }
              
        }
    }
    
