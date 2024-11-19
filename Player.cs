
class Player {
    public string Name {get; set;}
    //public double Age {get; set;}
    public int Score{get; set;}

    public Player(string aName, int aScore) {
        Name = aName;
        // Age = aAge;
        Score = aScore;
    }

    public Player(int score)
    {
        this.Score = score;
    }

    public virtual void Greeting(){
        Console.WriteLine("Creating Player with the name " +  Name + "...");
    }

    public virtual int GetCommitment(){

        int commitment = 0;

    while (true) {
        Console.WriteLine($"{Name}, gib deine Zahl nicht großer als {Score} ...");
        string input = Console.ReadLine();
    
        bool res = int.TryParse(input, out commitment);

        if (!res){
            //TODO: WHat if input was wrong
            Console.WriteLine("Die Eingabe ist falsch!");
            Console.WriteLine($"Commitment ist {commitment}");
            continue;
        }

        else if (commitment > Score) {
            Console.WriteLine($"Eine falsche Zahl! {commitment} ist großer als {Score}. {Name}, deine Zahl muss gleich oder niedriger als {Score} sein");
        }

        else if (commitment == 0) {
            Console.WriteLine($"Eine falsche Zahl! {commitment} ist 0. {Name}, deine Zahl muss gleich 0 nicht sein");
        }

        else {
            break;
        }
    }

        //todo:commitment has to be the correct value, if the input has been changed in codelines 30-33
        //score -= commitment;  

        Console.WriteLine($"Commitment bei {Name} ist {commitment}");
        //todo: returnvalue same as comment from line 35
        return commitment;
    }

    public int doSubstruct(int commitment){
        Score -= commitment;
        return Score;
    }
    
    // public double Age {
    //     get { return Age; }
    //     set {
    //         if (value >= 18) {
    //             Age = value;
    //         } else {
    //             Age = 0;
    //             Console.WriteLine("Der Zugang ist verboten");
    //         }
    //     }
    // }
}

