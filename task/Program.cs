string[] FillArray (string[] array, int sizeString)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= sizeString)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    int index = 0;

    for(int i = 0; i < array.Length; i++)
    {
       if(array[i].Length <= sizeString)
        {
            newArray[index] = array[i];
            index++;
        } 
    }
    return newArray;
}

string[] array = {"name", "world", "-2", "www", "hello", ":-)", "afsdgergheher"};
string[] newArray = FillArray (array, 3);

Console.Write($"[{string.Join(',', array)}] -> [{string.Join(',', newArray)}] ");