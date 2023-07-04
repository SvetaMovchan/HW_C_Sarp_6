/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X = 0;
const int Y = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if (ValidateLines(lineData1, lineData2)){
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений у={lineData1[COEFFICIENT]}*х+{lineData1[CONSTANT]} и у={lineData2[COEFFICIENT]}*х+{lineData2[CONSTANT]} ");
    Console.WriteLine($"имеет координаты ({coord[X]},{coord[Y]})");
}

double Prompt(string message){
    Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int numberOfLine){
    double[] lineData = new double[2];
    lineData[COEFFICIENT] = Prompt($"Введите коэффициент для {numberOfLine} прямой => ");
    lineData[CONSTANT] = Prompt($"Введите константу для {numberOfLine} прямой => ");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2){
    double[] coord = new double[2];
    coord[X] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
    coord[Y] = lineData1[COEFFICIENT] * coord[X] + lineData1[CONSTANT];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2){
    if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT]){
        if (lineData1[CONSTANT] == lineData2[CONSTANT])
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
//x = (b2-b1)/(k1-k2);
//y = (k1*b2-b1*k2)/(k1-k2);

