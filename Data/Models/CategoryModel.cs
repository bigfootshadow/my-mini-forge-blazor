using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MudBlazorWebApp1.Data.Models;

public class CategoryModel
{
    [Key]
    public Guid Id { get; set; }

    public Guid? ParentId { get; set; }
    
    [ForeignKey("ParentId")]
    public CategoryModel? Parent { get; set; }

    public ICollection<CategoryModel> Children { get; set; } = new List<CategoryModel>();
    
    [Required]
    [MaxLength(100)]
    public required string Name { get; set; }
    
    [MaxLength(2048)]
    public string? Description { get; set; }

    public ICollection<ProjectCategoryModel>? ProjectCategories { get; set; }
}