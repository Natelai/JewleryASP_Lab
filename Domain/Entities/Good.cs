namespace Domain.Entities
{
    public class Good : BaseEntity
    {
        public string Name { get; set; }
        public double Size { get; set; }
        public int Price { get; set; }
        public int MaterialId { get; set; }
        public virtual Material Material { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
