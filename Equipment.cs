namespace VisitorPattern
{
    public abstract class Equipment
    {
        public readonly string Name;

        public abstract decimal NetPrice();
        public abstract decimal DiscountPrice();

        public abstract void Accept(EquipmentVisitor visitor);

        protected Equipment(string name) { this.Name = name;}
    }
}