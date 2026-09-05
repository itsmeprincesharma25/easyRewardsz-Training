using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class IplMatch
{
    public int match_id { get; set; }
    public string team1 { get; set; } = "";
    public string team2 { get; set; } = "";
    public int score_team1 { get; set; }
    public int score_team2 { get; set; }
    public string winner { get; set; } = "";
    public string player_of_match { get; set; } = "";
}

class IplCensorshipAnalyzer
{
    private string MaskTeamName(string team)
    {
        string[] words = team.Split(' ');

        if (words.Length == 2)
        {
            return words[0] + " ***";
        }

        if (words.Length >= 3)
        {
            return words[0] + " *** " +
                   string.Join(" ",
                       words, 2, words.Length - 2);
        }

        return "***";
    }

    private void Censor(IplMatch match)
    {
        match.team1 = MaskTeamName(match.team1);
        match.team2 = MaskTeamName(match.team2);
        match.winner = MaskTeamName(match.winner);
        match.player_of_match = "REDACTED";
    }

    public void Run()
    {
        List<IplMatch> matches =
            new List<IplMatch>
        {
            new IplMatch
            {
                match_id = 101,
                team1 = "Mumbai Indians",
                team2 = "Chennai Super Kings",
                score_team1 = 178,
                score_team2 = 182,
                winner = "Chennai Super Kings",
                player_of_match = "MS Dhoni"
            },

            new IplMatch
            {
                match_id = 102,
                team1 = "Royal Challengers Bangalore",
                team2 = "Delhi Capitals",
                score_team1 = 200,
                score_team2 = 190,
                winner = "Royal Challengers Bangalore",
                player_of_match = "Virat Kohli"
            }
        };

        foreach (IplMatch match in matches)
        {
            Censor(match);
        }

        string json = JsonConvert.SerializeObject(
            matches, Formatting.Indented);

        File.WriteAllText(
            "TestFiles/censored_ipl.json", json);

        List<string> csv = new List<string>
        {
            "match_id,team1,team2,score_team1,score_team2,winner,player_of_match"
        };

        foreach (IplMatch match in matches)
        {
            csv.Add(
                $"{match.match_id},{match.team1},{match.team2}," +
                $"{match.score_team1},{match.score_team2}," +
                $"{match.winner},{match.player_of_match}");
        }

        File.WriteAllLines(
            "TestFiles/censored_ipl.csv", csv);

        Console.WriteLine("Censored JSON created.");
        Console.WriteLine("Censored CSV created.");

        Console.WriteLine("\nCensored Data:");

        foreach (IplMatch match in matches)
        {
            Console.WriteLine(
                $"{match.match_id} | " +
                $"{match.team1} | " +
                $"{match.team2} | " +
                $"{match.winner} | " +
                $"{match.player_of_match}");
        }
    }
}