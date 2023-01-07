void main() {
    int rand = new Random().Next(1, 100);
    int userInput = 0;

    while(userInput != rand) {
        System.Console.Write("Entrez un nombre : ");
        userInput = Convert.ToInt32(Console.ReadLine());

        if(userInput > rand) {
            System.Console.WriteLine("C'est moins !");
        }
        else if(userInput < rand) {
            System.Console.WriteLine("C'est plus !");
        }
    }

    System.Console.WriteLine("Vous avez gagné ! Le nombre à deviner était " + rand + " !");
}

main();