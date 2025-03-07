using Elsa.Common.Entities;
using Elsa.Workflows.Api.Models;
using Elsa.Workflows.Management.Models;

namespace Elsa.Workflows.Api.Endpoints.WorkflowInstances.List;

public class Request
{
    public int? Page { get; set; }
    public int? PageSize { get; set; }
    public string? SearchTerm { get; set; }
    public string? DefinitionId { get; set; }
    public ICollection<string>? DefinitionIds { get; set; }
    public string? CorrelationId { get; set; }
    public string? Name { get; set; }
    public int? Version { get; set; }
    public bool? HasIncidents { get; set; }
    public WorkflowStatus? Status { get; set; }
    public ICollection<WorkflowStatus>? Statuses { get; set; }
    public WorkflowSubStatus? SubStatus { get; set; }
    public ICollection<WorkflowSubStatus>? SubStatuses { get; set; }
    public OrderByWorkflowInstance? OrderBy { get; set; }
    public OrderDirection? OrderDirection { get; set; }
    public ICollection<TimestampFilter>? TimestampFilters { get; set; }
}

internal class Response(ICollection<WorkflowInstanceSummary> items, long totalCount)
{
    public ICollection<WorkflowInstanceSummary> Items { get; set; } = items;
    public long TotalCount { get; set; } = totalCount;
}

