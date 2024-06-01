Random coin = new();
string toss = coin.Next(0, 2) == 0 ? "heads" : "tails";

Console.WriteLine($"The coin landed on {toss}.");