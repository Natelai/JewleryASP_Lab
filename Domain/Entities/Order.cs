namespace Domain.Entities
{
    public class Order : BaseEntity
    {
        public int ClientId { get; set; }
        public int GoodId { get; set; }
        public double Total { get; set; }
        public DateTime OrderTime { get; set; }
        public virtual Client Client { get; set; }
        public virtual Good Good { get; set; }
    }
}
