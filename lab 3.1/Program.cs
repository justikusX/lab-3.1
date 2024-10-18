try
{
    int sum = 0; 
    int n; 

    Console.WriteLine("Введите числа (введите 0 для завершения):");

    while (true)
    {
        
        if (int.TryParse(Console.ReadLine(), out n))
        {
            
            if (n == 0)
            {
                break;
            }

            
            if (n < 0)
            {
                sum += n;
            }
        }
        else
        {
            Console.WriteLine("Пожалуйста, введите целое число.");
        }
    }

    Console.WriteLine("Сумма отрицательных чисел: " + sum);
}
catch
{

}