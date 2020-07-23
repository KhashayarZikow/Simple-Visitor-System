
using Employee;

namespace Visitor.Interfaces.ObjectData
{
    public abstract class VisitorData
    {
        public string Name { get; set; }

        public string FamilyName { get; set; }

        public string Id { get; set; }

        public EmployeeData EmployeeData { get; set; }

        public DepartmentData DepartmentData { get; set; }

    }
}