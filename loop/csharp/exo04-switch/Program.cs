void main() {
    int rand = new Random().Next(1, 100);
    int userInput;

    for(int i = 0; i < 7; i++) {
        string? userString = "";

        while(!int.TryParse(userString, out userInput)) {
            System.Console.Write("Entrez un nombre : ");
            userString = Console.ReadLine();
        }

        switch((userInput, rand)) {
            case (> 0, > 0) when userInput == rand:
                System.Console.WriteLine("Vous avez gagné ! Le nombre mystère était " + rand + " !");
                i = 7;
                break;
            case (> 0, > 0) when userInput > rand:
                System.Console.WriteLine("C'est moins !");
                break;
            case (> 0, > 0) when userInput < rand:
                System.Console.WriteLine("C'est plus !");
                break;
        }

        if(userInput != rand && i == 6) {
            System.Console.WriteLine("\nVous avez perdu ! Le nombre mystère était " + rand + " !");
        }
    }
}

main();