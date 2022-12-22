Console.WriteLine("Введите кол-во чисел, которое хотите ввести");
            List<int> numbers = new List<int>();
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числa:");
            for (int i = 0; i < M; i++)
            {
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Чисел больше нуля: " + numbers.Where(n => n > 0).Count());

            Console.ReadLine();

