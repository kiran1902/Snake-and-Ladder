// See https://aka.ms/new-console-template for more information
Console.WriteLine("Weelcome To Paly snake And Ladder");


Random random = new Random();
int DiceRolled = random.Next(7);
Console.WriteLine("Number of times the dice was Rolled : " + DiceRolled);

int position = 0;
Console.WriteLine("Player is at Start Position : " + position);
Console.WriteLine("Single Player");
Console.ReadLine();
