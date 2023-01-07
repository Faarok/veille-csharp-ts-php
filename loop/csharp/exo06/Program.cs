void main() {
    int userInput = 0;
    int result = 0;

    while(userInput < 1) {
        string? userString = "";

        while(!int.TryParse(userString, out userInput)) {
            System.Console.Write("Entrez un nombre : ");
            userString = Console.ReadLine();
        }
    }
    
    for(int i = userInput; i > 0; i--) {
        if(i % 2 == 0) {
            result += i;
        }
    }

    System.Console.WriteLine("User input = " + userInput + "\nResult = " + result);
}

main();