string[] inputs = File.ReadAllLines("f1racing.csv");

F1Racing[] racers = new F1Racing[inputs.Length];
for (int i = 0; i < inputs.Length; i++)
{
    racers[i] = new F1Racing(inputs[i]);
}
#region 4. feladat
Console.WriteLine(inputs.Length + " éve rendeznek Forma-1-es versenyeket");
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
}
