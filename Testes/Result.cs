using System.Text;

public class Result
{

    /*
     * Complete the 'howManyGames' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER p
     *  2. INTEGER d
     *  3. INTEGER m
     *  4. INTEGER s
     */

    public static int howManyGames(int p, int d, int m, int s)
    {
        // Return the number of games you can buy
        //Valida se possui pelo menos credito de um jogo
        if (s > 10000 || s < 1 || d > 100 || d < 1 || m > p || m < 1 || p > 100 || s < p || s < m)
        {
            return 0;
        }

        int r = 0;
        //enquanto o o saldo for maior que o valor minimo de cada jogo
        while (s >= m)
        {
            //Subtrai o valor do jogo nos creditos  
            s -= p;
            p -= d;
            //Caso o jogo fique menor a m
            if (p <= m)
            {
                p = m;
            }

            r++;
        };
        return r;
    }


    public static long repeatedString(string s, long n)
    {

        long r = s.Where(x => x.ToString() == "a").Count();//Pega a quantidade de 'a' dentro da string de entrada
        long c = n / s.Length; //Divide para chegar proximo do valor que existe dentro de N
        long d = c * s.Length; //pega a quantidade inteira maxima de s que cabe em N
        long a = c * r; //pega a quantidade de 'a' dentro de N 
        long f = n - a;// pega o resto se caso houver

        for (int i = 0; d < n; i++)
        {
            if (s[i] == 'a')
            {
                a++;
            }
            d++;
        }

        return a;
    }

    public static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
        var cont = new List<int>();

        foreach (var a1 in keyboards.OrderByDescending(x => x).ToArray())
        {
            foreach (var a2 in drives.OrderByDescending(x => x).ToArray())
            {
                if ((a2 + a1) <= b) // Inclui em uma lista todas as somas sendo menor que o orcamento
                {
                    cont.Add(a2 + a1);
                }
            }

        }
        if (!cont.Any()) // Caso nao houver nenhum valor de calculo
        {
            return -1;
        }
        cont.Sort();
        int max = cont.Last();//pega o maior valor do orcamento
        if (max <= b)
        {
            return max;
        }

        return -1;
    }

    public static string timeConversion(string s)
    {
        var time = DateTime.Parse(s);

        return time.ToString("HH:mm:ss");
    }

    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        if (v2 > v1)
        {
            return "NO";
        }

        //int p1 = x1;
        //int p2 = x2;
        //int c1 = v1;
        //int c2 = v2;

        //if (x1 < x2)
        //{
        //    p1 = x2;
        //    p2 = x1;
        //    c1 = v2;
        //    c2 = v1;
        //}

        while (x1 < x2)
        {
            x1 += v1;
            x2 += v2;

            if (x2 == x1)
                return "YES";
        }

        return "NO";
    }

    public static int countFamilyLogins(List<string> logins)
    {
        int r = 0;
        for (int i = 0; i < logins.Count(); i++)
        {
            string aux = "";

            foreach (var c in logins[i])
            {
                var pc = Enumerable.Range('a', 'z').Where(x => x == c).FirstOrDefault();
                pc++;
                if (c == 122)
                {
                    pc = 97;
                }

                aux = aux + (char)pc;
            }
            r += logins.Count(x => x == aux);
        }

        return r;
    }

    public static long findTotalImbalance(List<int> rank)
    {
        rank.Sort();
        int r = 0;
        for (int i = 0; i < rank.Count(); i++)
        {
            for (int j = 0; j < rank.Count(); j++)
            {
                if ((rank[i] - rank[j]) > 1)
                {
                    r++;
                }
                if ((rank[i] - rank[j]) < 1) break;
            }
        }

        return r;
    }
}

public class Team
{
    public Team(string TeamName, int NoOfPlayers)
    {
        teamName = TeamName;
        noOfPlayers = NoOfPlayers;
    }

    public string teamName { get; set; }
    public int noOfPlayers { get; set; }

    public void AddPlayer(int count)
    {
        noOfPlayers += count;
    }

    public bool RemovePlayer(int count)
    {
        noOfPlayers -= count;

        if (noOfPlayers < 0) return false;

        return true;
    }

    /////////////
    ///

}

public class NotesStore
{
    public NotesStore() { }

    public List<Notes> notes { get; set; } = new List<Notes>();
    string[] states = new string[] { "completed", "active", "others" };

    public void AddNote(String state, String name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Name cannot be empty");
        }

        if (!states.Contains(state.ToLower()))
        {
            throw new Exception($"Invalid state {state}");
        }

        notes.Add(new Notes { Name = name, State = state });
    }
    public List<String> GetNotes(String state)
    {

        if (!states.Contains(state.ToLower()))
        {
            throw new Exception($"Invalid state {state}");
        }

        List<String> note = notes.Where(x => x.State.ToLower() == state.ToLower()).ToList().Select(x => x.Name).ToList();
        return note;
    }
}
public class Notes
{
    public String State { get; set; }
    public String Name { get; set; }
}




public class Subteam : Team
{
    public Subteam(string TeamName, int NoOfPlayers) : base(TeamName, NoOfPlayers)
    {

    }

    public void ChangeTeamName(string name)
    {
        teamName = name;
    }

}

public class Solution
{
    public void Main()
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        //int p = Convert.ToInt32(firstMultipleInput[0]);

        //int d = Convert.ToInt32(firstMultipleInput[1]);

        //int m = Convert.ToInt32(firstMultipleInput[2]);

        //int s = Convert.ToInt32(firstMultipleInput[3]);

        //int answer = Result.howManyGames(20, 3, 6, 80);
        //Console.WriteLine(answer);
        //answer = Result.howManyGames(20, 3, 6, 85);
        //Console.WriteLine(answer);

        //long answer = Result.repeatedString("a", 100000000000);
        //Console.WriteLine(answer);
        //answer = Result.repeatedString("aba", 10);
        //Console.WriteLine(answer);

        //int[] a = new int[] { 3, 1 };
        //int[] b = new int[] { 5, 2, 8 };
        //int c = 10;
        //int answer = Result.getMoneySpent(a, b, c);
        //Console.WriteLine(answer);
        //a = new int[] { 5 };
        //b = new int[] { 4 };
        //c = 5;
        //answer = Result.getMoneySpent(a, b, c);
        //Console.WriteLine(answer);
        //string s = "07:05:45AM";
        //string result = Result.timeConversion(s);
        //Console.WriteLine(result);

        //string result = Result.kangaroo(0, 3, 4, 2);
        //Console.WriteLine(result);

        //result = Result.kangaroo(0, 2, 5, 3);
        //Console.WriteLine(result);
        //textWriter.WriteLine(answer);

        //textWriter.Flush();
        //textWriter.Close();

        //var teste = new NotesStore();
        //teste.AddNote("active", "DrinkTea");
        //teste.AddNote("active", "DrinkCoffee");
        //teste.AddNote("completed", "Study");

        //teste.GetNotes("active");
        //teste.GetNotes("completed");
        //teste.GetNotes("foo");

        //string[] teste = new string[] { "bag", "sfe", "cbh", "cbh", "red" };

        //long answer = Result.countFamilyLogins(teste.ToList());
        //Console.WriteLine(answer);

        //teste = new string[] { "corn", "horn", "dpso", "eqtp", "corn" };

        //answer = Result.countFamilyLogins(teste.ToList());
        //Console.WriteLine(answer);

        //teste = new string[] { "cbu", "bat", "cbu"};

        //answer = Result.countFamilyLogins(teste.ToList());
        //Console.WriteLine(answer);

        int[] teste = new int[] { 1, 4, 5 };

        long answer = Result.findTotalImbalance(teste.ToList());
        Console.WriteLine(answer);

        teste = new int[] { 4, 1, 3, 2 };

        answer = Result.findTotalImbalance(teste.ToList());
        Console.WriteLine(answer);


        teste = new int[] { 4, 1, 3, 2,6,8,10,98,5 };

        answer = Result.findTotalImbalance(teste.ToList());
        Console.WriteLine(answer);



    }

}
