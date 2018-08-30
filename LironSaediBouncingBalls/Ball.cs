using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LironSaediBouncingBalls
{

    class Ball
    {
        public int x;
        public int y;
        public int width;
        public int height;

        public int speedX;
        public int speedY;

        public Ball(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void Update()
        { 
            speedX += x;
            speedY += y;
        }

        public void Draw(Graphics gfx)
        {
            gfx.FillEllipse(Brushes.LightCoral, speedX, speedY, width, height);
        }

    }
}
