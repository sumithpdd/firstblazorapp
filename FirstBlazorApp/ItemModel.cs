namespace FirstBlazorApp
{
    public class ItemModel
    {
        public string ItemId { get; set; }
        public double AskingPrice { get; set; }
        public double Units { get; set; }
        public double Total => Units * AskingPrice;


    }
}
