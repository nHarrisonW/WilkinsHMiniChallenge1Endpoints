using Microsoft.AspNetCore.Mvc;

namespace endPointsWontWork.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge1Controller : ControllerBase
{
        [HttpGet]
    [Route("MiniChallenge1")]
    public string SayHello()
    {
        return "HELLO HUMAN!";
    }
        [HttpGet]
    [Route("MiniChallenge2")]
    public int AddingNumbers()
    {
        return 400 + 20;
    }
        [HttpGet]
    [Route("MiniChallenge3")]
    public string AskingQuestions(string name = "Harrison", string time = "6AM")
    {
        return $"HELLO {name}! {time} sure is early!";
    }
        [HttpGet]
    [Route("MiniChallenge4")]
    public string GreaterOrLess(int firstNumber = 420, int secondNumber = 68)
    {
        if(firstNumber > secondNumber){

        return $"{firstNumber} is greater than {secondNumber}";
        }
        if(firstNumber < secondNumber){

        return $"{firstNumber} is less than {secondNumber}";
        }else{

        return $"{firstNumber} is equal to {secondNumber}";
        }
        
    }
        [HttpGet]
    [Route("MiniChallenge5")]
    public string MadLib()
    {

        return "THIS PROGRAM WILL ALLOW THE USER TO INPUT WORDS TO CHANGE THE ANSWERS OF A PARAGRAPH FOR FUNNY ANSWERS! \n Ex : THE crazy LADY RAN FOR THE blue BASKETBALL AS IT BOUNCED OVER THE moon!";
    }
        [HttpGet]
    [Route("MiniChallenge6")]
    public string OddOrEven()
    {

        return "THIS PROGRAM WILL ALLOW THE USER TO INPUT A NUMBER, AN WILL TELL THEM IF IT IS ODD OR EVEN! \n Ex : Input : 12! \n Output : EVEN";
    }
        [HttpGet]
    [Route("MiniChallenge7")]
    public string ReverseIt()
    {

        return "THIS PROGRAM WILL WILL TAKE THE USER'S INPUT AND REVERSE IT! \n Ex : Input : HELLO HUMAN! \n Output : !NAMUH OLLEH";
    }
            [HttpGet]
    [Route("MiniChallenge8")]
    public string Magic8Ball()
    {
        string [] response = {"YES", "NO", "MAYBE SO"};
        Random rnd = new Random();
        int index = rnd.Next();
        return "THIS PROGRAM SHOULD RETURN A RANDOM RESPONSE EVERYTIME USER RUNS PROGRAM! \n {response[index]}";
    }
            [HttpGet]
    [Route("MiniChallenge9/{option}")]
    public string ResturauntPicker(string option)
    {
        Random rnd = new Random();
        string[] chineseFoodArray = {"Uncle Yu's", "Mei Mei's", "China Wok", "The Banana Garden", "The Amazing Kitchen", "Panda Express", "Midori", "Golden Eagle Resturaunt", "Fortune Garden", "Ling Nam Express"};
        string[] fastFoodArray = {"McDonald's", "Burger King", "Five Guy's Burger and Fries", "Chick Fil-A", "Habit Burger", "Popeye's", "Wing Stop", "Little Caesar's", "Wendy's", "Chipotle"};
        string[] mexicanFoodArray = {"La Costa", "Taqueria La Mexicana", "El Pollo Loco", "El Comal Taco Truck", "La Casita", "Tacos Chapala", "La Kositas", "Birrieria Jalisco", "Tacos El Pelon", "Taco Bell"};
        int chineseFoodIndex  = rnd.Next(chineseFoodArray.Length);
        int fastFoodIndex  = rnd.Next(chineseFoodArray.Length);
        int mexicanFoodIndex  = rnd.Next(chineseFoodArray.Length);


        if(option == "chineseFoodArray") return chineseFoodArray[chineseFoodIndex];
        if(option == "fastFoodArray") return fastFoodArray[fastFoodIndex];
        if(option == "mexicanFoodArray") return mexicanFoodArray[mexicanFoodIndex];


        return " \n THIS PROGRAM WILL WILL TAKE THE USER'S INPUT AND REVERSE IT! \n Ex : Input : HELLO HUMAN! \n Output : !NAMUH OLLEH";
    }
}
