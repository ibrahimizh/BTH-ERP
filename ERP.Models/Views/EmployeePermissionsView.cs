using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Models.Views
{
    public class EmployeePermissionsView
    {
        public int FeatureId { get; set; }
        public string FeatureName { get; set; }
        public bool HasAccess { get; set; }
    }

    public class UpdateEmployeePermissionsView
    {
        public int EmployeeId { get; set; }
        public int[] FeatureIds { get; set; }
    }
}
