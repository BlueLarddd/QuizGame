namespace ConsoleApp1
{
    internal class Answer
    {
        public string[] answears;
        public int correctAnswear;
        public bool isTrue = false;

        public void ShowQuestion()
        {
            for (int i = 0; i < answears.Length; i++)
            {
                Console.WriteLine((i + 1) + " " + answears[i]);

            }

            while (true)
            {
                string answ = Convert.ToString(Console.ReadLine());

                if (answ == Convert.ToString(correctAnswear))
                {
                    isTrue = true;
                    break;
                }

                isTrue = false;
                bool check = false;

                for (int i = 1; i < answears.Length; i++)
                {
                    if (answ == Convert.ToString(i) && answ != Convert.ToString(correctAnswear))
                    {
                        check = true;
                    }
                }
                if (!check)
                {
                    Console.WriteLine("Введите конкретный вариант!");
                }
                else break;

            }
        }
    }
}
