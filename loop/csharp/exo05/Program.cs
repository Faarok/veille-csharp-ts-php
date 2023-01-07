void main() {
    int userInput;
    string? userString = "";
    int result;

    while(!int.TryParse(userString, out userInput)) {
        System.Console.Write("Entrez un nombre : ");
        userString = Console.ReadLine();
    }

    result = userInput;

    for(int i = 1; i < userInput; i++) {
        result *= i;
        System.Console.WriteLine("i = " + i + " ; result = " + result);
    }

    System.Console.WriteLine("La factorielle de " + userInput + " est égale à " + result + ".");
}

main();