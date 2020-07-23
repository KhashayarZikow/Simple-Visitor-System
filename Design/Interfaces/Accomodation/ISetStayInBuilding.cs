using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Building;

namespace Visitor.Interfaces.Accomodation
{
    public interface ISetStayInBuilding
    {
        ISetStayinInInformation SetBuilding(BuildingData building);

    }
}
