using System.Collections.Generic;
using ERP.Models;
using System.Text;
using Microsoft.Extensions.Options;
using ERP.API.Models;
using ERP.API.Data.Queries;
using System.Linq;
using ERP.Models.Views;

namespace ERP.API.Data.Services
{
    public interface IMaterialsService
    {
        int Add(APIEmpIdModel<Materials> model);
        IEnumerable<MaterialsView> GetAll();
        Materials GetByCode(string code);
        Materials GetById(int id);
        bool CodeDuplicationCheckForUpdate(KeyValue material);
        bool Update(Materials materials);
    }

    public class MaterialsService:IMaterialsService
    {
        private IDbContext dbContext;
        public MaterialsService(IDbContext dbContext)
        {
            this.dbContext=dbContext;
        }

        public int Add(APIEmpIdModel<Materials> model)   
        {
            try
            {
                //var queryBuilder = new StringBuilder()
                //                    .Append("insert into materials ")
                //                    .Append("(code,name,specification,quantity,shelfnumber) ")
                //                    .Append("values ")
                //                    .Append($"('{newMaterial.Code}','{newMaterial.Name}', ")
                //                    .Append($"'{newMaterial.Specification}',0,'{newMaterial.ShelfNumber}');")
                //                    .Append("SELECT LAST_INSERT_ID();")
                //                    ;

                //var query = queryBuilder.ToString();
                //return dbContext.Execute<int>(query);

                



                var materialId = dbContext.Get<int>(MaterialsQueries.Insert, DataHelper.ExtractParameters(model.Model));
                if (materialId > 0)
                {
                    var erpEvent = new ERPEventHelper().GetEventModel(model.EmployeeId, materialId, EventTypes.MaterialsCreate);
                    dbContext.ExecuteNonQuery(EventQueries.EventInsert, DataHelper.ExtractParameters(erpEvent));
                    return materialId;
                }
                else throw new System.Exception("Error adding Material!");
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        public IEnumerable<MaterialsView> GetAll()
        {
            try
            {
                var query = MaterialsQueries.SelectAllWithEvents;
                return dbContext.GetList<MaterialsView>(query);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public Materials GetByCode(string code)
        {
            try
            {
                var query = $"select * from materials where Code='{code}'";
                return dbContext.Get<Materials>(query);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public bool CodeDuplicationCheckForUpdate(KeyValue material)
        {
            try
            {
                var query = $"select * from materials where Code='{material.Value}' and Id != {material.Key}";
                var result = dbContext.GetList<Materials>(query);
                return (result.ToList().Count() == 0) ? true : false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public bool Update(Materials materials)
        {
            var query = MaterialsQueries.Update;
            var parameters = DataHelper.ExtractParameters(materials);
            dbContext.ExecuteNonQuery(query, parameters);
            return true;
        }
        public Materials GetById(int id)
        {
            try
            {
                var query = $"select * from materials where Id='{id}'";
                return dbContext.Get<Materials>(query);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}