using System;
using LibrairieConversionNote; // Importer l'espace de noms

class Program
{
    static void Main()
    {
        ConversionAlphabetiqueToNote convertisseur = new ConversionAlphabetiqueToNote(); // Instancier un objet

        Console.WriteLine("Veuillez entrer une note de musique (A à G) :");
        string note = Console.ReadLine();

        // Vérifier si la note est valide
        if (note.Length == 1 && note.ToUpper()[0] >= 'A' && note.ToUpper()[0] <= 'G')
        {
            string noteTransformee = convertisseur.Transformer(note.ToUpper()); // Appeler la méthode à partir de l'objet
            Console.WriteLine("La note {0} correspond à {1}.", note.ToUpper(), noteTransformee);
        }
        else
        {
            Console.WriteLine("Note invalide. Veuillez entrer une note entre A et G.");
        }
    }
}
