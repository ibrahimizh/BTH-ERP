using System.Threading.Tasks;
using ERP.Models;
using ERP.Models.Views;
using ERP.Web.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Web.ViewComponents
{
    public class ProposalViewComponent:ViewComponent
    {
        private IAPIHelper api;
        public ProposalViewComponent(IAPIHelper helper)
        {
            this.api=helper;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var proposal = await api.Get<ProposalViewModel>($"Proposals/GetProposalById/{id}");
            return View(proposal);
        }
    }
}