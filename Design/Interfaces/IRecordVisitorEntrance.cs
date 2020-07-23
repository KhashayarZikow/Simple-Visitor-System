using System.Collections.Generic;
using Visitor.Interfaces.ObjectData;

namespace Visitor.Interfaces
{
    public interface IRecordVisitorEntrance
    {
        void RegisterEntranceData(RegistrationData registrationData, IEnumerable<Device> devices);
    }
}
