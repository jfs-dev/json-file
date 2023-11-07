using json_file.Models;
using json_file.Services;

var filePath = "Data/JsonFile.json";

List<Customer> writeCustomers =
[
    new() { Name = "Peter Parker", Email = "peter.parker@marvel.com" },
    new() { Name = "Ben Parker", Email = "ben.parker@marvel.com" },
    new() { Name = "Mary Jane", Email = "mary.jane@marvel.com" }
];

JsonFileService.WriteDataToJsonFile(filePath, writeCustomers);

var readCustomers = JsonFileService.ReadDataFromJsonFile(filePath);

if (readCustomers is not null)
{
    Console.ForegroundColor = ConsoleColor.Magenta;

    foreach (var currentCustomer in readCustomers)
        Console.WriteLine($"{ currentCustomer.Id } - { currentCustomer.Name } - { currentCustomer.Email }");
}