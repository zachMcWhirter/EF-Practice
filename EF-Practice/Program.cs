using EF_Practice.Models;
using System;
using System.Linq;

using var db = new EfpracticedbContext();

//var familyMembers = db.FamilyMembers
//    .OrderBy(i => i.Id)
//    .Take(6)
//    .ToList();

//Console.WriteLine("  OUR FAMILY MEMBERS");
//Console.WriteLine("  ------------------");

//foreach (var item in familyMembers)
//{
//    Console.WriteLine($"  {item.FirstName}"); 
//}

//var friends = db.Friends
//    .OrderBy(i => i.Id)
//    .Take(6)
//    .ToList();

//Console.WriteLine("");
//Console.WriteLine("  OUR FRIENDS");
//Console.WriteLine("  -----------");

//foreach (var item in friends)
//{
//    Console.WriteLine($"  {item.FirstName} is {item.ConnectedTo}'s friend");
//    Console.WriteLine();
//}

var procs = new EfpracticedbContextProcedures(db);

