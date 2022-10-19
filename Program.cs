// Chris Martinez
//10/19/22
// Number Reverse - Revampt
// GitHub Challenge
// I was able to add validation on this project, when before the github challenge, I was unable to complete.


string gameOver = "yes";
while (gameOver != "no") 

{

    Console.Clear();

    int num = 0;

    int reverse = 0;

			bool validation = false;
			while (validation == false)
			{
    Console.WriteLine("Select a SET of numberz : ");
				string userInput = Console.ReadLine();
				bool isConverted = Int32.TryParse(userInput, out num);
			if (isConverted == false)
			{
				Console.WriteLine("Your Input is not Recognize! TRY AGAIN");
			}else 
			{
				validation = true;
			}
			}
    while (num > 0)

    {

        reverse = reverse * 10 + num % 10;

        num = num / 10;

    }

    Console.WriteLine("/////Your Reversed number is : {0}", reverse);

    Console.WriteLine("//////Do you want to play again?//////");

    Console.WriteLine("//////yes / no");

    gameOver = Console.ReadLine().ToLower();

    Console.WriteLine("********GAME OVER********");

}