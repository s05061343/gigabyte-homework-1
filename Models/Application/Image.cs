namespace gigabyte_homework.Models.Application
{
    public class Image
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImageName { get; set; }
        public string ImageDescription { get; set; }
        public byte[] Blob { get; set; }
    }
}
