/*
 Uppgift: Hantera en inköpslista
1. Skapa en klass Inköpslista som innehåller en lista av produkter (List<string>
produkter).
2. Skapa en metod LäggTillProdukt som tar emot en produkt och lägger till den
i listan.
3. Skapa en metod TaBortProdukt som tar emot en produkt och tar bort den
från listan om den finns.
4. Skapa en metod SkrivUtInköpslista som skriver ut alla produkter i
inköpslistan.
 */
namespace classExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inköpslista inköpslista = new Inköpslista();

            inköpslista.Addproduct("Banan");
            inköpslista.Addproduct("Mjölk");
            inköpslista.Addproduct("Äpple");
            inköpslista.Addproduct("Fil");
            inköpslista.Addproduct("Kvarg");
            inköpslista.Addproduct("Chips");

            inköpslista.Showproducts();
        }
        class Inköpslista
        {
            List<string> productList = new List<string>();//the list

            public void Addproduct(string productName)
            {
                productList.Add(productName);
            }

            public void Removeproduct(string productName)
            {
                productList.Remove(productName);
            }

            public void Showproducts()
            {
                Console.WriteLine("Inköpslista:");
                foreach (string product in productList)
                {
                    Console.WriteLine(product);
                }
            }
        }
    }
}
