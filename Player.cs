
class Player {
    public string name;
    private int age;
    public int score;

    public Player(string aName, int aAge, int aScore) {
        name = aName;
        Age = aAge;
        score = aScore;
    }

    public string Greeting(){
        string greet = "Creating Player with the name " +  name + "...";
        return greet;
    }

    public int GetCommitment(){

        Console.WriteLine($"{name}, gib deine Zahl nicht großer als {score} ...");
        string input = Console.ReadLine();
        int commitment = 0;

        if (!int.TryParse(input, out commitment)){
            //TODO: WHat if input was wrong
            Console.WriteLine("Die Eingabe sind falsch!");
            Console.WriteLine($"Commitment ist {commitment}");
        }
        else {
            Console.WriteLine(commitment);
        }

        while(Convert.ToInt32(input) > score) {
            Console.WriteLine($"Eine falsche Zahl! {commitment} ist großer als {score}. {name}, deine Zahl muss gleich oder niedriger als {score} sein");
            input = Console.ReadLine();
        }

        //todo:commitment has to be the correct value, if the input has been changed in codelines 30-33
        score -= commitment;   
        Console.WriteLine($"Commitment bei {name} ist {commitment}");
        //todo: returnvalue same as comment from line 35
        return commitment;
    }
    
    public int Age {
        get { return Age; }
        set {
            if (value >= 18) {
                age = value;
            } else {
                age = 0;
                Console.WriteLine("Der Zugang ist verboten");
            }
        }
    }
}

