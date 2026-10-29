int correct = 0; // Count how many cards does the spectator get correctly.

List<bool> isRedCard = new List<bool>(); // Store Red cards.

while (true) // Magician's turn.
{
    string? s = Console.ReadLine();

    if (s != "") // Check if the magician has finished
    {
        char c = s[s.Length - 1];

        /*
         * If the magician adds a white space, then it is a red card,
         * thus the spectator's card is black, and vice versa.
         */
        isRedCard.Add(!char.IsWhiteSpace(c)); 

        s = s.ToLower().Trim();

        if (s == "correct")
            correct++;
    }
    else
    {
        break;
    }
}

Console.WriteLine("You have got " + correct.ToString() + " correct cards out of "
                  + isRedCard.Count + " cards.");

Console.WriteLine("Enter r for red cards, and b for black cards, lying is allowed.");

for(int i = 0; i < isRedCard.Count; i++) // Spectator's turn.
{
    
    string? s = Console.ReadLine(); // Take the spectator's word.
    
    s = s.ToLower().Trim();
    
    if((s == "r" && isRedCard[i]) || (s == "b" && !isRedCard[i]))
    {
        Console.WriteLine("You are telling the truth!");
    }
    else
    {
        Console.WriteLine("You are lying!");
    }
        
}