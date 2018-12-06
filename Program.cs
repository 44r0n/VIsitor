using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FloppyDisck floppy = new FloppyDisck("Super floppy", 100, 5);
            Card card1 = new Card("Control card",60);
            Card card2 = new Card("Acces card",80);
            Chasis chasis = new Chasis("Black chasis",100,10);
            chasis.Add(floppy);
            chasis.Add(card1);
            chasis.Add(card2);
            PricingVisitor price = new PricingVisitor();
            chasis.Accept(price);
            Console.WriteLine(price.Total);
        }
    }
}
