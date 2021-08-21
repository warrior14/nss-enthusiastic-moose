using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // Ask a question:
    AskQuestion("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
    AskQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
    AskQuestion("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
    AskQuestion("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
}

// void does not return anything:
// AskQuestion() method accepts 3 parameters and uses string interpolation to display the question to the CLI:
void AskQuestion(string question, string yesResponse, string noResponse)
{
    bool isAnswered = MooseAsks($"{question} (Y/N): ");
    // Moose will say something based on the user's response to the question:
    if (isAnswered)
    {
        MooseSays(yesResponse);
    }
    else
    {
        MooseSays(noResponse);
    }
}


// adding an @ in front of the string allows for a multi-line string:
// adding the $ character to the front of the string enables string interpolation:
void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

// return data type of MooseAsks() method is a boolean the takes a question string parameter as an input and interpolates string into the answer
// variable wherein within the while loop is a condition that checks whether the answer is y or n or neither, then returns true or false based 
// on the input:
bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();
    // The while loop iterates through the block of code as long as the specified condition is true: 
    while (answer != "y" && answer != "n") // if the value of the answer variable does not equal to "y" and does not equal to "n", execute code inside
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower(); // record or store the response("y" or "n") to the answer variable
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

