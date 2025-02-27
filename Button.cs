using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10lab
{
    // Класс для обычной кнопки
    public class Button : ControlElement
    {
        protected string ButtonText;

        public Button() : base()
        {
            ButtonText = "";
        }

        public Button(int id, int x, int y, string text) : base(id, x, y)
        {
            ButtonText = text;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Текст кнопки: {ButtonText}");
        }

        // Реализация невиртуального метода ShowNotvirtual для Button
        public new void ShowNotvirtual()
        {
            base.ShowNotvirtual(); 
            Console.WriteLine($"Текст кнопки: {ButtonText}");
        }

        public override void Init(int id, int x, int y, string buttonText)
        {
            base.Init(id, x, y);
            ButtonText = buttonText;


        }

        public override void RandomInit() 
        {
            base.RandomInit();
            string[] texts = { "ОК", "Отмена", "Принять", "Закрыть", "Сохранить" };
            Random rnd = new Random();
            ButtonText = texts[rnd.Next(texts.Length)];
        }
    }
}
