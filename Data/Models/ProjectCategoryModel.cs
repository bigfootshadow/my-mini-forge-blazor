using Microsoft.Build.Framework;

namespace MyMiniForge.Data.Models;

public class ProjectCategoryModel
{
    [Required]
    public Guid ProjectId { get; set; }
    [Required]
    public ProjectModel Project { get; set; }

    [Required]
    public Guid CategoryId { get; set; }
    [Required]
    public CategoryModel Category { get; set; }
}