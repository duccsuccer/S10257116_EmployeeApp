using EmployeeApp;
SortedList<int, Employee> employeeList = new();
List<Employee> employeeList2 = new();
FullTimeEmployee employee1 = new(103, "John", 1500, 100);
PartTimeEmployee employee2 = new(101, "Mary", 50, 10);
PartTimeEmployee employee3 = new(102, "Bob", 55, 20);
// Sorted List
employeeList.Add(103, employee1);
employeeList.Add(101, employee2);
employeeList.Add(102, employee3);

// List
employeeList2.Add(employee1);
employeeList2.Add(employee2);
employeeList2.Add(employee3);

foreach (var employee in employeeList)
{
    Console.WriteLine(employee.ToString());
}

Console.WriteLine("\nUnsorted\n");
employeeList2.Sort();
foreach(var employee in employeeList2)
{
    Console.WriteLine(employee.ToString());    
}


// output in (b) shows the key and the whole list, while output in (e) shows what is returned from the superclass ToString().