using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net.graphicintegrity.battlepets.framework.Workflows
{
    public class DamageType : Model.DamageType
    {
        public static string GetDamageTypeName(int damageTypeID)
        {
            return GetDamageType(damageTypeID).DamageTypeName;
        }

        public static string GetDamageTypeDescription(int damageTypeID)
        {
            return GetDamageType(damageTypeID).DamageTypeDescription;
        }
    }
}
