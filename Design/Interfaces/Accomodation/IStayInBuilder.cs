using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;
using Visitor.Interfaces.ObjectData;
using Visitor.VisitorTypes;

namespace Visitor.Interfaces.Accomodation
{
    public interface IStayInBuilder
    {
        StayInVisitor Build(string name, string familyName, string id, DepartmentData departmentData);
    }
}
