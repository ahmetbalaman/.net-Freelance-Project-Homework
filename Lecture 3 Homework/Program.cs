using Freelancer.Constants;
using Freelancer.Entities;
using Freelancer.Services;



var anotherCustomerInstance = new Customer
{
    Id = Guid.NewGuid(), 
    CreatedOn = DateTime.Now,
    LastName = "Smith",
    FirstName = "Bob",
    PhoneNumber = "555-123-4567"
};



NotepadService notepadService = new();
Console.WriteLine($"{FileLocations.ProjectFolder}/Customers.txt");
string customerData = notepadService.GetOnNotepad($"{FileLocations.ProjectFolder}/Database/Customers.txt");
string[] splittedLines = customerData.Split("\n", StringSplitOptions.RemoveEmptyEntries);

List<Customer> customers = new();

foreach (var line in splittedLines)
{
    Customer customer = new();
    customer.SetValuesCSV(line);
    customers.Add(customer);
    Console.WriteLine(customer.FirstName);
}

Console.ReadLine();