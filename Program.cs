//Samuel Laguna
//10 - 20 - 22
//We are to redo challenge6 with data validation and a play again feture.


Console.Clear();
int i;
bool playAgain = true;
bool isConverted;
bool end = false;
while (playAgain == true)
{
Console.WriteLine("enter your number here");
     isConverted = Int32.TryParse(Console.ReadLine(), out i);
    Console.WriteLine(i % 2 == 0 ? "even" : "odd");

   

        Console.WriteLine("Enter end to exit, or type play again to restart ");

    // string name = Console.ReadLine();
    string ending = Console.ReadLine();
      
        if (ending == "end")
        {
            playAgain = false;
           end = true;
        }
 



}

