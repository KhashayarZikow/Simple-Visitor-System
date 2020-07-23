using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;

namespace Visitor.Interfaces.ObjectData
{
    public interface IFindVisitor
    {
        IHost FindVisitorInOrganization(VisitorData visitor);
    }
}
