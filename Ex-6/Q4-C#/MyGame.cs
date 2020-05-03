using System;

class MyGame
{
    string[] lines;
    const int TRIES_NUM = 10;

    static void Main(string[] args)
    {
        new MyGame().startGame();
    }

    public MyGame()
    {
        // Vocabulary attached
        lines = System.IO.File.ReadAllLines("Vocabulary.txt");
    }

    // Start current session
    public void startGame()
    {
        Random rnd = new Random();
        string word = lines[rnd.Next(0, lines.Length)];
        Console.WriteLine ("Your word guess length is [" + word.Length + "] Good Luck!");

        startQuiz(word);
    }

    private void startQuiz(string word)
    {
        Boolean[] correctedGuess = new Boolean[word.Length];
        Boolean win = false;
        int tryNumber = 0;
        while(tryNumber < TRIES_NUM && !win)
        {
            Console.WriteLine();
            printBoard(word, correctedGuess);
            Console.WriteLine("Tries left: " + tryNumber + "/" + TRIES_NUM);
            Console.Write("Guess a Word or Letter: ");
            string currentGuess = Console.ReadLine();

            if (currentGuess.Length == 1 && checkLettter(currentGuess[0], word, correctedGuess)) // it's one letter guess
            {
                Console.WriteLine("Great! your letter was right");
                win = checkWin(correctedGuess);
            }
            else if (currentGuess == word)
                win = true;
            else
            {
                Console.WriteLine("This guess was inccorect");
                tryNumber++;
            }

        }

        string endMsg;
        if (win)
            endMsg = "You win!!! Well done ";
        else
            endMsg = "Ohh this time You Loose But don't worry you can try again ";

        endMsg += "the word was: [" + word + "], would you like to play again?";
        Console.WriteLine(endMsg);

        string nextAction = Console.ReadLine();
        if (nextAction.ToLower() == "yes" || nextAction.ToLower() == "y" || nextAction == "")
            startGame();
        else
            Console.WriteLine("Thank you for playing our game :)");
    }

    // Reutrn true if all the correctedGuess array is true
    Boolean checkWin(Boolean[] correctedGuess)
    {
        foreach (Boolean current in correctedGuess)
        {
            if (!current)
                return false;
        }

        return true;
    }

    // Check if the current guess was right and update the bool array
    private Boolean checkLettter(char guess, string word, Boolean[] correctedGuess)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == guess && !correctedGuess[i])
            {
                correctedGuess[i] = true;
                return true;
            }
        }

        return false;
    }

    // print board: ex _ _ _
    private void printBoard(string word, Boolean[] correctedGuess)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (correctedGuess[i])
                Console.Write(word[i]);
            else
                Console.Write(" _ ");
        }
        Console.WriteLine();

    }
}
