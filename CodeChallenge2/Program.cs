namespace CodeChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ingredients = new List<string>();

            ingredients.Add("200 g Hvedemel (ca. 3½ dl)");
            ingredients.Add("2 teskefuld Bagepulver");
            ingredients.Add("½ teskefuld Fint Salt");
            ingredients.Add("2 Æg");
            ingredients.Add("150g Sukker (ca. 1,75 dl)");
            ingredients.Add("1 teskefuld Vaniljesukker");
            ingredients.Add("125g Smeltet Smør");
            ingredients.Add("2 Modne Bananer");
            ingredients.Add("100g Mørk Chokolade");

            Console.WriteLine("Banankage!!\n");

            foreach (string ingredient in ingredients)
            {
                Console.WriteLine(ingredient);
            }
        }
    }
}
