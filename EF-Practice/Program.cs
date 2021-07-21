using EF_Practice.Models;
using System;
using System.Linq;

using var db = new EfpracticedbContext();

var familyMembers = db.FamilyMembers
    .OrderBy(i => i.Id)
    .Take(6)
    .ToList();
    
Console.WriteLine("  OUR FAMILY MEMBERS");
Console.WriteLine("  ------------------");

foreach (var item in familyMembers)
{
    Console.WriteLine($"  {item.FirstName}"); 
}

var friends = db.Friends
    .OrderBy(i => i.Id)
    .Take(6)
    .ToList();

Console.WriteLine("");
Console.WriteLine("  OUR FRIENDS");
Console.WriteLine("  -----------");

foreach (var item in friends)
{
    Console.WriteLine($"  {item.FirstName} is {item.ConnectedTo}'s friend");
    Console.WriteLine();
}


//var orders = await db.GetProcedures().CustOrderHist("ALFKI");
//foreach (var order in orders)
//    Console.WriteLine($"{order.ProductName}: {order.Total}");

//var outOverallCount = new OutputParameter<int?>();
//var customers = await db.GetProcedures().SP_GET_TOP_IDS(10, outOverallCount);
//Console.WriteLine($"Db contains {outOverallCount.Value} Customers.");
//foreach (var customer in customers)
//    Console.WriteLine(customer.CustomerId);

// Use scalar functions inline in queries:


//Where(o => o.Reference == EfpracticedbContext.GetReference(o.OrderName)).ToList();

//    var tvfTest = db.ProductsWithMinimumInStock(5)

