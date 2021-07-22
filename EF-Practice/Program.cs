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

// GETTING A FILTERED LIST

var procs = new EfpracticedbContextProcedures(db);
    // create a variable to store the procedures to be used

var result = await procs.GetFriendsAsync("%r%");
    // Using the stored proc to filter results and return only
    // the firstNames that contain the string pessed into the method

foreach (var item in result)
    // everytime a firstName has chars that match the parameter string...
{
    Console.WriteLine(item.FriendName);
    // ...Write them to the console
}



