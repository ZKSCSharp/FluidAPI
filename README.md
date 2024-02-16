# FluidAPI
A C# packages to make api calls very simply


Exemple :

```csharp
static void Main(string[] args)
{
  List<APIField> fields = new List<APIField>();
  fields.Add(new APIField("name", value);

  API.Call("apiname", "apiUrl", fields, connection);
  Console.ReadLine();
}

private static void connection(string response)
{
  if (response.Equal("Granted")
  { Console.WriteLine("Success"); }
  else
L{ Console.Writeline("Error"); }
}
```
