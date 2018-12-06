namespace VisitorPattern
{
    public class FloppyDisck :Equipment
    {
        private readonly decimal price;
        private readonly decimal discount;

        public FloppyDisck(string name, decimal price, decimal discount) : base(name)
        {
            this.price = price;
            this.discount = discount;
        }

        public override void Accept(EquipmentVisitor visitor)
        {
            visitor.VisitFloppyDisck(this);
        }

        public override decimal DiscountPrice() => price * (1 - discount / 100);

        public override decimal NetPrice() => price;
    }
}