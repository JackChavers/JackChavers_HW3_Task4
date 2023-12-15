// MIS 3013 HW3 Task 4
// Grades problem


string outMesStr;
string userChoiceStr;

int numOfStusInt = 0;
double sumOfAllFinalGrades = 0;

int numLevel1Int = 0;
int numLevel2Int = 0;
int numLevel3Int = 0;
do
{
    numOfStusInt++;

    outMesStr = string.Format($"Student {numOfStusInt} exam 1 grade: ");
    Console.Write(outMesStr);
    string exam1GradeStr = Console.ReadLine();
    double exam1GradeDbl = Convert.ToDouble(exam1GradeStr);

    outMesStr = string.Format($"Student {numOfStusInt} exam 2 grade: ");
    Console.Write(outMesStr);
    string exam2GradeStr = Console.ReadLine();
    double exam2GradeDbl = Convert.ToDouble(exam2GradeStr);

    outMesStr = string.Format($"Student {numOfStusInt} exam 3 grade: ");
    Console.Write(outMesStr);
    string exam3GradeStr = Console.ReadLine();
    double exam3GradeDbl = Convert.ToDouble(exam3GradeStr);

    double finalGradeDbl = (exam1GradeDbl + exam2GradeDbl + exam3GradeDbl) / 3.0;

    if(finalGradeDbl<80)
    {
        Console.WriteLine("Level 1!");
        numLevel1Int++;
    }
    else if(finalGradeDbl>=60)
    {
        Console.WriteLine("Level 2!");
        numLevel2Int++;
    }    
    else
    {
        Console.WriteLine("Level 3!");
        numLevel3Int++;
    }

    sumOfAllFinalGrades = sumOfAllFinalGrades + finalGradeDbl;

    outMesStr = string.Format($"Final grade is {finalGradeDbl:F2}");
    Console.Write(outMesStr);

    outMesStr = "Do you want to enter another student's grades? (yes/no) ";
    Console.Write(outMesStr);
    userChoiceStr = Console.ReadLine();

}
while (userChoiceStr == "yes");

Console.WriteLine("Summary Information");

outMesStr=string.Format($"Number of Students: {numOfStusInt}");
Console.WriteLine(outMesStr);

double averageFinalGradeDbl = sumOfAllFinalGrades / numOfStusInt;
outMesStr = string.Format($"Average of final grades is {averageFinalGradeDbl:F2}");
Console.WriteLine(outMesStr);

outMesStr = string.Format($"Level 1: {numLevel1Int} out of {numOfStusInt}, {1.0*numLevel1Int / numOfStusInt:P2}");
Console.WriteLine(outMesStr);

outMesStr = string.Format($"Level 2: {numLevel2Int} out of {numOfStusInt}, {1.0 * numLevel2Int / numOfStusInt:P2}");
Console.WriteLine(outMesStr);

outMesStr = string.Format($"Level 3: {numLevel3Int} out of {numOfStusInt}, {1.0 * numLevel3Int / numOfStusInt:P2}");
Console.WriteLine(outMesStr);






Console.ReadLine();