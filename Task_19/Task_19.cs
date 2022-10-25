/* Напишите программу,которая принимает на вход пятизначное число и проверяет, являетсяли они палиндромом*/
Console.WriteLine("Введите целое число :"); //искуственное ограничение в длину минимум 3 символа не считая знака
string tmp_num=Console.ReadLine();
long numb=0;
sbyte capacity=0;
sbyte count_cycles=0;
bool parity=false;

try
{
  numb=Int64.Parse(tmp_num);
  numb=Math.Abs(numb);      // в данной задаче знак не важен
}
catch
{
  Console.WriteLine("Вы ввели неккоректное число");
}
tmp_num= numb.ToString();
if(tmp_num.Length<=2)
{
  Console.WriteLine("Вы ввели число меньше 3 цифр");
}
else
{
  capacity=Convert.ToSByte(Math.Ceiling(Math.Log10(numb)));
  count_cycles= Convert.ToSByte(capacity/2);      //количество циклов работает за счет округления при преобразование в беззнаковый байт
  sbyte[] ARR_numb = new sbyte[capacity];           // формально в решении я не воспользовался сравнением именно строковых символов. если требуется прямо голая математика, тогда через бесконечные остатки от деления находим так же пары чисел и сравниваем
  for (int i = 0; i < capacity; i++)
  {
    string TMP_CHAR=tmp_num[i].ToString();
    ARR_numb[i]=Convert.ToSByte(TMP_CHAR);
  }
  for (int i = 0; i < count_cycles; i++)        // сравни в цикле i цифру и длина -1-i цифру
  {
    sbyte TMP_CHAR_1=  ARR_numb[i];
    sbyte TMP_CHAR_2=  ARR_numb[ARR_numb.Length-1-i];
    if (TMP_CHAR_1!=TMP_CHAR_2)
    {
      Console.WriteLine("Число не палиндром");
      return;
    }
  }
  Console.WriteLine("Число палиндром");
}
