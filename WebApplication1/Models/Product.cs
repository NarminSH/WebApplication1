using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Product
{
    public Product()
    {
        this.ProductPhotos = new HashSet<ProductPhoto>();
    }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal StartPrice { get; set; }
    public decimal Price { get; set; }
    public double Rate { get; set; }
    public virtual ICollection<ProductPhoto> ProductPhotos { get; set; }
}


