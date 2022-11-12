namespace FrontToBackKarmaDataBase.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CategoryImage { get; set; }
        public List<Product>? Products { get; set; } 

    }
}
