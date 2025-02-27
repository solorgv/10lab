using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10lab
{
    // Класс для текстового поля
    public class TextField : ControlElement
    {
        protected string Hint; 
        protected string Text;

        public TextField() : base()
        {
            Hint = "";
            Text = "";
        }

        public TextField(int id, int x, int y, string hint, string text)
            : base(id, x, y)
        {
            Hint = hint;
            Text = text;
        }
        // виртуал метода 
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Подсказка: {Hint}");
            Console.WriteLine($"Текст: {Text}");
        }

        
        public new void ShowNotvirtual()
        {
            base.ShowNotvirtual(); // Вызов невиртуального метода из базового класса
            Console.WriteLine($"Подсказка: {Hint}");
            Console.WriteLine($"Текст: {Text}");
        }

        public override void Init()
        {
            base.Init();
            Console.WriteLine("Введите текст подсказки:");
            Hint = Console.ReadLine();
            Console.WriteLine("Введите текст поля:");
            Text = Console.ReadLine();
        }

        public override void RandomInit()
        {
            base.RandomInit();
            string[] hints = { "Введите имя...", "Введите email...", "Введите телефон...", "Введите адрес..." };
            string[] texts = { "", "Иван ", "snisimov@mail.ru", "89194573138" };
            Random rnd = new Random();
            Hint = hints[rnd.Next(hints.Length)];
            Text = texts[rnd.Next(texts.Length)];
        }
    }
}
