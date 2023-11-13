// See https://aka.ms/new-console-template for more information

using System.Dynamic;
using ObjectBuilder_Proto;

// #1 <<<Dynamic Field>>> 

List<DynamicField> relationTypeCustomerFields = new List<DynamicField>();

relationTypeCustomerFields.Add(new DynamicField() { Name = "FirstName", DisplayName = "Vorname", Type = typeof(string), Value = "Max"});
relationTypeCustomerFields.Add(new DynamicField() { Name = "Birthday", DisplayName = "Geburtstag", Type = typeof(DateTime), Value = DateTime.Today.AddYears(-20)});
relationTypeCustomerFields.Add(new DynamicField() { Name = "Money", DisplayName = "Geld", Type = typeof(double), Value = 50.75 });

foreach (DynamicField dynamicField in relationTypeCustomerFields)
{
  if (dynamicField.Type == typeof(double)) // or Value == typeof(double)
  {
    Console.WriteLine($"{dynamicField.DisplayName}: {(double)dynamicField.Value + 100}");
  }
  else
  {
    Console.WriteLine($"{dynamicField.DisplayName}: {dynamicField.Value}");
  }
  
}

//  #2 <<<Expando Object>>>
//
//ExpandoObject myExpando = new ExpandoObject();
//myExpando.TryAdd("FirstName", "Max");
//myExpando.TryAdd("Birthday", DateTime.Today.AddYears(-20));
//myExpando.TryAdd("Money", 50.75);
//
//foreach (KeyValuePair<string, object?> keyPair in myExpando)
//{
//  if (keyPair.Value?.GetType() == typeof(double))
//  {
//    Console.WriteLine($"{keyPair.Key}: {(double) keyPair.Value + 100}");
//  }
//  else
//  {
//    Console.WriteLine($"{keyPair.Key}: {keyPair.Value}");
//  }
// }
