using System.ComponentModel.DataAnnotations;

namespace MyMiniForge.Data.Models;

public class ProjectModel
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(255)]
    public string? Name { get; set; }

    [MaxLength(2048)]
    public string? Description { get; set; }

    [MaxLength(255)]
    public string? Tags { get; set; }

    [MaxLength(255)]
    public string? Preview { get; set; }

    public ICollection<ProjectCategoryModel>? ProjectCategories { get; set; }
}