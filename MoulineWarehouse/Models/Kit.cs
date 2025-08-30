namespace MoulineWarehouse.Models
{
    public class Kit
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        // Цена готового набора
        public decimal Price { get; set; }

        // Сколько наборов реально собрано на складе
        public int InStock { get; set; }

        // Сколько запланировано (например, клиент заказал, надо собрать)
        public int Planned { get; set; }

        public List<KitItem> Items { get; set; }
    }
}
