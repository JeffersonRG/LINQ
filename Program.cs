// See https://aka.ms/new-console-template for more information

using LINQ;

//makes a list of 10 games that differ in titles, esrbs and genres.
Game[] games = new Game[]
        {
            new Game("Minecraft", 'E', "Action-Adventure"),
            new Game("CS:GO", 'M', "FPS"),
            new Game("Elden Ring", 'M', "Action-Adventure"),
            new Game("Valorant", 'T', "FPS"),
            new Game("Halo 3", 'M', "Action"),
            new Game("Zombcube", 'E', "FPS Survival"),
            new Game("Magnet Destroyer", 'E', "Hyper-Casual"),
            new Game("Paddle Balls", 'E', "Arcade Casual"),
            new Game("Rocket League", 'E', "Action Racing"),
            new Game("Fifa 22", 'E', "Sport"),
        };

//puts  games named 8 or less into the "short Games" list.
var shortGames = from game in games
                 where game.Title.Length < 9
                 select $"Game Title: {game.Title.ToUpper()}";

//for each game in short Games, it will appear in the WriteLine field.
foreach (var game in shortGames)
{
    Console.WriteLine(game);
}

//turns MineCraft into a variable that displays the title, ESRB, and genre.
var mineCraft = games.Where(game => game.Title == "Minecraft")
                 .Select(Game => $"Title: {Game.Title}, ESRB: {Game.Esrb}, Genre: {Game.Genre}");

Console.WriteLine(mineCraft.FirstOrDefault());

//makes a variable called tRated and puts the T-rated games in the list.
var tRated = from game in games
             where game.Esrb == 'T'
             select game.Title;

//makes a variable called tRated and puts the T-rated games in the list.
Console.WriteLine("T Rated Games:");
foreach (var game in tRated)
{
    Console.WriteLine(game);
}

//makes eRatedAction  a variable that searches for E-rated games with a genre of Action.
var eRatedAction = from game in games
                   where game.Esrb == 'E' && game.Genre.Contains("Action")
                   select game.Title;

//display E-Rated Action Games and list them.
Console.WriteLine("E Rated Action Games:");
foreach (var game in eRatedAction)
{
    Console.WriteLine(game);
}

