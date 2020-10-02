using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERP.API.Data.Queries;
using ERP.Models;
using ERP.Models.Views;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ERP.API.Data.Services
{
    public interface ISuppliersService
    {
        int Add(APIEmpIdModel<Suppliers> model);
        IEnumerable<SuppliersView> GetAll();
        IEnumerable<SelectListItem> GetDropDown();
    }
    public class SuppliersService:ISuppliersService
    {
        private IDbContext dbContext;
        
        public SuppliersService(IDbContext dbContext)
        {
            this.dbContext=dbContext;
           
        }

        public int Add(APIEmpIdModel<Suppliers> model)   
        {
            var supplierId = dbContext.Get<int>(SupplierQueries.Insert, DataHelper.ExtractParameters(model.Model));
            if (supplierId > 0)
            {
                var erpEvent = new ERPEventHelper().GetEventModel(model.EmployeeId, supplierId, EventTypes.SuppliersCreate);
                dbContext.ExecuteNonQuery(EventQueries.EventInsert, DataHelper.ExtractParameters(erpEvent));
                return supplierId;
            }else throw new System.Exception("Error adding Supplier!");
        }

        public IEnumerable<SuppliersView> GetAll()
        {
            var query=SupplierQueries.SelectAllWithEvents;
            return dbContext.GetList<SuppliersView>(query);
        }

        public IEnumerable<SelectListItem> GetDropDown()
        {
            var query="select * from suppliers;";
            var suppliersList= dbContext.GetList<Suppliers>(query).ToList();
            return suppliersList.Select(x=>new SelectListItem{
                Text=x.Name,
                Value=x.Id.ToString()
            }).ToList();
        }

        // public Suppliers GetByCode(string code)
        // {
        //     var query=$"select * from materials where Code='{code}'";
        //     return base.Get<Materials>(query);
        // }



    }
}