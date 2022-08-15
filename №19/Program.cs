// №19

double [] coord_A = new double [3];
Console.WriteLine ("Введите 3 координаты первой точки (ввод каждой координаты с новой строки):");
for (int i = 0; i < coord_A.Length; i++)
{
    coord_A[i] = Convert.ToDouble(Console.ReadLine());
}

double [] coord_B = new double [3];
Console.WriteLine ("Введите 3 координаты второй точки (ввод каждой координаты с новой строки):");
for (int j = 0; j < coord_B.Length; j++)
{
    coord_B[j] = Convert.ToDouble(Console.ReadLine());
}

double dis0 = (coord_B[0] - coord_A[0])*(coord_B[0] - coord_A[0]);
double dis1 = (coord_B[1] - coord_A[1])*(coord_B[1] - coord_A[1]);
double dis2 = (coord_B[2] - coord_A[2])*(coord_B[2] - coord_A[2]);
double distance = Math.Sqrt(dis0 + dis1 + dis2);
// Думаю, что код со строки 17 по 20 можно упростить, не вводя доп. переменные dis0/1/2
Console.Write("Расстояние между 2 точками = ");
Console.WriteLine(distance);
