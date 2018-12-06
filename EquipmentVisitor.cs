namespace VisitorPattern
{
    public abstract class EquipmentVisitor
    {
        protected EquipmentVisitor() {}

        public abstract void VisitChasis(Chasis chasis);
        public abstract void VisitCard(Card card);
        public abstract void VisitFloppyDisck(FloppyDisck floppyDisck);
    }
}