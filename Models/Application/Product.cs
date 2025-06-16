namespace gigabyte_homework.Models.Application
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Image> Images { get; set; } = new List<Image>();
        public ICollection<Specification> Specifications { get; set; } = new List<Specification>();
        public ICollection<News> RelatedNews { get; set; } = new List<News>();
        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
    }
}
