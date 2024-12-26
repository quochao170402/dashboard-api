using System;

namespace Project.API.Common;

public interface IEntity
{
    public Guid Id { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime LatestUpdatedAt { get; set; }
    public Guid LatestUpdatedBy { get; set; }
}

public class Entity : IEntity
{
    public Guid Id { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public Guid CreatedBy { get; set; }
    public DateTime LatestUpdatedAt { get; set; } = DateTime.Now;
    public Guid LatestUpdatedBy { get; set; }
}
