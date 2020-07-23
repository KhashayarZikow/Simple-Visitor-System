using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Employee;
using Visitor.Interfaces.ObjectData;
using Visitor.VisitorTypes;

namespace Visitor.Factories
{
    class FindVisitorFactory
    {
        public static IHost FindVisitor(VisitorData visitor)
        {
            switch (visitor)
            {
                case VipVisitor vip:
                    return vip.FindVisitorInOrganization(visitor);
                case StayInVisitor stayInVisitor:
                    return stayInVisitor.FindVisitorInOrganization(visitor);
                default:
                    throw new ArgumentException($"Unexpected visitor type: {visitor}");
            }
        }
    }
}
