namespace MoulineWarehouse.Models
{
    public class StockItem
    {
        public int Id { get; set; }
        public int ThreadColorId { get; set; }
        public ThreadColor? ThreadColor { get; set; }
        public int Quantity { get; set; }
        public int ReservedQuantity { get; set; }
    }
}
