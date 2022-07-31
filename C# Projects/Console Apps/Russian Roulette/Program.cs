int playerNumber;
int computerNumber;
bool alive = true;;

while(alive)
{
    Console.WriteLine("Pick a number between 1 and 6.");
    playerNumber = Convert.ToInt32(Console.ReadLine());
    computerNumber = Random.Shared.Next(1, 7);
    Console.WriteLine($"The computer chose {computerNumber}");

    if(playerNumber == computerNumber)
    {
        alive = false;
        Console.WriteLine("\nBANG!\nYou are dead.\n");
    }
}