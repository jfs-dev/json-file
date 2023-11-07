using System.Text.Json;
using json_file.Models;

namespace json_file.Services;

public static class JsonFileService
{
    public static void WriteDataToJsonFile(string filePath, List<Customer> customers)
    {
        JsonSerializerOptions jsonSerializerOptions = new() { WriteIndented = true };
        JsonSerializerOptions options = jsonSerializerOptions;
        string jsonData = JsonSerializer.Serialize(customers, options);
            
        File.WriteAllText(filePath, jsonData);
    }

    public static List<Customer>? ReadDataFromJsonFile(string filePath)
    {
        List<Customer>? customers = [];

        if (File.Exists(filePath))
        {
            string jsonData = File.ReadAllText(filePath);

            customers = JsonSerializer.Deserialize<List<Customer>>(jsonData);
        }

        return customers;
    }
}