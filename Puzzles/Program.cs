// Coin Flip
static string CoinFlip()
{
    Random rand = new();
    int flip = rand.Next(2);
    if(flip == 0){
        return "Heads";
    } else {
        return "Tails";
    }
}
// Console.WriteLine(CoinFlip());


// Dice Roll
static int DiceRoll(int diceSize = 6)
{
    Random rand = new();
    int roll = rand.Next(1, diceSize+1);
    return roll;
}

// Console.WriteLine(DiceRoll());
// Console.WriteLine(DiceRoll(12));

// Stat Roll
static List<int> StatRoll(int rolls = 4, int diceSize = 6)
{
    List<int> ResultList = new();
    for(int i = 0; i < rolls; i++)
    {
        ResultList.Add(DiceRoll(diceSize));
    }
    return ResultList;
}

// StatRoll().ForEach(Console.WriteLine);
// StatRoll(10).ForEach(Console.WriteLine);
// StatRoll(10, 12).ForEach(Console.WriteLine);
// Console.WriteLine(StatRoll(10).Max());

// Roll Until
static string RollUntil(int rollFor)
{
    int CurrentRoll = 0;
    int TotalRolls = 0;

    if(rollFor <= 6)
    {
        while(CurrentRoll != rollFor)
    {
        CurrentRoll = DiceRoll();
        TotalRolls ++;
    }
    return $"Rolled a {rollFor} after {TotalRolls} rolls";
    }

    return "Choose a number that exists on a 6-sided die.";
    
}

Console.WriteLine(RollUntil(2));
Console.WriteLine(RollUntil(6));
Console.WriteLine(RollUntil(8));



