Random random = new Random();
bool play = true;
int min = 1;
int max = 10;
int number;
int guess;

while(play)
{
    guess = 0;
    number = random.Next(min, max );

    while (guess != number)
    {
        Console.WriteLine("Odgadnij liczbę od " + min + " - " + max + " : ");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("zgadywana: " + guess);

        if (guess < number)
        {
            Console.WriteLine(guess + " jest zamałe");
        }
        else if (guess > number)
        {
            Console.WriteLine(guess + " jest zaduże");
        }
    }
    Console.WriteLine("Liczba: " + number);
    Console.WriteLine("Zgadłeś!");
    break;
}

Console.ReadKey();
