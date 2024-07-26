namespace Lab_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the restocking tool.");
            
            // stock values
            int Soda = 100;
            int Chips = 40;
            int Candy = 60;

            // restock values
            int SodaRestock = 40;
            int ChipsRestock = 20;
            int CandyRestock = 40;

            // Calculate the # of items purchased
            Console.Write("How many sodas have been sold today? 100 are in stock ");
            int SodaPurchased = int.Parse(Console.ReadLine());
            if (SodaPurchased <= Soda)
            {
                Soda -= SodaPurchased;
            }
            else // else statement if certain conditions aren't met
            {
                Console.WriteLine("Error. Purchased amount exceeds current stock total.");
            }
                        Console.WriteLine("Remaining Soda: " + Soda);

            Console.Write("How many chips have been sold today? 40 are in stock ");
            int ChipsPurchased = int.Parse(Console.ReadLine());
            if (ChipsPurchased <= Chips)
            {
                Chips -= ChipsPurchased;
            }
            else
            {
                Console.WriteLine("Error. Purchased amount exceeds current stock total.");
            }
            Console.WriteLine("Remaining Chips: " + Chips);

            Console.Write("How much candy has been sold today? 60 are in stock ");
            int CandyPurchased = int.Parse(Console.ReadLine());
            if (CandyPurchased <= Candy)
            {
                Candy -= CandyPurchased;
            }
            else
            {
                Console.WriteLine("Error. Purchased amount exceeds current stock total.");
            }
            Console.WriteLine("Remaining Candy: " + Candy);
            Console.WriteLine(" ");

            // Calculate remaining stock
            Soda -= SodaPurchased;
            Chips -= ChipsPurchased;
            Candy -= CandyPurchased;

            Console.WriteLine("Thank you. Please restock:");



            // is restock needed?
            if(Soda <= SodaRestock) 
            {
                Console.WriteLine("Soda"); 
            }
            if(Chips <= ChipsRestock)
            {
                Console.WriteLine("Chips");
            }
           if(Candy <= ChipsRestock)
            {
                Console.WriteLine("Candy");
            }            
        }
    }
}
