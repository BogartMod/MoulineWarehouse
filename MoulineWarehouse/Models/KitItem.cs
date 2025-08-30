namespace MoulineWarehouse.Models
{
    public class KitItem
    {
        public int Id { get; set; }

        public int KitId { get; set; }
        public Kit Kit { get; set; }

        public int ThreadColorId { get; set; }
        public ThreadColor ThreadColor { get; set; }

        // Сколько нужно для набора (в миллиметрах)
        public int QuantityMm { get; set; }
        public decimal QuantityM => QuantityMm/1000m;
    }
}
