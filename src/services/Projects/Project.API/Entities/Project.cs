using Project.API.Common;
using Project.API.Enums;

namespace Project.API.Entities;

public class Project : Entity
{
    public string Name { get; set; }
    public string Key { get; set; }
    public string Description { get; set; } = string.Empty;
    public ProjectStatus Status { get; set; } = ProjectStatus.NotStarted;
    public Guid LeaderId { get; set; } = Guid.Empty;
    public string Url { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}