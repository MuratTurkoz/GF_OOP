
using GFA.OOP.Extensions;
using GFA.OOP.Interfaces;
using GFA.OOP.Models;
using GFA.OOP.Services;

//Console.WriteLine("How do you want to save your context");
//Console.WriteLine(".txt or .json");

//IFileSaver fileSaver;

//var userAnswer = Console.ReadLine();
//if (userAnswer == "txt")
//{
//    fileSaver = new TextFileSaver();
//    fileSaver.Save("deneme","Hi there");
//}
//else if (userAnswer == "json")
//{
//    fileSaver=new JsonFileSaver();
//    fileSaver.Save("deneme", "Hi there");
//}


var gameAccount = new GameAccount();
gameAccount.Level = 100;
Console.WriteLine(gameAccount.Level.IsEven());

