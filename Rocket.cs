using System;
using System.Collections.Generic;
using System.Text;

namespace SingleInheritance
{
    public class Rocket : GameObject
    {

        public Rocket(int size, Position position)
            : base(position)
        {
            this.Size = size;
        }

        public int Size { get; set; }

        public override void Draw()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.SetCursorPosition(Position.Y, Position.X + i);
                Console.WriteLine("|");
            }

        }
    }
}
