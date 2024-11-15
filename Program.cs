//Spezifische Flage:
bool game = true;
//Der Ball steht für das Ergebniss jedes Durchganges. Die möglichen Werte sind: von -3 bis 3.
int ball = 0;

Console.WriteLine("Das Spiel startet jetzt");

Player player1 = new Player("Marcus", 26, 50);
Player player2 = new Player("Peter", 45, 50);

string halloPlayer1 = player1.Greeting();
string halloPlayer2 = player2.Greeting();

Console.WriteLine(halloPlayer1);
Console.WriteLine(halloPlayer2);

int commitment1 = player1.GetCommitment();
int commitment2 = player2.GetCommitment();

bool res = checkGame(commitment1, commitment2, game);

//HauptLogik:
    
while(res && game) {

Console.WriteLine($"Das Spiel Status ist: {res}");

    if (commitment1 > commitment2){
        ball += 1;
        Console.WriteLine($"{player1.name} hat eine höhere Zahl. Der Ball hat {ball} Position");
        //score - commitment happens in class player and here, choose 1
        // player1.score -= commitment1;
        // player2.score -= commitment2;
        res = checkGame(commitment1, commitment2, game);
        Console.WriteLine($"{player1.name} hat einen neuen Zwischenwert: {player1.score}");
        Console.WriteLine($"{player2.name} hat einen neuen Zwischenwert: {player2.score}");

    } else if(commitment2 > commitment1){

        ball -= 1;
        Console.WriteLine($"{player2.name} hat eine höhere Zahl. Der Ball hat {ball} Position");
        // player1.score -= commitment1;
        // player2.score -= commitment2;
        res = checkGame(commitment1, commitment2, game);
        Console.WriteLine($"{player1.name} hat einen neuen Zwischenwert: {player1.score}");
        Console.WriteLine($"{player2.name} hat einen neuen Zwischenwert: {player2.score}");
    }

    while (commitment1 == commitment2) {
        Console.WriteLine($"Die Werte sind gleiche! Player geben jetzt ihnre Eingane erneut.");
        commitment1 = player1.GetCommitment();
        commitment2 = player2.GetCommitment();
    }

    if (player1.score == 1 && player2.score == 1 && ball == 0){
         Console.WriteLine($"Der Gleichstand");
         game = false;
    }
}

 bool checkGame(int commitment1, int commitment2, bool game){

    if(ball == 3) {
        Console.WriteLine($"{player1.name} hat gewinnt. Das Ende des Spieles ");
        game = false;
    }
    else if(ball == -3) {
        Console.WriteLine($"{player2.name} hat gewinnt. Das Ende des Spieles");
        game = false;
    }
  
    else if(commitment1 == 0){
        Console.WriteLine("Player 1 hat verspielt. Das Ende des Spieles");
        game = false;
    }
    else if(commitment2 == 0){
        Console.WriteLine("Player 2 hat verspielt. Das Ende des Spieles");
        game = false;
    }
    return game;
}

