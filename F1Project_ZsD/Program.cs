using System.Diagnostics;
using System.Linq;
using Microsoft.VisualBasic;

string[] inputs = File.ReadAllLines("f1racing.csv");

F1Racing[] racers = new F1Racing[inputs.Length];
for (int i = 0; i < inputs.Length; i++)
{
    racers[i] = new F1Racing(inputs[i]);
}
#region 4. feladat
Console.WriteLine(inputs.Length + " éve rendeznek Forma-1-es versenyeket");
#endregion

#region 6. feladat
Console.Write("Addjon meg egy nevet: ");
string winnerpilotName = Console.ReadLine();
int wins = F1Racing.WinnerPilot(racers, winnerpilotName);
if (wins == 0)
{
    Console.WriteLine("A versenyző sosem nyert szezont!");
}
else
{
    Console.WriteLine($"A versenyző {wins} szezont nyert!");
}
#endregion

#region 7. feladat
List<string> winnerTeam2 = new List<string>();
winnerTeam2.Add(racers[2].winnerteam);
//Ezután meg akartam volna számolni, hogy a melyik elem (csapat) fordul elő a legtöbbször a listában.
#endregion

struct F1Racing
{
    public int seasonnum;
    public string winnerpilot;
    public string winnerteam;
    public int numofraces;
    public int numofracers;
    public int numofteams;

    public F1Racing(string line)
    {
        string[] splitted = line.Split(';');
        this.seasonnum = int.Parse(splitted[0]);
        this.winnerpilot = splitted[1];
        this.winnerteam = splitted[2];
        this.numofraces = int.Parse(splitted[3]);
        this.numofracers = int.Parse(splitted[4]);
        this.numofteams = int.Parse(splitted[5]);
    }

    #region 5. feladat
    public static int WinnerPilot(F1Racing[] racers, string winnerpilotName)
    {
        int wins = 0;
        for (int i = 0; i < racers.Length; i++)
        {
            if (racers[i].winnerpilot == winnerpilotName)
            {
                wins++;
            }
        }

        return wins;
    }
    #endregion
}