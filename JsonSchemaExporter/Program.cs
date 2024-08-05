using Logic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Schema;


JsonNode jsonSchema = JsonSchemaExporter
    .GetJsonSchemaAsNode(JsonSerializerOptions.Default, typeof(Product));

Console.WriteLine(jsonSchema);
