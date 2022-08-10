void FindStr()
{
    Console.WriteLine("Введите через пробел string эллементы массива:");
    string s = Console.ReadLine();
    string[] array = s.Split(' ');
    string[] arraytwo = new string[array.Length];
    for (int i = 0; i < arraytwo.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arraytwo[i] = array[i];
            Console.Write($"{arraytwo[i]} ");
        }
    } 
}
FindStr();