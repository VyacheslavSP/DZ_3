/* напишите задачу, которая принимет на вход координаты двух точек и наход расстояние между ними в 3д прострастве*/
using System.Text.RegularExpressions;
sbyte multidimensional_space=3; //универсальность теоритечески простраств может как угодно много. теоритечески и векторов может быть сколько угодно, но тогда и обхявление массив нужно делать через цикл
bool Check_correct=false;
double RES=0;
double[] Arr_vector_ferst = new double[multidimensional_space];
double[] Arr_vector_second = new double[multidimensional_space];
while(!Check_correct)
{
  Console.WriteLine("Введите " +multidimensional_space+ " координаты первой точки через разделитель кроме '.' или ','");
  string TMP_ferst_vector=Console.ReadLine();
  if(TMP_ferst_vector.IndexOf('.')!=-1)
  {
    Console.WriteLine("Вы во вводе есть символ '.' заменить на символ ','? (y/n)");
    if(Console.ReadLine()=="y")
    {
      TMP_ferst_vector=TMP_ferst_vector.Replace('.', ',');
      Check_correct=true;
    }
    else
    {
      Check_correct=false;
    }
  }
  Check_correct=true;
  if(Check_correct)
  {
    Check_correct=false;
    var arr = Regex.Matches(TMP_ferst_vector, @"-?\d+(\,\d+)?")
    .Cast<Match>()
    .Select(m => m.Value)
    .ToArray();
    if (arr.Length!=multidimensional_space)
    {
      Console.WriteLine("Вы ыыели неверное количество координат. повторите ввод");
      Check_correct=false;
    }
    Array.Resize(ref Arr_vector_ferst, multidimensional_space);
    try
    {
      for (int i = 0; i < arr.Length; i++)
      {
        string item_str = arr[i];
        double item =  Double.Parse(item_str);
        Arr_vector_ferst[i] =item;
      }
      Check_correct=true;
    }
    catch
    {
      Console.WriteLine("Некоррекный ввод координат. повторите ввод");
      Check_correct=false;
    }
  }
}
Check_correct=false;
while(!Check_correct)
{
  Console.WriteLine("Введите " +multidimensional_space+ " координаты второй точки через разделитель кроме '.' или ','");
  string TMP_second_vector=Console.ReadLine();
  if(TMP_second_vector.IndexOf('.')!=-1)
  {
    Console.WriteLine("Вы во вводе есть символ '.' заменить на символ ','? (y/n)");     // просто для частой опечатки
    if(Console.ReadLine()=="y")
    {
      TMP_second_vector=TMP_second_vector.Replace('.', ',');
      Check_correct=true;
    }
    else
    {
      Check_correct=false;
    }
  }
  Check_correct=true;
  if(Check_correct)
  {
    Check_correct=false;
    var arr = Regex.Matches(TMP_second_vector, @"-?\d+(\,\d+)?")
    .Cast<Match>()
    .Select(m => m.Value)
    .ToArray();
    if (arr.Length!=multidimensional_space)
    {
      Console.WriteLine("Вы ыыели неверное количество координат. повторите ввод");
      Check_correct=false;
    }
    Array.Resize(ref Arr_vector_ferst, multidimensional_space);
    try
    {
      for (int i = 0; i < arr.Length; i++)
      {
        string item_str = arr[i];
        double item =  Double.Parse(item_str);
        Arr_vector_second[i] =item;
      }
      Check_correct=true;
    }
    catch
    {
      Console.WriteLine("Некоррекный ввод координат. повторите ввод");
      Check_correct=false;
    }
  }
}
//Console.WriteLine("[{0}]", string.Join(", ", Arr_vector_ferst));
//Console.WriteLine("[{0}]", string.Join(", ", Arr_vector_second));
// блок решения задачи//
for (int i = 0; i < Arr_vector_ferst.Length; i++) // размерность одинакова,поэтому можно использовать любую переменную
{
RES=RES+Math.Pow((Arr_vector_second[i]-Arr_vector_ferst[i]), 2);
}
Console.WriteLine("Результат: "+Math.Sqrt(RES));
