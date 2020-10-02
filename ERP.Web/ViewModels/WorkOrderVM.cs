using ERP.Models;

public class WorkOrderVM
{
    public WorkOrderVM()
    {
        this.WorkOrderDetail = new WorkOrder();
        this.CreateTaskVM = new CreateWorkOrderTaskVM();
    }
    public WorkOrder WorkOrderDetail { get; set; }
    public CreateWorkOrderTaskVM CreateTaskVM { get; set; }
    
}