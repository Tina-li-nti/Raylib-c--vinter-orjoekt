using System;
using Raylib_cs;

namespace fghbj
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "GrafikDemo");
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.EndDrawing();
            }
        }
    }
}
