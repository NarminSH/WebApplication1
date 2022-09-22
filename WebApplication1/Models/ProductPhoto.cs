using System;

public class ProductPhoto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    public string Url { get; set; }
}


