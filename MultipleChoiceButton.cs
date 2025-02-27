using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10lab
{
    // Класс для кнопки множественного выбора
    public class MultipleChoiceButton : Button
    {
        protected bool IsSelected;

        public MultipleChoiceButton() : base()
        {
            IsSelected = false;
        }

        public MultipleChoiceButton(int id, int x, int y, string text, bool selected)
            : base(id, x, y, text)
        {
            IsSelected = selected;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Выбрана: {IsSelected}");
        }

        // Реализация невиртуального метода ShowNotvirtual 
        public new void ShowNotvirtual()
        {
            base.ShowNotvirtual(); // Вызов невиртуального метода из класса Button
            Console.WriteLine($"Выбрана: {IsSelected}");
        }

        public override void Init()
        {
            base.Init();
            Console.WriteLine("Кнопка выбрана? (true/false):");
            IsSelected = bool.Parse(Console.ReadLine());
        }












        public override void RandomInit()
        {
            base.RandomInit();
            Random rnd = new Random();
            IsSelected = rnd.Next(2) == 1;
        }
    }
}
