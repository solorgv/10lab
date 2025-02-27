using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10lab
{
    public class ControlElement:IInit

    {
        protected int Id;
        protected int X;
        protected int Y;

        public int ID
        {
            get => Id;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Номер не может быть отрицательным");
                Id = value;
            }
        }

        public virtual void Show()
        {
            Console.WriteLine($"Элемент управления: ID: {Id}, Позиция: ({X}, {Y})");
        }

        public void ShowNotvirtual()
        {
            Console.WriteLine($"ID: {Id}, Позиция: ({X}, {Y})");
        }

        // Интерфейс диктует тип void Init(), а тут void Init(int, int, int) -- подумоц что делать в других местах ругается сильно 
        public virtual void Init(int id, int x, int y)
        {
            ID = id;
            X = x;
            Y = y;
        }

        public virtual void RandomInit()
        {
            Random rnd = new Random();
            ID = rnd.Next(1000);
            X = rnd.Next(-100, 101);
            Y = rnd.Next(-100, 101);
        }

        // Конструктор по умолчанию
        public ControlElement()
        {
            ID = 0;
            X = 0;
            Y = 0;
        }

        // Конструктор с параметрами
        public ControlElement(int id, int x, int y)
        {
            ID = id;
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj is ControlElement other)
                return ID == other.ID && X == other.X && Y == other.Y;
            return false;
        }
    }
}
