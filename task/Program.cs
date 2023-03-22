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
}