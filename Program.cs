//Shaun Aguirre-Reyes
//10/17/22
//3:40pm
//this is when the computer decides whether the first number is greater than or less than the 2nd number
//the second test decides whether the first number is equal to or less than the second number

Console.Clear();

string playAgain = "yes";
while(playAgain == "yes"){

Console.WriteLine("We are going to test if the first number is greater than the second number");
Console.WriteLine("Enter the first number");

string num1 = Console.ReadLine();
int num1A = Convert.ToInt32(num1);

Console.WriteLine("Please enter the second number");
string num2 = Console.ReadLine();
int num2B = Convert.ToInt32(num2);

if( num1A > num2B ){
    Console.WriteLine("The first number is greater than the second");
}else{
    Console.WriteLine("The first number is less than the second number");
}

Console.WriteLine("Lets try another example to see if the first number is greater than or equal to the second number");
Console.WriteLine("Enter the first Number");

string num3 = Console.ReadLine();
int num3C = Convert.ToInt32(num3);

Console.WriteLine("Please enter the second number");
string num4 = Console.ReadLine();
int num4D = Convert.ToInt32(num4);

if( num3C >= num4D ){
    Console.WriteLine("The first number is equal to or greater than the second number");
}else{
    Console.WriteLine("This first number isnt equal to or greater than the second number");
}

Console.WriteLine("Do you want to play again?");
playAgain = Console.ReadLine();
if(playAgain == "yes"){
    Console.WriteLine("Lets play again");
}else{
    Console.WriteLine("Have a great day :)");
}

}