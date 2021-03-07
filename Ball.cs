using System;
using System.Collections.Generic;
using System.Text;

namespace SingleInheritance
{
    class Ball : GameObject
    {
        public Ball(Position position, Direction direction) : base(position)
        {
            this.Direction = direction;
        }

        public Direction Direction { get; set; }

        public override void Draw()
        {
            Console.SetCursorPosition(Position.Y, Position.X);
            Console.WriteLine("@");
        }
    }
}
