using System;

public class WorkOrderMaterials{

    public int Id { get; set; }
    public int WorkOrderId { get; set; }
    public int MaterialId { get; set; }
    public string Material { get; set; }
    public decimal Units { get; set; }
    public DateTime Timestamp { get; set; }
}