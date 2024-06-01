int playerHealth = 10;
int monsterHealth = 10;
bool playerTurn = true;

Random attack = new();
int damage = 0;

do {
    damage = attack.Next(1, 11);

    if (playerTurn) {
        monsterHealth -= damage;
        Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");
    }
    else {
        playerHealth -= damage;
        Console.WriteLine($"Hero was damaged and lost {damage} health and now has {playerHealth} health.");
    }

    playerTurn = !playerTurn;
} while ((playerHealth > 0) && (monsterHealth > 0));

if (playerHealth > 0)
    Console.WriteLine("Hero wins!");
else 
    Console.WriteLine("Hero loses!");

Console.WriteLine("Game over!");