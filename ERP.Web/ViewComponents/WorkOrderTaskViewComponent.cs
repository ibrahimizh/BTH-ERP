using System.Collections.Generic;
using System.Threading.Tasks;
using ERP.Models;
using ERP.Web.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Web.ViewComponents
{
    public class WorkOrderTaskViewComponent:ViewComponent
    {
        private IAPIHelper api;
        public WorkOrderTaskViewComponent(IAPIHelper helper)
        {
            this.api=helper;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var WorkOrderTask = await api.Get<IEnumerable<WorkOrderTaskView>>($"WorkOrder/GetTasks/{id}");
            return View(WorkOrderTask);
        }
    }
}