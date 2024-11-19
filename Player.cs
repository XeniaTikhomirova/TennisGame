
class Player {
    public string name;
    //private double age;
    public int score;

    public Player(string aName, int aScore) {
        name = aName;
        //Age = (int)Convert.ToDouble(aAge);
        score = aScore;
    }

    public Player(int score)
    {
        this.score = score;
    }

    public virtual void Greeting(){
        Console.WriteLine("Creating Player with the name " +  name + "...");
    }

    public virtual int GetCommitment(){

        int commitment = 0;

        while (true) {
            Console.WriteLine($"{name}, gib deine Zahl nicht großer als {score} ...");
            string input = Console.ReadLine();
        
            bool res = int.TryParse(input, out commitment);

            if (!res){
                //TODO: WHat if input was wrong
                Console.WriteLine("Die Eingabe ist falsch!");
                Console.WriteLine($"Commitment ist {commitment}");
                continue;
            }

            else if (commitment > score) {
                Console.WriteLine($"Eine falsche Zahl! {commitment} ist großer als {score}. {name}, deine Zahl muss gleich oder niedriger als {score} sein");
            }

            else if (commitment == 0) {
                Console.WriteLine($"Eine falsche Zahl! {commitment} ist 0. {name}, deine Zahl muss gleich 0 nicht sein");
            }

            else {
                break;
            }
        }
    
        //todo:commitment has to be the correct value, if the input has been changed in codelines 30-33
        //score -= commitment;  

        Console.WriteLine($"Commitment bei {name} ist {commitment}");
        //todo: returnvalue same as comment from line 35
        return commitment;
    }

    public int doSubstruct(int commitment){
        score -= commitment;
        return score;
    }
    
    // public int Age {
    //     get { return Age; }
    //     set {
    //         if (value >= 18) {
    //             age = value;
    //         } else {
    //             age = 0;
    //             Console.WriteLine("Der Zugang ist verboten");
    //         }
    //     }
    // }
}

