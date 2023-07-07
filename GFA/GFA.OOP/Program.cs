// See https://aka.ms/new-console-template for more information


using GFA.OOP.Models;

var fileText = File.ReadAllText("C:\\Users\\Murat\\Desktop\\RussianMob.txt");
List<GameAccount> accounts = new List<GameAccount>();
foreach (string file in fileText.Split("\n"))
{
    List<string> files = file.Split("---").ToList();
    GameAccount account = new GameAccount()
    {
        Id = 1,
        UserName = files[0],
        Password = files[1],
        Platform = GameAccount.ConvertStringToPlatform(files[2]),
        Level = Convert.ToInt32(files[3]),
        GameName = files[4],
        Price = Convert.ToDecimal(files[5].Replace("$", string.Empty)),
    };

    accounts.Add(account);

    //Console.WriteLine(file);
    //Console.ReadLine();

}
accounts.ForEach(x => Console.WriteLine($"User Name:{x.UserName},Password:{x.Password},Platform:{x.Platform},Level:{x.Level},Game Name:{x.GameName},Price:{x.Price}"));
Console.ReadLine();



//using GFA.OOP.Enums;
//using GFA.OOP.Models;

//var firstPlayer = new Player("Gandhalf 38", 38, Race.Human,PlayerClassType.Mage);

//Console.WriteLine($"ID:{firstPlayer.Id}, Character Name:{firstPlayer.Name}, Character Level:{firstPlayer.Level}, Character Favourite Number:{firstPlayer.FavouriteNumber}");

//firstPlayer.LevelUp();
//firstPlayer.LevelUp();
//firstPlayer.LevelUp();
//firstPlayer.LevelUp();
//firstPlayer.LevelUp();

//Console.WriteLine($"ID:{firstPlayer.Id}, Character Name:{firstPlayer.Name}, Character Level:{firstPlayer.Level}, Character Favourite Number:{firstPlayer.FavouriteNumber}");

//firstPlayer.ChangeRace(Race.Dwarf);

//Console.WriteLine(firstPlayer.Race.ToString());

//var secondPlayer = new Player("Excalibur",10,Race.Orc,PlayerClassType.DeathKnight);

//Console.WriteLine($"ID:{secondPlayer.Id}, Character Name:{secondPlayer.Name}, Character Level:{secondPlayer.Level}, Character Favourite Number:{secondPlayer.FavouriteNumber}");

//var thirdPlayer = new Player("Tarkan", 55, Race.Undead, PlayerClassType.Assassin);

//Console.WriteLine($"ID:{thirdPlayer.Id}, Character Name:{thirdPlayer.Name}, Character Level:{thirdPlayer.Level}, Character Favourite Number:{thirdPlayer.FavouriteNumber}");


//Console.ReadLine();


