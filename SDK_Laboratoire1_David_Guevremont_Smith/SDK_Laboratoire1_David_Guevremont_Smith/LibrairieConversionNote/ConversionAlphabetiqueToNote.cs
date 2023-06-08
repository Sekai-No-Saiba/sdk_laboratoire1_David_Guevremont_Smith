namespace LibrairieConversionNote
{
    public class ConversionAlphabetiqueToNote
    {
        public string Transformer(string lettre)
        {
            string note = "";

            switch (lettre.ToUpper())
            {
                case "A":
                    note = "DO";
                    break;
                case "B":
                    note = "RÉ";
                    break;
                case "C":
                    note = "MI";
                    break;
                case "D":
                    note = "FA";
                    break;
                case "E":
                    note = "SOL";
                    break;
                case "F":
                    note = "LA";
                    break;
                case "G":
                    note = "SI";
                    break;
                default:
                    // Cas où la lettre n'est pas valide
                    note = "Note non disponible";
                    break;
            }

            return note;
        }



    }
}