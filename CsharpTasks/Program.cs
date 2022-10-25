using CsharpTasks;
// ArraySwaps
int[] inputArray = new int[] { 3, 4, 5, 6 };
var resultArray=ArraySwaps.reversedArray(inputArray);

 foreach (var item in resultArray)
    {
        Console.WriteLine(item.ToString());
    }

//Palindrome
string inputString = new string("Dad");
var resultString = Palindrome.palindromeCheck(inputString);
Console.WriteLine(resultString);

//ChangeNumbersWithDiaganal

int[,] twoDArray = new int[3,3] ;
var resultNumbersDiaganalInput = ChangeNumbersWithDiaganal.inputArray(twoDArray);
var resultNumbersDiaganalOutput = ChangeNumbersWithDiaganal.outputArray(twoDArray);

//GameOfLife

string[,] resultOfInput = GameOfLife.Create2DArray(15, 15);
var result = GameOfLife.startGame(resultOfInput);
Console.WriteLine(result);




