//Spezifische Flage:
using System.Reflection.Metadata;

bool game = true;
int ball = 0;
int commitment1;
int commitment2;

Console.WriteLine("Das Spiel startet jetzt");

Player player1 = new Player("Marcus", 26, 50);
Player player2 = new Player("Peter", 45, 50);

string halloPlayer1 = player1.Greeting();
string halloPlayer2 = player2.Greeting();
Console.WriteLine(halloPlayer1);
Console.WriteLine(halloPlayer2);

game = checkGame(ref ball, player1, player2, ref game);

while(game) {
    Console.WriteLine($"Das Spiel Status ist: {game}");

    commitment1 = player1.GetCommitment();
    commitment2 = player2.GetCommitment();


    if (commitment1 > commitment2){
        ball += 1;
        Console.WriteLine($"{player1.name} hat eine höhere Zahl. Der Ball hat {ball} Position");
        game = checkGame(ref ball, player1, player2, ref game);
        Console.WriteLine($"{player1.name} hat einen neuen Zwischenwert: {player1.score}");
        Console.WriteLine($"{player2.name} hat einen neuen Zwischenwert: {player2.score}");

    } else if(commitment2 > commitment1){
        ball -= 1;
        Console.WriteLine($"{player2.name} hat eine höhere Zahl. Der Ball hat {ball} Position");
        game = checkGame(ref ball, player1, player2, ref game);
        Console.WriteLine($"{player1.name} hat einen neuen Zwischenwert: {player1.score}");
        Console.WriteLine($"{player2.name} hat einen neuen Zwischenwert: {player2.score}");
    }

    if (commitment1 == commitment2) {
        Console.WriteLine($"Die Werte sind gleiche! Player geben jetzt ihre Eingane erneut.");
        commitment1 = player1.GetCommitment();
        commitment2 = player2.GetCommitment();
    }

    if (player1.score == 1 && player2.score == 1 && ball == 0){
            Console.WriteLine($"Der Gleichstand");
            game = false;
    }
}

static bool checkGame(ref int ball, Player player1, Player player2, ref bool game){

    if(ball == 3) {
        Console.WriteLine($"{player1.name} hat gewinnt. Das Ende des Spieles ");
        game = false;
    }
    else if(ball == -3) {
        Console.WriteLine($"{player2.name} hat gewinnt. Das Ende des Spieles");
        game = false;
    }
  
    else if(player1.score == 0){
        Console.WriteLine("Player 1 hat verspielt. Das Ende des Spieles");
        game = false;
    }
    else if(player2.score == 0){
        Console.WriteLine("Player 2 hat verspielt. Das Ende des Spieles");
        game = false;
    }
    return game;
}

