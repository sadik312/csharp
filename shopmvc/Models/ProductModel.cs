using Microsoft.EntityFrameworkCore;

namespace shopmvc.Models; // new v of C# allows to omit `{}` from namespace  
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
    public int Qty { get; set; }
}