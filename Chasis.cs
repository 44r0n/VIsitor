using System.Collections.Generic;

namespace VisitorPattern
{
    public class Chasis : Equipment
    {
        private List<Equipment> _equipment;
        private readonly decimal discount;
        private readonly decimal price;
        public Chasis(string name, decimal price, decimal discount) : base(name) 
        {
            _equipment = new List<Equipment>();
            this.price = price;
            this.discount = discount;
        }

        public void Add(Equipment element)
        {
            _equipment.Add(element);
        }

        public override void Accept(EquipmentVisitor visitor)
        {
            foreach(var element in _equipment)
            {
                element.Accept(visitor);
            }
            visitor.VisitChasis(this);
        }

        public override decimal DiscountPrice() => price * (1  - discount / 100);

        public override decimal NetPrice() => price;
    }
}