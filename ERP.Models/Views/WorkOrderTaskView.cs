using ERP.Models;

public class WorkOrderTaskView:WorkOrderTask
{
    public string EmployeeName { get; set; }
    public bool IsOverdue { get; set; } 
    public int? OverdueDays { get; set; }

}