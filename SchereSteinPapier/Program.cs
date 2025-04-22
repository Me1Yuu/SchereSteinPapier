//AUFGABE 1
//Programmiere ein Schere, Stein, Papier Spiel. 
//Der User soll eines der Handzeichen wählen können.
//Der Computer wählt per Zufall ein eigenes Zeichen.
//(Recherchiere hierzu Random für C#)
//Dem User wird dann ausgegeben, welches Zeichen der Computer gewählt hat und ob man gewonnen,
//verloren oder ein Unentschieden hat.
//Danach kann sich der User entscheiden eine weitere Runde zu spielen, oder nicht.



string[] rivalen = {"Linda", "Neo", "Märchen", "Jaguar", "Molli", "Stein", "Alpha", "Momo", "Rabauke", "Susanne", "Mars", "Alphabet", "Lotte", "Papagei", "Gundaf", "Renold", "Luke", "Amsel", "Dirt", "Pirat"};

bool nochmal = true;

while (nochmal)
{
    Console.WriteLine("SCHERE\tSTEIN\tPAPIER");
    Console.WriteLine();
    string einfuegen = Console.ReadLine();

    Random random = new Random(); //Hier wähle ich die Namen aus, die die Konsole dann ausspucken soll.
    int index = random.Next(rivalen.Length); //random.Next das eine Zufallszahl ausgibt.
    //rivalen.Length gibt die Menge des strings an.
    string namen = rivalen[index];
    string[] optionen = { "SCHERE", "STEIN", "PAPIER" }; //Hier spukt dann die Konsole den Namen aus und die Wahl
    string auswahl = optionen[random.Next(optionen.Length)]; //string option wählt das zufällige Element und speichert diese in der string auswahl
    //generiert die Zufallszahl und wählt diese dann aus
    Console.WriteLine();
    Console.WriteLine($"{namen} hat {auswahl} genommen.");

    if (einfuegen == auswahl)
    {
        Console.WriteLine();
        Console.WriteLine("Unentschieden!");
    }
    else if (
        (einfuegen == "SCHERE" && auswahl == "PAPIER") ||
        (einfuegen == "STEIN" && auswahl == "SCHERE") ||
        (einfuegen == "PAPIER" && auswahl == "STEIN")
        )
    {
        Console.WriteLine();
        Console.WriteLine($"Du hast LOYAL und ERWÜRDIG gegen {namen} GEWONNEN!");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"{namen} hat einen CHEAT verwendet und dich damit geschlagen! VERLOREN!");
    }
    Console.WriteLine();
    Console.WriteLine("Nochmal? (j) für Ja oder (n) für Nein.");
    string antwort = Console.ReadLine().ToLower();
    Console.WriteLine();
    if (antwort != "j")
    {
        nochmal = false;
    }
}





//LÖSUNG von Fabian
//string userWahl;
//Random rnd = new Random();
//int computerWahl;
//bool continueGame;

//do
//{
//    continueGame = false;
//    Console.Clear();
//    Console.WriteLine("Hallo User!\nWähle PAPIER, STEIN oder SCHERE.");
//    userWahl = Console.ReadLine().ToLower();
//    computerWahl = rnd.Next(1, 4);

//    if (userWahl == "papier" || userWahl == "stein" || userWahl.Equals("schere"))
//    {
//        if (computerWahl == 1)
//        {
//            Console.WriteLine("\nDer Computer hat PAPIER gewählt.");
//            if (userWahl.Equals("schere"))
//            {
//                Console.WriteLine("Du hast gewonenn!");
//            }
//            else if (userWahl.Equals("stein"))
//            {
//                Console.WriteLine("Du hast verloren.");
//            }
//            else
//            {
//                Console.WriteLine("Das ist ein Unentschieden");
//            }
//        }
//        else if (computerWahl == 2)
//        {
//            Console.WriteLine("Der Computer hat STEIN gewählt");
//            if (userWahl.Equals("papier"))
//            {
//                Console.WriteLine("Du hast gewonenn!");
//            }
//            else if (userWahl.Equals("schere"))
//            {
//                Console.WriteLine("Du hast verloren.");
//            }
//            else
//            {
//                Console.WriteLine("Das ist ein Unentschieden");
//            }
//        }
//        else if (computerWahl == 3)
//        {
//            Console.WriteLine("Der Computer hat SCHERE gewählt");
//            if (userWahl.Equals("stein"))
//            {
//                Console.WriteLine("Du hast gewonenn!");
//            }
//            else if (userWahl.Equals("papier"))
//            {
//                Console.WriteLine("Du hast verloren.");
//            }
//            else
//            {
//                Console.WriteLine("Das ist ein Unentschieden");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Entschuldige... Der Computer konnte sich wohl nicht entscheiden.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Unzulässige Eingabe. Es muss PAPIER, STEIN oder SCHERE gewählt werden!!");
//    }
//    Console.WriteLine("\nMöchtest du noch eine weitere Runde spielen? J/N");
//    string eingabe = Console.ReadLine().ToLower();
//    if (eingabe.Equals("j"))
//    {
//        continueGame = true;
//    }
//    else
//    {
//        Console.WriteLine("\nVielen Dank fürs spielen! Bis zum nächsten Mal. Drücke any key um zu beenden!");
//    }
//}
//while (continueGame);