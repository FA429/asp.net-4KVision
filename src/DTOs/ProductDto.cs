namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs
{
    public class ProductCreateDto
    {
        public Guid CategoryId { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? Image { get; set; }
        public string? Background { get; set; }

        public string Description { get; set; }
        public int Quantity { get; set; }



    }

    public class ProductReadDto
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? Image { get; set; }
        public string? Background { get; set; }

        public string Description { get; set; }
        public int Quantity { get; set; }



    }
    public class ProductUpdateDto
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string? Image { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }



    }
    //TODO: implement READdtO
}