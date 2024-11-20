using System.Reflection.Metadata;

bool game = true;
int ball = 0;
int commitment1;
int commitment2;

Console.WriteLine("Das Spiel startet jetzt");

Player player1 = new Player("Marcus", 50);
//Player player2 = new Player("Peter", 45, 50);
BotPlayer player2 = new BotPlayer("Bot", 50);

player1.Greeting();
player2.Greeting();

while(game) {
    //Console.WriteLine($"Das Spiel Status ist: {game}");

    commitment1 = player1.GetCommitment();
    commitment2 = player2.GetCommitment();

    CheckSubstruckt(player1, player2, commitment1, commitment2);

    

    if (commitment1 > commitment2){
        ball += 1;
        Console.WriteLine($"{player1.name} hat eine höhere Zahl. Der Ball hat {ball} Position");
        game = checkGame(ball, player1, player2, ref game);

    } else if(commitment2 > commitment1){
        ball -= 1;
        Console.WriteLine($"{player2.name} hat eine höhere Zahl. Der Ball hat {ball} Position");
        game = checkGame(ball, player1, player2, ref game);
    }

    else if (commitment1 == commitment2 && player1.score != 1) {
        Console.WriteLine("Die Werte sind gleiche! Player geben jetzt ihre Eingane erneut.");
        Console.WriteLine("Hier müssen wir neue Werte bekommen");
        game = checkGame(ball, player1, player2, ref game);
    }
}

static void CheckSubstruckt(Player player1, Player player2, int commitment1, int commitment2){
    if(commitment1 != commitment2){

    player1.score = player1.doSubstruct(commitment1);
    player2.score = player2.doSubstruct(commitment2);

    Console.WriteLine($"{player1.name} hat einen neuen Zwischenwert: {player1.score}");
    Console.WriteLine($"{player2.name} hat einen neuen Zwischenwert: {player2.score}");
    }
}

static bool checkGame(int ball, Player player1, Player player2, ref bool game){

    if(ball == 3) {
        Console.WriteLine($"{player1.name} hat gewinnt. Das Ende des Spieles ");
        game = false;
    } else if(ball == -3) {
        Console.WriteLine($"{player2.name} hat gewinnt. Das Ende des Spieles");
        game = false;
    } else if(player1.score == 0){
        Console.WriteLine($"{player1.name} hat verspielt. Das Ende des Spieles");
        game = false;
    } else if(player2.score == 0){
        Console.WriteLine($"{player2.name} hat verspielt. Das Ende des Spieles");
        game = false;
    } else if (player1.score == 1 && player2.score == 1 && ball == 0){
        Console.WriteLine($"Der Gleichstand");
        game = false;
    } else if(player1.score == 1 && player2.score == 1 && ball > 0) {
        Console.WriteLine($"{player1.name} hat gewinnt. Das Ende des Spieles ");
        game = false;
    // } else if(player1.score == 1 && player2.score == 1 && ball < 0) {
    //     Console.WriteLine($"{player2.name} hat gewinnt. Das Ende des Spieles ");
    //     game = false;
    }
    return game;
}