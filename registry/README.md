Övningsuppgift 1: personalregister

1) Vilka klasser bör ingå i programmet?

De klasser jag kommer använda i programmet:
* IDisplayable: interface för records i registret som kan leverera fin utskrift
* Registry: wrapper klass för min datastruktur
* Employee: record struct med information kopplad till en anställd
* Name: record struct med information kopplat till ett specifikt namn
* Salary: record struct med information kopplat till en specifik lön
* CLIClient: klass som hanterar användarinput och output

2) 

IDisplayable:
* GetRecordDisplay() returnerar en sträng med fin utskrift

Registry:
* List<Employee> över alla employees
* void AddEmployee(Employee employee)
* void RemoveEmployee(Employee employee)
* void AddEmployees(IEnumerable<Employee>)
* void ClearEmployees()
* void UpdateName(Employee employee)
* void UpdateSalary(Employee employee)

Employee: IDisplayable
* namn av typ Name
* lön av typ Salary
* GetRecordDisplay() returnerar en sträng med fin utskrift

Name: IDisplayable
* förnamn av typ string
* efternamn av typ string
* GetRecordDisplay() returnerar en sträng med fin utskrift

Salary: IDisplayable
* månadssumma av typ int
* GetRecordDisplay() returnerar en sträng med fin utskrift
* GetYearlyAmount() returnerar int med årslön

CLIClient:
* 