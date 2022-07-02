public class OrderModel
{
    public string? ItemId { get; set; }
    public double UnitPrice { get; set; }  
    public int Units { get; set; } 
    public double Total => Units * UnitPrice;
    public string ShippingAddress { get; set; }  
    public string Details { get; set; } 
    
}