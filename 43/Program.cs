const int COEFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y={lineData1[COEFICIENT]}*x+{lineData1[CONSTANT]} и y={lineData2[COEFICIENT]}*x+{lineData2[CONSTANT]}");
    Console.WriteLine($" имеет координаты ({coord[X_COORD]},{coord[Y_COORD]})");
}

double Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);

    return result;
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFICIENT] = Prompt($"Введите коэффициент для {numberOfLine} прямой > ");
    lineData[CONSTANT] = Prompt($"Введите константу для {numberOfLine} прямой > ");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (lineData1[CONSTANT]- lineData2[CONSTANT]) / (lineData2[COEFICIENT] - lineData1[COEFICIENT]);
    coord[Y_COORD] = lineData1[CONSTANT]* coord[X_COORD]+ lineData1[CONSTANT];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if(lineData1[COEFICIENT] == lineData2[COEFICIENT])
    {
        if(lineData1[CONSTANT] == lineData2[CONSTANT])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}
