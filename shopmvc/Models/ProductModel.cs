using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace shopmvc.Models; // new v of C# allows to omit `{}` from namespace  
public class Product
{
    [Key]
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal ProductCost { get; set; }
    public int ProductQTY { get; set; }
}