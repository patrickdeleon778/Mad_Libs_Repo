bool playAgain = true;
bool playAgainResponse = true;


string? userAnswer;
string? name, cryptoid, goodFriendStatus, location, videoGame, animal, weapon1, weapon2, celebrity, food; // a bunch of variables in one string that are the fields the user has to input in



    while(playAgain == true)
    {
        playAgainResponse = true;

        Console.Write("Enter a your Name: "); // console asks for what your name is
        name = Console.ReadLine(); // user inputs their name

        Console.Write("Enter a Cryptoid: "); // console asks to input a cryptoid
        cryptoid = Console.ReadLine(); // user inputs a cryptoid

        Console.Write("Enter friend status with Cryptoid: "); // console asks what your relation is with the cryptoid
        goodFriendStatus = Console.ReadLine(); // user inputs relation status

        Console.Write("Enter a Video Game: "); // console asks to input a video game
        videoGame = Console.ReadLine(); // user inputs a video game

        Console.Write("Enter an Animal: "); // console asks to input an animal
        animal = Console.ReadLine(); // user inputs a animal 

        Console.Write("Enter your weapon: "); // console asks to input your weapon of choice
        weapon1 = Console.ReadLine(); // user inputs their weapon

        Console.Write("Enter cryptoid's weapon: "); // console asks to input the cryptoid's weapon on choice 
        weapon2 = Console.ReadLine(); // user inputs crypotoid's weapon

        Console.Write("Enter a Location: "); // console asks to input a location
        location = Console.ReadLine(); // user inputs a location

        Console.Write("Enter a Celebrity: "); // console asks to input a celebrity
        celebrity = Console.ReadLine(); // user inputs a celebrity

        Console.Write("Enter a Food: "); // console asks to input a food
        food = Console.ReadLine(); // user inputs a food


        Console.WriteLine("There once was a person named " + name + " and there was the cryptoid " + cryptoid + ". They are both " + goodFriendStatus + " and they did everything together! Their favorite video game to play together is " + videoGame + ". One day a huge " + animal + " came out of no where and started attacking the two " + goodFriendStatus + ". They both looked for a weapon to defend themselves with. " + name + " found a trusty old " + weapon1 + " and " + cryptoid + " found the most powerful weapon of all. A " + weapon2 + ". They both took turns attacking the scary and viscious " + animal + " until eventually the two " + goodFriendStatus + " scared it away! The two celebrated their victory and decided to go on a vacation. They both decided to go to " + location + ". Once they moved they bumped into the most famous celebrity " + celebrity + " and got their autograph and a picture! After getting their pictures with the amazing " + celebrity + " they decided on going to dinner! The two " + goodFriendStatus + " decided to eat " + food + " and it was DELICIOUS! All in the days work for the two " + goodFriendStatus + ", " + name + " and " + cryptoid); // after gathering all the inputs from the user the console then places them in each catagory and makes a giant story.
        

        while(playAgainResponse == true)
            {
                Console.Write("Do you want to run the program again? (Y/N): "); // console asks if the user wants to run the program again

                userAnswer = Console.ReadLine().ToUpper();

                if(userAnswer == "Y")
                {
                    playAgain = true;
                    playAgainResponse = false;
                }
                else if(userAnswer == "N")
                {
                    playAgain = false;
                    playAgainResponse = false;
                }
                else
                {   
                    playAgain = false;
                    playAgainResponse = true;
                    Console.WriteLine(userAnswer + " isn't a valid response. Please Enter an actual valid response please.");
                }
            }
    }