using System.Net;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Project.API.Controllers.Base;
using Project.API.Controllers.Payload;
using Project.API.Services;

namespace Project.API.Controllers.Version1;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]/[action]")]
[ApiController]
public class ProjectController(IProjectService projectService) : BaseApiController
{
    [HttpGet("{projectId:guid}")]
    public async Task<IActionResult> GetById([FromRoute] Guid projectId)
    {
        var project = await projectService.GetById(projectId);
        return OkResponse(project);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await projectService.GetAll();

        return OkResponse(response);
    }

    [HttpGet]
    public async Task<IActionResult> Filter(string? keyword, int pageSize = 10, int pageIndex = 1)
    {
        var response = await projectService.Get(keyword, pageSize, pageIndex);

        return OkResponse(new
        {
            Data = response.projects,
            Count = response.count
        });
    }

    [HttpPost]
    public async Task<IActionResult> AddProject([FromBody] AddProjectRequest request)
    {
        var response = await projectService.Add(request);
        return OkResponse(response, (int)HttpStatusCode.Created);
    }

    [HttpPut("{projectId:guid}")]
    public async Task<IActionResult> UpdateProject([FromRoute] Guid projectId, [FromBody] UpdateProjectRequest request)
    {
        var response = await projectService.Update(projectId, request);
        return OkResponse(response);
    }

    [HttpDelete("{projectId:guid}")]
    public async Task<IActionResult> DeleteProject([FromRoute] Guid projectId)
    {
        var response = await projectService.Delete(projectId);
        return OkResponse(response);
    }
}
