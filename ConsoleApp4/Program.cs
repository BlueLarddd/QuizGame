using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Добро пожаловать в квиз-игру!");
            Console.WriteLine("Нажмите Enter, чтобы начать");
            List<int> questionCount = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            string a = Convert.ToString(Console.ReadLine());
            int score = 0;
            bool play = true;
            Random random = new Random();
            Question question = new Question();
            Answer answer = new Answer();

            while (play)
            {
                int rand = 0;
                int i = 0;
                while (i <= 10)
                {

                    if (questionCount.Count > 0)
                        rand = questionCount[new Random().Next(questionCount.Count)];
                    else
                        play = false;

                    if (rand == 1)
                    {
                        i++;
                        question.quest1();
                        answer.answears = new string[] { "животными", "детьми", "инвалидами", "пьяницами" };
                        answer.correctAnswear = 4;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(1);
                    }
                    else if (rand == 2)
                    {
                        i++;
                        question.quest2();
                        answer.answears = new string[] { "хвоста", "зрачков", "ушей", "лап" };
                        answer.correctAnswear = 2;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(2);
                    }
                    else if (rand == 3)
                    {
                        i++;
                        question.quest3();
                        answer.answears = new string[] { "сигарами", "опиумом", "чаем", "шоколадом" };
                        answer.correctAnswear = 4;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(3);
                    }
                    else if (rand == 4)
                    {
                        i++;
                        question.quest4();
                        answer.answears = new string[] { "горьким", "маленьким", "без косточек", "оранжевым" };
                        answer.correctAnswear = 1;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(4);
                    }
                    else if (rand == 5)
                    {
                        i++;
                        question.quest5();
                        answer.answears = new string[] { "месть", "улыбку", "слезы", "рык" };
                        answer.correctAnswear = 1;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(5);
                    }
                    else if (rand == 6)
                    {
                        i++;
                        question.quest6();
                        answer.answears = new string[] { "бабушка и внук", "брат и сестра", "дедушка и внучка", "мама и сын" };
                        answer.correctAnswear = 2;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(6);
                    }
                    else if (rand == 7)
                    {
                        i++;
                        question.quest7();
                        answer.answears = new string[] { "просто так", "не достают", "берегут свои усы", "не видят" };
                        answer.correctAnswear = 3;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(7);
                    }
                    else if (rand == 8)
                    {
                        i++;
                        question.quest8();
                        answer.answears = new string[] { "рыб", "камней", "песка", "ракушек" };
                        answer.correctAnswear = 4;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(8);
                    }
                    else if (rand == 9)
                    {
                        i++;
                        question.quest9();
                        answer.answears = new string[] { "курица", "ящерица", "хамелеон", "белка" };
                        answer.correctAnswear = 1;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(9);
                    }
                    else if (rand == 10)
                    {
                        i++;
                        question.quest10();
                        answer.answears = new string[] { "кивать", "они не умеют по-другому", "просто так", "стабилизировать изображение" };
                        answer.correctAnswear = 4;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(10);
                    }
                    else if (rand == 11)
                    {
                        i++;
                        question.quest11();
                        answer.answears = new string[] { "спуститься", "пойти дальше", "легнуть", "спрыгнуть" };
                        answer.correctAnswear = 1;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(11);
                    }
                    else if (rand == 12)
                    {
                        i++;
                        question.quest12();
                        answer.answears = new string[] { "рисуют", "имя животного", "свое имя", "роспись" };
                        answer.correctAnswear = 3;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(12);
                    }
                    else if (rand == 13)
                    {
                        i++;
                        question.quest13();
                        answer.answears = new string[] { "убирается", "занимается спортом", "ест", "спит" };
                        answer.correctAnswear = 4;

                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(13);
                    }
                    else if (rand == 14)
                    {
                        i++;
                        question.quest14();
                        answer.answears = new string[] { "костей", "вкусовых рецепторов", "пальцев", "желаний" };
                        answer.correctAnswear = 2;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(14);
                    }
                    else if (rand == 15)
                    {

                        i++;
                        question.quest15();
                        answer.answears = new string[] { "Дети", "Женщины", "Мужчины", "Старики" };
                        answer.correctAnswear = 3;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(15);
                    }
                    else if (rand == 16)
                    {
                        i++;
                        question.quest16();
                        answer.answears = new string[] { "шестой палец на левой руке", "рыжая борода", "кадык", "цветочек на голове" };
                        answer.correctAnswear = 2;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(16);
                    }
                    else if (rand == 17)
                    {
                        i++;
                        question.quest17();
                        answer.answears = new string[] { "смотреть друг другу в глаза", "находятся рядом", "не обращать внимания друг на друга", "держаться за руки" };
                        answer.correctAnswear = 1;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(17);
                    }
                    else if (rand == 18)
                    {
                        i++;
                        question.quest18();
                        answer.answears = new string[] { "деревьях", "болоте", "лесу", "кладбищах" };
                        answer.correctAnswear = 4;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(18);
                    }
                    else if (rand == 19)
                    {
                        i++;
                        question.quest19();
                        answer.answears = new string[] { "пищеварение", "реакцию", "старение", "кровообращение" };
                        answer.correctAnswear = 3;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(19);
                    }
                    else if (rand == 20)
                    {
                        i++;
                        question.quest20();
                        answer.answears = new string[] { "убийц", "нищих", "сутенеров", "пилотов" };
                        answer.correctAnswear = 1;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(20);
                    }
                    else if (rand == 21)
                    {
                        i++;
                        question.quest21();
                        answer.answears = new string[] { "кушать за рабочим местом", "читать книги в постели", "ловить пауков у соседей дома", "смотреть в зеркало вечерами" };
                        answer.correctAnswear = 2;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(21);
                    }
                    else if (rand == 22)
                    {
                        i++;
                        question.quest22();
                        answer.answears = new string[] { "полотенца", "шторы", "одежда", "одеяла" };
                        answer.correctAnswear = 1;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(22);
                    }
                    else if (rand == 23)
                    {
                        i++;
                        question.quest23();
                        answer.answears = new string[] { "сложенные в молитве руки", "узелок", "узор", "не знаю" };
                        answer.correctAnswear = 1;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(23);
                    }
                    else if (rand == 24)
                    {
                        i++;
                        question.quest24();
                        answer.answears = new string[] { "лекарство для рогатого скота", "лекарство от кашля", "лекарство от болей в сердце", "суп" };
                        answer.correctAnswear = 2;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(24);
                    }
                    else if (rand == 25)
                    {
                        i++;
                        question.quest25();
                        answer.answears = new string[] { "бактерия", "насекомое", "червь", "рыба" };
                        answer.correctAnswear = 3;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(25);
                    }
                    else if (rand == 26)
                    {
                        i++;
                        question.quest26();
                        answer.answears = new string[] { "птиц", "насекомых", "слонов", "рыб" };
                        answer.correctAnswear = 4;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(26);
                    }
                    else if (rand == 27)
                    {
                        i++;
                        question.quest27();
                        answer.answears = new string[] { "странным", "продающим", "траурным", "приносящим удачу" };
                        answer.correctAnswear = 3;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(27);
                    }
                    else if (rand == 28)
                    {
                        i++;
                        question.quest28();
                        answer.answears = new string[] { "аниме-персонажа", "взрослого мужчину", "камень", "пса" };
                        answer.correctAnswear = 2;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(28);
                    }
                    else if (rand == 29)
                    {
                        i++;
                        question.quest29();
                        answer.answears = new string[] { "столы", "виноград", "жаб", "котов" };
                        answer.correctAnswear = 3;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(29);
                    }
                    else if (rand == 30)
                    {
                        i++;
                        question.quest30();
                        answer.answears = new string[] { "квартиру", "инвалидное кресло", "собственный протез", "слиток золота" };
                        answer.correctAnswear = 3;
                        answer.ShowQuestion();

                        if (answer.isTrue) score++;
                        questionCount.Remove(30);
                    }
                }
            }

            Console.WriteLine("вы набрали: " + score + " баллов");
            Console.ReadKey();
        }

    }
}