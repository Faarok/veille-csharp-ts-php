void main() {
    System.Console.Write("Entrez un nombre : ");
    int userInput = Convert.ToInt32(Console.ReadLine());
    int result = 0;

    while(userInput > 0) {
        result += userInput;
        userInput--;
    }

    System.Console.WriteLine(result);
}

main();