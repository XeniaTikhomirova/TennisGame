
class BotPlayer :Player {
    
    public string
     Name {
        get;
        set;
    }

    public BotPlayer(string aName,  int aScore) : base(aScore){
        Random rnd = new Random();
        Score = rnd.Next(0, Score);
        Console.WriteLine($"Robot hat {Score}");
}

    public override void Greeting(){
        Console.WriteLine("Creating Bot Player ...");
    }

    public override int GetCommitment(){

        int commitmentRobot = 0;

        Console.WriteLine($"{Name}, stellt seine Zahl ...");

        Random rndRobot = new Random();
        commitmentRobot = rndRobot.Next(1, Score);

        Console.WriteLine($"Commitment bei {Name} ist {commitmentRobot}");
        return commitmentRobot;
    }

}