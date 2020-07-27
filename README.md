# Simple-Visitor-System
This project has been written in C# using .Net Framework 4.6.1. It can be run in the Visual Studio 2013 and above.
The project is for demonstration of using design patterns and solid principles for visitors in a visitor system.
Extensibility of visitor types was one of the non functional requirements.
In this piece of code, there are two types of visitors with different properties. Visitors can be hosted by departments and employees. Visitors are allowed to carry specific types of devices while visiting the company.
A specific type of builder pattern with using of factory has been used to help the creation of SatyIn visitor instance. SatyIn visitor is a type of vistitor that can stay over night in one of the company’s buildings. First, if any building is available, time will be checked and visitor object gets created.
Vip visitors need specific arrangement to ensure a room is reserved while registering them.
Factory design pattern with implicit casting, has been used to find the visitor’s host.
A sample of how client can create these objects can be found in program.cs.
