int m;
int n;

Console.WriteLine("Введите кол-во строк:");
m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов:");
n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

int getRows(int m, int n) 
{ 
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine($"Введите значение для элемента {i}:{j}");
            int value = Convert.ToInt32(Console.ReadLine());
    
            matrix[i, j] = value;
        }
    }
    
    int[] array = new int[m];
    
    
    
    for (int i = 0; i < m; i++)
    {
        int plus = 0;
        int minus = 0;
        int zero = 0;
    
        for (int j = 0; j < n; j++)
        {
            if (matrix[i, j] > 0)
            {
                plus++;
            }    
            else if (matrix[i, j] == 0)
            {
                zero++;
            }
            else
            {
                minus++;
            }
        }
    
        if (plus > minus)
        {
            int pos = i + 1;
            Console.WriteLine($"Строка с большим количеством положительных числел: {pos}");
        }
    return 1;
}

getRows(m, n);
