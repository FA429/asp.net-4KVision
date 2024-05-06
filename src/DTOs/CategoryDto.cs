
namespace sda_nsite_2_csharp_backend_teamwork.src.DTOs
{ }
public class CategoryCreateDto
{
    public string Type { get; set; }
}
public class CategoryReadDto
{
    public Guid Id { get; set; }
    public string Type { get; set; }
}
public class CategoryUpdateDto
{
    public string Type { get; set; }
}

