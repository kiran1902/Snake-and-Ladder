// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome To play Snake And Ladder");

//Declaring Constants
const int Ladder = 1;
const int Snake = 2;
const int NoPlay = 3;


Random random = new Random();      //initiatizlize the random class
int DiceRolled = random.Next(7);   //class to generate randome number from 1 - 6
Console.WriteLine("Number of times the dice was Rolled : " + DiceRolled);

int PosPlayer = 0;
Random random = new Random();   
int ResultSnake = random.Next(4); //class to generate randome number from 1 - 3

if (ResultSnake == Ladder)
{
    PosPlayer = PosPlayer + DiceRolled;
    Console.WriteLine("Ladder");
    Console.WriteLine("Player Current Position : " + PosPlayer);
}
else if (ResultSnake == Snake)
{
    PosPlayer = PosPlayer - DiceRolled;
    Console.WriteLine("Snake");
    Console.WriteLine("Player Current Position : " + PosPlayer);
}
else
{
    Console.WriteLine("No Play");
}

