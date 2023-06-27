using System.Numerics;

namespace lanchonete_55.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set;}
    }

    public enum Category
    {
        MainCourses,
        SideDishes,
        Beverages,
        Desserts
    }
}
