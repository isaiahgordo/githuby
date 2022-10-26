using System.Security.Claims;
using System.Text;

namespace githuby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ascii = new List<string>(), word = new List<string> { "COMPUTER" };
            string consread;
            Random r = new Random();
            int firstIndexOf,i=0,rum=0,indexer;
            StringBuilder secrectWord=new StringBuilder(word[rum]);
            bool done = false;
            ascii.Add("  +---+");
            ascii.Add("  |   |");
            ascii.Add("      |");
            ascii.Add("      |");
            ascii.Add("      |");
            ascii.Add("      |");
            ascii.Add("=========");
            StringBuilder helper = new StringBuilder(ascii[3],3);
            firstIndexOf = ascii[1].IndexOf("| ");
            Console.WriteLine("Do you want to play hangman?");
            consread = Console.ReadLine().ToUpper().Trim();
            if(consread=="YES"|consread=="Y")
            {
                Console.WriteLine("Do you know how to play?");
                consread = Console.ReadLine().ToUpper().Trim();
                if (consread == "Y" | consread == "YES")
                    Console.WriteLine("Okay then");
                else
                    Console.WriteLine("Enter a letter or what you think is the word and press enter");
                while(done==false)
                {
                    consread = Console.ReadLine().ToUpper().Trim();
                    indexer = word[rum].IndexOf(consread);
                    if (word[rum] == consread)
                    {
                        Console.WriteLine("You win, play again?");
                        consread = Console.ReadLine().Trim().ToUpper();
                        if (consread == "Y" | consread == "YES")
                            Console.WriteLine("Yay");
                        else
                            done = true;
                    }
                    else if (word[rum].Contains(consread))
                    {
                        secrectWord[indexer]=Convert.ToChar(consread);
                    }
                    else
                        i++;
                    if(i==0)
                    {
                        
                    }
                    else if(i==1)
                    {
                        
                    }
                }
                Console.WriteLine("Bye");
            }
        }
    }
}