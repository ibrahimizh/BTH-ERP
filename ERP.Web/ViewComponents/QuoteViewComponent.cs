using System.Threading.Tasks;
using ERP.Models;
using ERP.Models.Views;
using ERP.Web.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Web.ViewComponents
{
    public class QuoteViewComponent:ViewComponent
    {
        private IAPIHelper api;
        public QuoteViewComponent(IAPIHelper helper)
        {
            this.api=helper;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var quote = await api.Get<QuoteView>($"Proposals/GetQuote/{id}");
            return View(quote);
        }
    }
}