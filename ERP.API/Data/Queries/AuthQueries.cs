using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.API.Data.Queries
{
    public static class AuthQueries
    {
        public static readonly string GetFeaturesForUser = @"select f.Id FeatureId,f.Name FeatureName
                                                            ,CASE WHEN efa.EmployeeFeatureId IS NULL THEN 0 ELSE 1 END HasAccess
                                                            from 
                                                            (select Featureid EmployeeFeatureId from erp.employee_features where employeeid=@Id)efa 
                                                            right join erp.features f
                                                            on efa.EmployeeFeatureId=f.Id
                                                            order by f.id;";

        public static readonly string InsertFeature = @"insert into erp.employee_features (EmployeeId,FeatureId) values (@EmployeeId,@FeatureId)";

    }
}
