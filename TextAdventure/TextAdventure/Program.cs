using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            Console.WriteLine("Willkommen zu einem Textbasiertem Spiel!");
            Console.WriteLine("Hier ist die Auswahl entscheidend, wenn du stirbst ist es GameOver");
            Console.Write("Jetzt drück Enter");
            Console.ReadLine();
            Console.Clear();
            Anfang();
        }

        public static void Anfang()
        {
            Console.WriteLine("Wähle zuerst dein Anfang von der Geschichte aus");
            Console.WriteLine("Möchtest du ein Soldat im Jahre 2077 sein? Dann schreibe: 2077");
            Console.WriteLine("Möchtest du ein 'normaler' Schüler im Jahre 1981 sein? Dann schreibe: 1981");
            Console.WriteLine("Möchtest du ein Elf in einer Fantasie Welt sein? Dann schreibe: Fantasie");
            Console.Write("Deine Wahl ist: ");
            string auswahl = Console.ReadLine();
            Console.Clear();

            switch (auswahl)
            {
                case "2077":
                    Start_2077();
                    break;
                case "1981":
                    Start_1981();
                    break;
                case "Fantasie":
                    Start_Fantasie();
                    break;
                default:
                    Console.WriteLine("Deine Antwort war nicht verständlich");
                    Console.WriteLine();
                    Anfang();
                    break;
            }
        }

        public static void Start_2077()
        {
            Console.WriteLine("Du landest mit deiner Crew auf einen fremden Planeten auf dem Aliens leben");
            Console.WriteLine("Du gehst raus aus dem Raumschiff. Du triffst auf zwei Aliens die mit Waffen auf dich zielen");
            Console.WriteLine("Wirst du sie erschiessen? Dann tippe: Ja");
            Console.WriteLine("Du versuchst ihnen ein 'Wir kommen in Frieden' zu zeigen Dann tippe: Frieden");
            string auswahl = Console.ReadLine();
            Console.Clear();

            if (auswahl == "Ja" || auswahl == "ja" || auswahl == "j" || auswahl == "J")
            {
                Console.WriteLine("Du erschiesst die Beiden Aliens");
                Console.WriteLine("Aber dann kommen ein Haufen von Aliens und umzingelt euch!");
                Console.WriteLine("Die Aliens sind in der Überzahl...");
                Spielvorbei();
            }
            else if (auswahl == "Frieden" || auswahl == "frieden" || auswahl == "f" || auswahl == "F")
            {
                Planet_2077();
            }
            else
            {
                Console.WriteLine("Deine Antwort war nicht verständlich");
                Console.WriteLine();
                Start_2077();
            }
        }

        public static void Start_1981()
        {
            Console.WriteLine("Du gehst zur Schule und gehst zu deiner Geschichtslektion");
            Console.WriteLine("Wie immer bist du in dieser Lektion fast eingeschlafen aber der Lehrer stellt dir eine Frage");
            Console.WriteLine("'Weisst du was heute der 6. Juni im Jahre 1944 passiert ist?'");
            Console.WriteLine("'Die Deutschen greifen England an' sagst du. Dann tippe: Deutsch");
            Console.WriteLine("'Die Allierten landen in der Normandie' sagst du. Dann tippe: Normandie");
            Console.WriteLine("'Ich habe keine Ahnung' sagst du. Dann tippe: Nein");
            string auswahl = Console.ReadLine();

            /*switch (auswahl)
            {
                case "Deutsch":
                case "deutsch":
                case "d":
                    Console.WriteLine("Falsch, ")

            }*/
        }

        public static void Start_Fantasie()
        {

        }

        public static void Planet_2077()
        {
            Console.WriteLine("Die Aliens bringen euch zum Herrscher und der gibt euch wertvolle Mineralien");
            Console.WriteLine("Ihr fliegt zurück zu der Citadel und du gibt das wertvolle Mineral eurem Rat");
            
            string[] entscheidungen = {"Der Rat gibt euch eine neue Aufgabe", "Du gehts zurück zur Basis um kurz zu schlafen",
                                       "Du gehst mit deiner Crew kurz etwas trinken"};
            string text = entscheidungen[rnd.Next(3)];

            Console.WriteLine(text);
            Console.WriteLine("Plötzlich landet ein riesiges Alienschiff auf der Citadel");
            Console.WriteLine("Wirst du helfen gegen dieses Alienschiff zu kämpfen? Tippe: Ja, Wenn nicht tippe: Nein");
            string auswahl = Console.ReadLine();

            if (auswahl == "Ja" || auswahl == "ja" || auswahl == "j")
            {
                Console.WriteLine("Du rettest alle Bewohner auf der Citadel");
                Console.WriteLine("Du wirst als Held gefeiert");
                Spielgewonnen();
            }
            else if (auswahl == "Nein" || auswahl == "nein" || auswahl == "n")
            {
                Console.WriteLine("Du flüchtest mit deiner Crew");
                Console.WriteLine("Aber als dein Raumschiff versucht einen Abflug zu machen wird dir von einem Laserstrahl getroffen");
                Spielvorbei();
            }
            else
            {
                Console.WriteLine("Deine Antwort war nicht verständlich");
                Console.WriteLine();
                Planet_2077();
            }
        }

        public static void Spielvorbei()
        {
            Console.WriteLine("Leider bist du gestorben also GameOver");
            Console.Write("Um das Spiel neuzustarten, drück Enter ");
            Console.ReadLine();
            Start();
        }

        public static void Spielgewonnen()
        {
            Console.WriteLine("Du hast das Spiel gewonnen!");
            Console.Write("Um das Spiel neuzustarten, drück Enter ");
            Console.ReadLine();
            Console.Clear();
            Start();
        }
    }
}
