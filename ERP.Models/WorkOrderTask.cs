using System;

namespace ERP.Models
{
    public class WorkOrderTask
    {
        public int Id { get; set; }
        public int WorkOrderId { get; set; }
        public int EmployeeId { get; set; }
        public string Description { get; set; }
        public WorkOrderTaskStatus StatusId{get;set;}
        public DateTime Timestamp { get; set; }
        public DateTime TargetDate { get; set; }
        public byte Progress { get; set; }
        public DateTime? StartedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int? WorkOrderItemId { get; set; }
        public string Item { get; set; }
        public string Specification { get; set; }
    }

    public class UpdateWorkOrderTaskModel
    {
        public int TaskId { get; set; }
        public byte StatusId { get; set; }
        public DateTime Timestamp { get; set; }
        
    }

    public class FilterTaskModel
    {
        public int? WorkOrderId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? TargetDateFrom { get; set; }
        public DateTime? TargetDateTo { get; set; }

    }
}