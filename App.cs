public class App
{
    public void Start(){
        // string action = getAction("Welcome to the Card Game! Please enter your action (start | stop | [number of plates]):");
        // if (int.TryParse(action, out int numberOfPlates)){
        //     Console.WriteLine("Starting the game...");
        //     Console.WriteLine($"Need to create {numberOfPlates} plates.");

        // }
        // else if (action.ToLower() == "exit"){

        //     Console.WriteLine("Stopping the game...");
        // }
        // else{
        //     Console.WriteLine("Invalid action. Please try again.");
        // }

        Plate plate = Plate.CreatePlate();
        plate.Show();


    }

    public string getAction(string message){
        Console.WriteLine(message);
        return Console.ReadLine() ?? string.Empty;
    }
}