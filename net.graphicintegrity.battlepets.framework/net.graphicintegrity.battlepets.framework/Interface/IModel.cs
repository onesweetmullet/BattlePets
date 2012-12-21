using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net.graphicintegrity.battlepets.framework.Interface
{
    public interface IModel
    {
        string GetName(int i);
        string GetDescription(int i);
    }
}
