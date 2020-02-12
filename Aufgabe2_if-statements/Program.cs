using System;

namespace Aufgabe2_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Erstelle eine Anwendung mit einem Score, Highscore und einem HighscorePlayer.

Erstelle eine Methode, die zwei Parameter hat, einen für die Punktzahl und einen für den Spielernamen.

Wann immer diese Methode aufgerufen wird, sollte überprüft werden, ob die Punktzahl des Spielers höher ist als die des Highscores, wenn ja, "Neuer highscore ist + " score" und 
in einer anderen Zeile "Neuer Rekordhalter ist " + playerName - auf die Konsole geschrieben werden, falls nicht "Der alte highscore von " + highscore + " konnte nicht gebrochen werden und wird immer noch gehalten von " + highscorePlayer.
Überlege auch, welche Variablen außerhalb der Methoden und welche innerhalb der Methoden benötigt werden.*/
            Console.WriteLine("Bitte trage deinen Score ein:");
            string ScoreAsString = Console.ReadLine();
            int scoreinput = int.Parse(ScoreAsString);
            //int currentHighscore = 2000;
            Console.WriteLine("Bitte trage deinen Namen ein:");
            string player = Console.ReadLine();

            CheckHighscore(scoreinput, player);

            

        }
        public static void CheckHighscore(int score, string player)
        {
            int highscore = 2000;
            string highscorePlayer = "Hans";

            if (score <= highscore)
            {
                Console.WriteLine("Der alte Highscore von {0} konnte nicht gebrochen werden und wird immer noch gehalten von {1}", highscore, highscorePlayer);
            }
            else if (score > highscore)
            {
                Console.WriteLine("Neuer Rekord ist: {0}", score);
                Console.WriteLine("Neuer Rekordhalter ist: {0}", player);
            }

        }
    }
}
