// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------
home:
Console.Clear();
System.Console.WriteLine("Welcome to, my Project");
System.Console.WriteLine("1.IELTS Score Calculator:");
System.Console.WriteLine("2.Drawer");

System.Console.Write("Enter command (1 or 2): ");
int command = Convert.ToInt32(Console.ReadLine());

if(command == 1)
{

  System.Console.Write("Listening(ball): ");
  double listeningScore = Convert.ToDouble(Console.ReadLine());
  System.Console.Write("Reading(ball): ");
  double readingScore = Convert.ToDouble(Console.ReadLine());
  System.Console.Write("Writing(ball): ");
  double writingScore = Convert.ToDouble(Console.ReadLine());
  System.Console.Write("Speaking(ball): ");
  double speakingScore = Convert.ToDouble(Console.ReadLine());

  //Overall
  double overallScore = (listeningScore + readingScore + writingScore +
                                    speakingScore) / 4;
  double floatScore = overallScore - (int)overallScore;

if(floatScore < 0.25)
  floatScore = 0;
else if(floatScore >= 0.25 && floatScore <= 0.5)
  floatScore = 0.5;
else if(floatScore > 0.5)
  floatScore = 1;

overallScore = (int)overallScore + floatScore;
System.Console.WriteLine($"Overall: {overallScore}");
  switch(overallScore){
    case 9:
    case 8.5:
      System.Console.WriteLine("Expert");
      break;
    case 8:
    case 7.5:
      System.Console.WriteLine("Very Good");
      break;
    case 7:
    case 6.5:
      System.Console.WriteLine("Good");
      break;
    case 6:
    case 5.5:
      System.Console.WriteLine("Competent");
      break;
    case 5:
      System.Console.WriteLine("Modest");
      break;


  }

System.Console.WriteLine("Do you want to continue? Yes / No : ");
string gotoHome = Console.ReadLine();

if(gotoHome == "Yes")
{
  goto home;

}
}
else if(command == 2)
{
  string triangle = @"
                          *
                         * *
                        *   *
                       *     *
                      *       *
                    * * * * * * *
                    ";
  string square = @"
                    * * * * * * *
                    *           *
                    *           *
                    *           *
                    * * * * * * *
                    ";
  string trapezium = @"
                    * * * * * * *
                  *               *
                *                   *
              * * * * * * * * * * * * *
              ";
  Console.Clear();
  System.Console.WriteLine("==== Draw ====");
  System.Console.WriteLine("1. Triangle");
  System.Console.WriteLine("2. Square");
  System.Console.WriteLine("3. Trapezium");

  System.Console.Write("Enter command: ");
  int commandDraw = Convert.ToInt32(Console.ReadLine());

  string result = commandDraw switch{
    1 => triangle,
    2 => square,
    3 => trapezium,
  };
System.Console.WriteLine(result);

System.Console.WriteLine("Do you want to continue? Yes / No : ");
string gotoHome = Console.ReadLine();

if(gotoHome == "Yes")
{
  goto home;

}


}