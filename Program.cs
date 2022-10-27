using System.Security.Claims;
using System.Text;

namespace githuby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ascii = new List<string>(), word = new List<string> { "COMPUTER","BINKA","BEAN","" };
            string consread;
            Random r = new Random();
            int firstIndexOf,i=0,rum,indexer,j;
            rum = r.Next(word.Count );
            StringBuilder secrectWord=new StringBuilder(word[rum]);
            bool done = false;
            for (int inWord = 0; inWord < word[rum].Length; inWord++)
                secrectWord[inWord] = '_';
            ascii.Add("  +---+");
            ascii.Add("  |   |");
            ascii.Add("      |");
            ascii.Add("      |");
            ascii.Add("      |");
            ascii.Add("      |");
            ascii.Add("=========");
            StringBuilder asci3 = new StringBuilder(ascii[2]),asci4=new StringBuilder(ascii[3]),asci5=new StringBuilder(ascii[4]);
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
                    Console.WriteLine(secrectWord.ToString());
                    consread = Console.ReadLine().ToUpper().Trim();
                    indexer = word[rum].IndexOf(consread);
                    if (word[rum] == consread)
                    {
                        Console.WriteLine("You win, play again?");
                        consread = Console.ReadLine().Trim().ToUpper();
                        if (consread == "Y" | consread == "YES")
                        {
                            rum = r.Next(word.Count);
                            Console.WriteLine("Yay");
                            secrectWord=new StringBuilder(word[rum]);
                            for (int inWord = 0; inWord < word[rum].Length; inWord++)
                                secrectWord[inWord] = '_';
                            i = 0;
                        }
                        else
                            done = true;
                    }
                    else if (word[rum].Contains(consread))
                        secrectWord[indexer]=Convert.ToChar(consread);                    
                    else
                        i++;
                    if (i == 0)
                    {
                        for (j = 0; j < ascii.Count; j++)
                            Console.WriteLine(ascii[j].ToString());
                        Console.WriteLine(secrectWord.ToString());
                    }
                    else if (i == 1)
                    {
                        asci3[firstIndexOf] = '0';
                        for (j = 0; j < ascii.Count; j++)
                        {
                            if (j < 2 | j > 2)
                                Console.WriteLine(ascii[j].ToString());
                            else
                                Console.WriteLine(asci3.ToString());
                        }
                        Console.WriteLine(secrectWord.ToString());

                    }
                    else if (i == 2)
                    {
                        asci4[firstIndexOf - 1] = '/';
                        asci4[firstIndexOf] = '|';
                        asci4[firstIndexOf + 1] = '\\';
                        for (j = 0; j < ascii.Count; j++)
                        {
                            if (j < 2 | j > 3)
                                Console.WriteLine(ascii[j].ToString());
                            else if (j == 2)
                                Console.WriteLine(asci3.ToString());
                            else
                                Console.WriteLine(asci4.ToString());
                        }
                        Console.WriteLine(secrectWord.ToString());
                    }
                    else if (i == 3)
                    {
                        asci5[firstIndexOf - 1] = '/';
                        asci5[firstIndexOf + 1] = '\\';
                        for (j = 0; j < ascii.Count; j++)
                        {
                            if (j < 2 | j > 4)
                                Console.WriteLine(ascii[j].ToString());
                            else if (j == 2)
                                Console.WriteLine(asci3.ToString());
                            else if(j==3)
                                Console.WriteLine(asci4.ToString());
                            else
                                Console.WriteLine(asci5.ToString());
                        }
                        Console.WriteLine(secrectWord.ToString());
                    }
                    else
                    { 
                        Console.WriteLine("Ugh, oh no they're dead you lose");
                        Console.WriteLine("do you want to play agian?");
                        consread=Console.ReadLine().Trim().ToUpper();
                        if(consread=="Y"|consread=="YES")
                        {
                            rum=r.Next(word.Count);
                            Console.WriteLine("Hurray");
                            secrectWord = new StringBuilder(word[rum]);
                            for (int inWord = 0; inWord < word[rum].Length; inWord++)
                                secrectWord[inWord] = '_';
                            i = 0;
                        }
                        else
                            done=true;
                    }
                }
                Console.WriteLine("Bye");
            }
        }
    }
}