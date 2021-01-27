using System;
using Raylib_cs;

namespace fghbj
{
    class Program
    {
        static void Main(string[] args)
        {

            int mainX = 375;
            int mainY = 300;
            int speedxE = 2;
            int speedyE = 2;
            int eW = 40;
            int eH = 40;


            Raylib.InitWindow(800, 600, "CUBE");
            Raylib.SetTargetFPS(60);

            Random generator = new Random();
            int eX = generator.Next(760);
            int eY = generator.Next(560);
            Rectangle rP = new Rectangle(mainX, mainY, 40, 40);
            Rectangle rE = new Rectangle(eX, eY, eH, eW);



            bool pause = false;

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                //background
                Raylib.ClearBackground(Color.WHITE);
                Raylib.DrawText("DEN BITS!, SPRING MED WASD", 5, 0, 50, Color.RED);

                //character
                Raylib.DrawRectangle(mainX, mainY, 40, 40, Color.ORANGE);
                if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                {
                    mainY += -2;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                {
                    mainY += 2;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    mainX += -2;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                    mainX += 2;
                }

                // Enemy
                Raylib.DrawRectangle(eX, eY, eH, eW, Color.RED);

                if (!pause) eX += speedxE;
                if (!pause) eY += speedyE;
                if (((eX + eW) >= Raylib.GetScreenWidth()) || (eX <= 0)) speedxE *= -1;
                if (((eY + eH) >= Raylib.GetScreenHeight()) || (eY <= 0)) speedyE *= -1;

                //kollision
                bool isColliding = Raylib.CheckCollisionRecs(rP, rE);
                if (isColliding == true)
                {
                    Raylib.DrawText("AAAAA du dog!!!", 300, 200, 50, Color.BLACK);
                }




                Raylib.EndDrawing();

            }


        }
    }
}
