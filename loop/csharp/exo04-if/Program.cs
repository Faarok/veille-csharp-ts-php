void main() {
    int rand = new Random().Next(1, 100);
    int userInput;

    for(int i = 0; i < 7; i++) {
        string? userString = "";

        while(!int.TryParse(userString, out userInput)) {
            System.Console.Write("Entrez un nombre : ");
            userString = Console.ReadLine();
        }

        if(userInput == rand) {
            System.Console.WriteLine("Vous avez gagné ! Le nombre mystère était " + rand + " !");
            i = 7;
        }
        else if(userInput > rand) {
            System.Console.WriteLine("C'est moins !");
        }
        else if(userInput != rand && i == 6) {
            System.Console.WriteLine("\nVous avez perdu ! Le nombre mystère était " + rand + " !");
        }
        else {
            System.Console.WriteLine("C'est plus !");
        }

        if(userInput != rand && i == 6) {
            System.Console.WriteLine("\nVous avez perdu ! Le nombre mystère était " + rand + " !");
        }
    }
}

main();