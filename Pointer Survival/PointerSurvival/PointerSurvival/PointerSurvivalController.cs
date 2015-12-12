﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointerSurvival
{
    class PointerSurvivalController : Controller
    {
        public static int Speed = 10;
        public static int TimeToCreateAsteroid = 1;
        public static int BulletSpeed = 1;
        public const int MoveToMouse = 0;
        public const int Fire = 1;
        public const int CreateAsteroid = 2;
        public const int Up = 3;
        public const int Down = 4;
        public const int Left = 5;
        public const int Right = 6;
        

        public override void ActionPerformed(int action)
        {
            foreach (PointerSurvivalModel m in mList)
            {
                switch (action)
                {
                    case MoveToMouse:
                        m.MoveToMouse(Form.MousePosition.X,Form.MousePosition.Y);
                        break;
                    case Fire:
                        m.Fire();
                        break;
                    case CreateAsteroid:
                        m.CreaeAsteroid();
                        break;
                    case Up:
                        m.MoveUp();
                        break;
                    case Down:
                        m.MoveDown();
                        break;
                    case Left:
                        m.MoveLeft();
                        break;
                    case Right:
                        m.MoveRight();
                        break;
                }
            }
        }
    }
}
