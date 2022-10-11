using System.Security.Claims;

namespace githuby
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int i=1;
            Console.WriteLine("Hello welcome to hangman, do you know how to play yes or no");
            Ilisw myobj = new Ilisw();
            myobj.Letter = Console.ReadLine().Trim().ToLower();
            if (myobj.Letter == "no")
                Console.WriteLine("Enter a letter press enter, then you will either see soory this letter is not in it or good job this letter is in it");
            else if (myobj.Letter == "yes")
            { 
                Console.WriteLine("Ok then");
            }
            while (myobj.num == 0)
            {
                myobj.Letter = Console.ReadLine().Trim().ToLower();
                if (myobj.secret.Contains(myobj.Letter))
                {
                    SecrectWord(0);
                }
                else
                {
                    myobj.num = 0;
                    SecrectWord(i);
                    i++;
                }
            }

        }
        class Ilisw
        {
            public string Letter;
            public string secret = "binka";
            public int num=0;
        }
        static void SecrectWord(int i)
        {
            Ilisw newObj = new Ilisw();
            int at, coll = 0;
            List<string> nuse = new List<string>(), person = new List<string>();
            nuse.Add("  +---+");
            nuse.Add("  |   |");
            nuse.Add("      |");
            nuse.Add("      |");
            nuse.Add("      |");
            nuse.Add("  0   |");
            nuse.Add(" /|\\  |");
            nuse.Add(" / \\  |");
            nuse.Add("      |");
            nuse.Add("=========");
            while (newObj.num == 0)
            {
                if (i == 0)
                {
                    for (at = 0; at < nuse.Count(); at++)
                    {
                        if (at > 3|at==nuse.Count()-1)
                        {
                            Console.WriteLine(nuse[at]);
                        }
                    }
                    Console.WriteLine("hkhkkh");
                }
                else if(i == 1)
                {
                    for (at = 0; at < nuse.Count(); at++)
                    {
                        if (at <= 1 | at >= nuse.Count() - 1)
                            Console.WriteLine(nuse[at]);
                        else if (at == 2 && coll == 0)
                        {
                            nuse.RemoveAt(at);
                            Console.WriteLine(nuse[4]);
                            coll = 1;
                        }
                    }
                    Console.WriteLine("gjgjgj");
                }
                else if(i==2)
                {
                    for (at = 0; at < nuse.Count(); at++)
                    {
                        if (at <= 2 | at >= nuse.Count() - 1)
                            Console.WriteLine(nuse[at]);
                        else if(at == 2)
                        {
                            nuse.RemoveAt(at);
                            Console.WriteLine(nuse[4]);
                        }
                    }
                    Console.WriteLine("hllhlhlh");
                }
                else if(i==3)
                {
                    for (at = 0; at < nuse.Count(); at++)
                    {
                        if (at <= 2 | at >= nuse.Count() - 1)
                            Console.WriteLine(nuse[at]);
                        else if (at == 2)
                        {
                            nuse.RemoveAt(at);
                            Console.WriteLine(nuse[4]);
                        }
                    }
                    Console.WriteLine("dgdgdgdgdg");
                    newObj.num = 1;
                }
            }
        }
    }
}