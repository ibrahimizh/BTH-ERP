
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

public class CreateWorkOrderTaskVM:WorkOrderTaskView
{
    public CreateWorkOrderTaskVM()
    {
        this.Employees = new List<SelectListItem>();
    }
    public IEnumerable<SelectListItem> Employees { get; set; }
}

public class PostWorkOrderTask{
    public int WorkOrderId { get; set; }
    public int EmployeeId { get; set; }
    public string Description { get; set; }
    public DateTime TargetDate { get; set; }
    public int WorkOrderItemId { get; set; }
}

public class WorkOrderTaskUpdateView{
    public WorkOrderTaskView Task { get; set; }
    public IEnumerable<SelectListItem> Status { get; set; }
}