namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs
{
    public class ProductCreateDto
    {
        public Guid CategoryId { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }

    }

    public class ProductReadDto
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
    }
    public class ProductUpdateDto
    {
        public Guid CategoryId { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
    }
    //TODO: implement READdtO
}