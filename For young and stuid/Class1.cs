using System;


namespace For_young_and_stuid
{
    class Class1
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
            
            int start, limit;
            int res;
            uint countEven = 0;
            uint countNotEven = 0;
            int resSumEven = 0;
            int resSumNotEven = 0;
            Console.WriteLine("Я скажу тебе красотка, сколько чисел чётных и не чётных в том диапазоне который ты задашь)");

            try
            {

                Console.WriteLine("Диапазон от ");
                start = Convert.ToInt32(Console.ReadLine());
                               
                Console.WriteLine("до");
                limit = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("Вы вввели что-то не то");
                Console.ReadLine();
                continue;
            }

            

            while (start <= limit)
            {                
                res = start % 2;
                
                if (res == 0)
                {
                    countEven++;
                    resSumEven += start;
                        
                }
                else
                {
                    countNotEven++;
                    resSumNotEven += start;
                        
                }
                    start++;

            }
            Console.WriteLine("Количество чётных чисел " + countEven);
            Console.WriteLine("Количество не чётных чисел " + countNotEven);

            Console.WriteLine("Сумма чётных чисел " + resSumEven);
            Console.WriteLine("Сумма не чётных чисел " + resSumNotEven);

                Console.ReadLine();
            }
        }   
    }
}