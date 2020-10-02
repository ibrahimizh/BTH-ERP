using ERP.API.Data.Queries;
using ERP.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.API.Data.Services
{
    public class ERPeventService
    {
        private IDbContext dbContext;

        public ERPeventService(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<ERPeventView> GetPurchaseOrderEvents(int id)
        {
            var query = EventQueries.GetPurchaseOrderEvents;
            var parameters = DataHelper.ExtractParameters(new { EventId = id });
            return dbContext.GetList<ERPeventView>(query, parameters);
        }

        public IEnumerable<ERPeventView> GetEnquiryEvents(int id)
        {
            var query = EventQueries.GetEnquiryEvents;
            var parameters = DataHelper.ExtractParameters(new { EventId = id });
            return dbContext.GetList<ERPeventView>(query, parameters);
        }

        private IEnumerable<ERPeventView> GetEvents(int id, string eventTypes)
        {
            var query = EventQueries.GetEvents;
            var parameters = DataHelper.ExtractParameters(new { EventId = id, EventTypes = eventTypes });
            return dbContext.GetList<ERPeventView>(query, parameters);
        }

        internal IEnumerable<ERPeventView> GetWorkOrderEvents(int id)
        {
            var query = EventQueries.GetWorkOrderEvents;
            var parameters = DataHelper.ExtractParameters(new { EventId = id });
            return dbContext.GetList<ERPeventView>(query, parameters);
        }
    }
}
