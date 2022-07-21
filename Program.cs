using MovieDatabaseLab;

bool continueProgram = true;

while (continueProgram)
{
    Console.WriteLine(
    @"Please select which movie list you'd like to see, or press '0' to quit:
    
    1. All Movies
        Filtered by Category:
        2. Animated
        3. Drama
        4. Horror
        5. Scifi

    0. Exit Program
    "
    );

    validateInput(Console.ReadKey().Key);
}

Console.WriteLine("Thank you for using our movie database!");

void validateInput(ConsoleKey key)
{
    Console.Clear();

    switch (key)
    {
        case ConsoleKey.NumPad1:
        case ConsoleKey.D1:
            MoviesList.DisplayMovieTable();
            break;
        case ConsoleKey.NumPad2:
        case ConsoleKey.D2:
            MoviesList.DisplayMovieTableByCategory("animated");
            break;
        case ConsoleKey.NumPad3:
        case ConsoleKey.D3:
            MoviesList.DisplayMovieTableByCategory("drama");
            break;
        case ConsoleKey.NumPad4:
        case ConsoleKey.D4:
            MoviesList.DisplayMovieTableByCategory("horror");
            break;
        case ConsoleKey.NumPad5:
        case ConsoleKey.D5:
            MoviesList.DisplayMovieTableByCategory("scifi");
            break;
        case ConsoleKey.NumPad0:
        case ConsoleKey.D0:
            continueProgram = false;
            break;
        default:
            Console.WriteLine("You did not enter a valid input!");
            break;
    }
}