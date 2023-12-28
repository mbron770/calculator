// Console.WriteLine("Hello!");
// Console.Write("Input First Number: ");
// string firstNum = Console.ReadLine();
// Console.Write("Input Second Number: "); 
// string secondNum = Console.ReadLine();
// Console.WriteLine("What do you want to do with those numbers? \n[A]dd\n[S]ubtract\n[M]ultiply"); 
// string userChoice = Console.ReadLine();

// if(userChoice == "A" || userChoice == "a") Console.WriteLine($"{firstNum} + {secondNum} = {int.Parse(firstNum) + int.Parse(secondNum)}");
// else if(userChoice == "S" || userChoice == "s") Console.WriteLine($"{firstNum} - {secondNum} = {int.Parse(firstNum) - int.Parse(secondNum)}");
// else if(userChoice == "M" || userChoice == "m") Console.WriteLine($"{firstNum} * {secondNum} = {int.Parse(firstNum) - int.Parse(secondNum)}"); 
// else Console.WriteLine("Invalid Option"); 
// Console.WriteLine("Press any key to close"); 
// Console.ReadKey(); 


//better version 

Console.WriteLine("Hello!");
Console.Write("Input First Number: "); 

var firstNumberString = Console.ReadLine(); 
var firstNumber = int.Parse(firstNumberString); 

Console.WriteLine("Input Second Number: "); 
var secondNumberString = Console.ReadLine(); 
var secondNumber = int.Parse(secondNumberString); 

Console.WriteLine("What do you want to do with those numbers? \n[A]dd\n[S]ubtract\n[M]ultiply"); 
var userChoice = Console.ReadLine();

if(caseConversion(userChoice, "A")) Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
else if(caseConversion(userChoice, "S")) Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
else if(caseConversion(userChoice, "M")) Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
else Console.WriteLine("Invalid Option"); 
Console.WriteLine("Press any key to close"); 
Console.ReadKey(); 

bool caseConversion(string l, string r){
    return l.ToUpper() == r.ToUpper(); 
}






