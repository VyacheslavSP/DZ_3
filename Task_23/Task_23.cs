// запишите программу которое принимает на вход число и выдает таблицу кубов от 1 до N
bool Flag_correct=false;
bool falg_negativ=false;
double Res=0;
int count=1;
int N=0;
while (Flag_correct== false)
{
  string tmp_answer="";
  Console.WriteLine("Введите  число ");
  String Temp_numbers = Console.ReadLine();
  try
  {
    N=int.Parse(Temp_numbers); // попробуй преобразовать к int. если ошибка то float,str etc
    if (N<0)
    {
      falg_negativ=true;
      Flag_correct=true;
    }
    else
    {
      Flag_correct=true;
    }
  }
  catch
  {
    Console.WriteLine("некорректный ввод числа");
  }
}
if(!falg_negativ)
{
  while(count<=N)
  {
    Console.Write(Math.Pow(count, 3));
    if(count<N)
    {
      Console.Write(", ");
    }
    count=count+1;
  }
}
else
{
  while(count>=N)
  {
    Console.Write(Math.Pow(count, 3));
    if(count>N)
    {
      Console.Write(", ");
    }
    count=count-1;
  }
}
