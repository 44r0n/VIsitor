namespace VisitorPattern
{
    public class PricingVisitor : EquipmentVisitor
    {
        private decimal total;
        public PricingVisitor()
            :base()
        {
            total = 0;
        }

        public override void VisitFloppyDisck(FloppyDisck floppyDisck) 
        {
            total += floppyDisck.DiscountPrice();
        }

        public override void VisitCard(Card card)
        {
            total += card.NetPrice();
        }

        public override void VisitChasis(Chasis chasis)
        {
            total += chasis.DiscountPrice();
        }

        public decimal Total
        {
            get => total;
        }
    }
}