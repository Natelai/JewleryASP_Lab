namespace Domain.Entities
{
    public class Material : BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public virtual List<Good> Goods { get; set; }
    }
}
