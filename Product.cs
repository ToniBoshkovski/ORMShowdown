namespace ORMShowdown
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Guid Code { get; set; }
        public int Amount { get; set; }
    }
}