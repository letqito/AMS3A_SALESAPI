namespace AMS3A.Sales.Domain
{
    public class Category
    {
        public Guid Id{get;set;} = Guid.NewGuid();
        public string? Description{get;set;}
        public bool IsActive{get;set;}
        public string? ImageUrl{get;set;}

        public ICollection<Product> Products{get;set;} //lista de produtos


    
    }
}