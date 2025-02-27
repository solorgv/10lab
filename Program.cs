namespace _10lab
{
    internal class Program
    {
        static void Main()
        {
            // Создаем массив элементов управления
            ControlElement[] elements = new ControlElement[20];
            Random rnd = new Random();

            // Инициализируем массив случайными объектами
            for (int i = 0; i < elements.Length; i++)
            {
                // Случайно выбираем тип элемента управления
                int type = rnd.Next(3);
                switch (type)
                {
                    case 0:
                        elements[i] = new ControlElement();
                        break;
                    case 1:
                        elements[i] = new Button();
                        break;
                    case 2:
                        elements[i] = new MultipleChoiceButton();
                        break;
                    case 3:
                        elements[i] = new TextField();
                        break;
                }
                elements[i].RandomInit();
            }

            Console.WriteLine("\nДемонстрация вызовов виртуальных методов:");
            foreach (var element in elements)
            {
                element.Show();
                Console.WriteLine();
            }

            // Демонстрация разницы между виртуальными и невиртуальными методами
            Console.WriteLine("\nДемонстрация разницы между виртуальными и невиртуальными методами:");

            ControlElement baseRef = new Button(1, 10, 20, "Тестовая кнопка");

            // Виртуальный метод - вызовет реализацию класса Button
            Console.WriteLine("Вызов виртуального метода Show() через ссылку на базовый класс:");
            baseRef.Show();

            // Невиртуальный метод - вызовет реализацию базового класса
            Console.WriteLine("\nВызов невиртуального метода ShowNotvirtual() через ссылку на базовый класс:");
            baseRef.ShowNotvirtual();
        }
    }
}