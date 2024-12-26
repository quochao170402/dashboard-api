using Project.API.Enums;

namespace Project.API.Models;

public class ProjectModel
{
    public Guid Id { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public Guid CreatedBy { get; set; }
    public DateTime LatestUpdatedAt { get; set; } = DateTime.Now;
    public Guid LatestUpdatedBy { get; set; }
    public string Name { get; set; }
    public string Key { get; set; }
    public string Description { get; set; } = string.Empty;
    public ProjectStatus Status { get; set; } = ProjectStatus.NotStarted;
    public Guid LeaderId { get; set; } = Guid.Empty;
    public string Url { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
