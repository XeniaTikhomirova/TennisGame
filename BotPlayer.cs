
class BotPlayer :Player {
    string name;
    public BotPlayer(string aName,  int aScore) : base(aScore){
        Random rnd = new Random();
        score = rnd.Next(0, score);
        //Console.WriteLine($"Robot hat {score}");
}

    public override void Greeting(){
        Console.WriteLine("Creating Bot Player ...");
    }

    public override int GetCommitment(){

        int commitmentRobot = 0;

        Console.WriteLine($"{name}, stellt seine Zahl ...");

        Random rndRobot = new Random();
        commitmentRobot = rndRobot.Next(1, score);

        Console.WriteLine($"Commitment bei {name} ist {commitmentRobot}");
        return commitmentRobot;
    }

}