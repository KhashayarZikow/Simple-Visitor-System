using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Interfaces.Accomodation
{
    public interface ISetStayinInInformation
    {
        IStayInBuilder SetStayInInfo(DateTime start, DateTime end);
    }
}
