
class BotPlayer :Player {
    public BotPlayer(string aName, int aScore) : base(aName, aScore){}
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

        public virtual int doSubstruct(int commitmentRobot){
        score -= commitmentRobot;
        return score;
    }

}