namespace gigabyte_homework.Models.Application
{
    public class Tag
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string TagName { get; set; }
        public string TagDescription { get; set; }
    }
}
