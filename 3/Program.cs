Console.WriteLine("Введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < arr.Length / 2; i++)
            {

                sum += arr[i] * arr[arr.Length - 1 - i];
            }

            Console.WriteLine("Сумма произведений пар чисел в одномерном целочисленном массиве: " + sum);
            Console.ReadLine();

