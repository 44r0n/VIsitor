namespace VisitorPattern
{
    public class Card : Equipment
    {
        private readonly decimal price;
        public Card(string name, decimal price) : base(name)
        {
            this.price = price;   
        }

        public override void Accept(EquipmentVisitor visitor)
        {
            visitor.VisitCard(this);
        }

        public override decimal DiscountPrice() => price;

        public override decimal NetPrice() => price;
    }
}