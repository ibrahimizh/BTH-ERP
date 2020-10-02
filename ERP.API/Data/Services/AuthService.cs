using ERP.API.Data.Queries;
using ERP.API.Models;
using ERP.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.API.Data.Services
{
    public class AuthService
    {
        private IDbContext dbContext;

        public AuthService(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<EmployeePermissionsView> GetPermissionsById(int id)
        {
            var query = AuthQueries.GetFeaturesForUser;
            var parameters = DataHelper.ExtractParameters(new { Id = id });
            return dbContext.GetList<EmployeePermissionsView>(query, parameters);
        }

        public bool UpdatePermissions(UpdateEmployeePermissionsView model)
        {
            var queryBuilder=new StringBuilder($"delete from erp.employee_features where EmployeeId={model.EmployeeId};");
            queryBuilder.Append($"insert into erp.employee_features (EmployeeId,FeatureId) values ");
            foreach(var featureId in model.FeatureIds)
            {
                queryBuilder.Append($"({model.EmployeeId},{featureId}),");
            }
            dbContext.ExecuteNonQuery(queryBuilder.ToString().Remove(queryBuilder.Length-1));
            return true;
        }
    }
}
