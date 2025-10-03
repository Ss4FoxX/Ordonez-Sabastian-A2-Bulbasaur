// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        //Bulbasaur colours
        //Main Body

        Color[] B1 = { new Color ("62d5b4"), new Color ("c5f652"), new Color ("837b94") };
        Color[] B2 = { new Color ("ac0031"), new Color ("000000") };
        Color[] B3 = { new Color ("a4d541"), new Color ("29ac10"), new Color("bd2041") };
        Color[] B4 = { new Color ("526229"), new Color ("005a00"), new Color("831029") };
        int currentDrawn = 1;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(200, 200);
            Window.SetTitle("Bulbasaur!");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
                currentDrawn++;
            }
            if (Input.IsMouseButtonPressed(MouseInput.Left))
            {
                currentDrawn--;
            }

            if (currentDrawn == 4)
            {
                currentDrawn = 1;
            }
            else if (currentDrawn == 0)
            {
                currentDrawn = 3;
            }

            if (currentDrawn == 1)
            {
                Bulba(400, 400);
            }
            else if (currentDrawn == 2)
            {
                ShinyBulba(800, 800);
            }
            else if (currentDrawn == 3)
            {
                ShinyChari(400, 800);
            }

        }
        void Bulba (int x, int y)
        {
            Draw.FillColor = B1[0];
            Draw.LineSize = 0;
            //legs
            Draw.Quad(22, 69, 35, 72, 34, 98, 21, 97);
            Draw.Quad(42, 69, 55, 74, 54, 97, 42, 97);
            Draw.Quad(55, 74, 70, 72, 68, 92, 57, 91);

            //body
            Draw.Quad(44, 59, 70, 72, 55, 80, 35, 80);
            Draw.Quad(35, 72, 42, 69, 55, 80, 35, 80);
            Draw.Triangle(44, 59, 57, 60, 42, 69);

            Draw.FillColor = B4[0];
            Draw.Triangle(21, 90, 25, 98, 21, 97);
            Draw.Triangle(29, 92, 31, 98, 25, 98);

            Draw.Triangle(42, 96, 44, 92, 45, 96);
            Draw.Triangle(45, 96, 47, 90, 50, 96);
            Draw.Triangle(50, 96, 52, 92, 54, 96);

            Draw.Triangle(57, 92, 58, 87, 60, 92);
            Draw.Triangle(60, 92, 62, 86, 66, 92);
            Draw.Triangle(66, 92, 66, 88, 68, 92);

            //bulb
            Draw.FillColor = B3[0];
            Draw.Quad(65, 28, 53, 64, 50, 59, 48, 52);
            Draw.Quad(65, 28, 53, 64, 61, 66, 68, 59);
            Draw.Quad(65, 28, 33, 45, 37, 58, 47, 60);
            Draw.Quad(65, 28, 78, 66, 70, 72, 58, 66);
            Draw.Triangle(64, 28, 60, 21, 57, 35);
            Draw.Triangle(64, 28, 70, 23, 70, 44);

            //Head
            Draw.FillColor = B1[0];
            Draw.Quad(42, 79, 34, 72, 22, 69, 18, 64);
            Draw.Quad(20, 54, 44, 59, 42, 79, 18, 64);
            Draw.Quad(20, 54, 30, 49, 43, 52, 44, 59);

            //Ears
            Draw.Quad(34, 49, 42, 52, 42, 46, 36, 45);
            Draw.Quad(36, 45, 38, 43, 40, 42, 42, 46);
            Draw.Triangle(20, 55, 24, 52, 20, 48);

            //Mouth
            Draw.FillColor = B2[0];
            Draw.Quad(18, 64, 22, 65, 22, 69, 19, 67);
            Draw.Quad(22, 65, 30, 66, 30, 70, 22, 69);
            Draw.Quad(30, 66, 37, 64, 36, 66, 30, 70);
            Draw.FillColor = Color.White;
            Draw.Triangle(32, 66, 35, 65, 34, 68);
            Draw.Triangle(18, 64, 22, 65, 19, 68);

            //Eyes
            Draw.Quad(32, 58, 34, 56, 36, 57, 39, 67);
            Draw.Quad(32, 58, 39, 67, 39, 60, 32, 62);
            Draw.Quad(32, 62, 39, 60, 36, 62, 34, 63);

            Draw.Quad(19, 65, 21, 55, 22, 58, 18, 58);
            Draw.Quad(18, 59, 22, 58, 22, 60, 18, 60);
            Draw.Quad(18, 60, 22, 60, 21, 62, 19, 62);
            Draw.FillColor = B2[0];
            Draw.Quad(32, 58, 34, 56, 35, 58, 36, 58);
            Draw.Quad(32, 58, 36, 58, 36, 61, 32, 62);
            Draw.Quad(32, 62, 36, 61, 35, 63, 34, 63);

            Draw.Quad(20, 57, 21, 57, 22, 58, 19, 58);
            Draw.Quad(19, 58, 22, 58, 22, 60, 19, 60);
            Draw.Quad(19, 60, 22, 60, 19, 62, 20, 62);

            //darker outlines
            Draw.LineColor = B4[0];
            Draw.LineSize = 2;
            Draw.Line(65, 28, 48, 52);
            Draw.Line(48, 52, 50, 59);
            Draw.Line(65, 28, 68, 59);
            Draw.Line(68, 59, 61, 66);
            Draw.Line(42, 69, 35, 71);
            Draw.Line(35, 71, 22, 69);
            Draw.Line(22, 69, 18, 64);
        }
        void ShinyBulba(int x, int y)
        {
            Draw.FillColor = B1[1];
            Draw.LineSize = 0;
            //legs
            Draw.Quad(22, 69, 35, 72, 34, 98, 21, 97);
            Draw.Quad(42, 69, 55, 74, 54, 97, 42, 97);
            Draw.Quad(55, 74, 70, 72, 68, 92, 57, 91);

            //body
            Draw.Quad(44, 59, 70, 72, 55, 80, 35, 80);
            Draw.Quad(35, 72, 42, 69, 55, 80, 35, 80);
            Draw.Triangle(44, 59, 57, 60, 42, 69);

            Draw.FillColor = B4[1];
            Draw.Triangle(21, 90, 25, 98, 21, 97);
            Draw.Triangle(29, 92, 31, 98, 25, 98);

            Draw.Triangle(42, 96, 44, 92, 45, 96);
            Draw.Triangle(45, 96, 47, 90, 50, 96);
            Draw.Triangle(50, 96, 52, 92, 54, 96);

            Draw.Triangle(57, 92, 58, 87, 60, 92);
            Draw.Triangle(60, 92, 62, 86, 66, 92);
            Draw.Triangle(66, 92, 66, 88, 68, 92);

            //bulb
            Draw.FillColor = B3[1];
            Draw.Quad(65, 28, 53, 64, 50, 59, 48, 52);
            Draw.Quad(65, 28, 53, 64, 61, 66, 68, 59);
            Draw.Quad(65, 28, 33, 45, 37, 58, 47, 60);
            Draw.Quad(65, 28, 78, 66, 70, 72, 58, 66);
            Draw.Triangle(64, 28, 60, 21, 57, 35);
            Draw.Triangle(64, 28, 70, 23, 70, 44);

            //Head
            Draw.FillColor = B1[1];
            Draw.Quad(42, 79, 34, 72, 22, 69, 18, 64);
            Draw.Quad(20, 54, 44, 59, 42, 79, 18, 64);
            Draw.Quad(20, 54, 30, 49, 43, 52, 44, 59);

            //Ears
            Draw.Quad(34, 49, 42, 52, 42, 46, 36, 45);
            Draw.Quad(36, 45, 38, 43, 40, 42, 42, 46);
            Draw.Triangle(20, 55, 24, 52, 20, 48);

            //Mouth
            Draw.FillColor = B2[0];
            Draw.Quad(18, 64, 22, 65, 22, 69, 19, 67);
            Draw.Quad(22, 65, 30, 66, 30, 70, 22, 69);
            Draw.Quad(30, 66, 37, 64, 36, 66, 30, 70);
            Draw.FillColor = Color.White;
            Draw.Triangle(32, 66, 35, 65, 34, 68);
            Draw.Triangle(18, 64, 22, 65, 19, 68);

            //Eyes
            Draw.Quad(32, 58, 34, 56, 36, 57, 39, 67);
            Draw.Quad(32, 58, 39, 67, 39, 60, 32, 62);
            Draw.Quad(32, 62, 39, 60, 36, 62, 34, 63);

            Draw.Quad(19, 65, 21, 55, 22, 58, 18, 58);
            Draw.Quad(18, 59, 22, 58, 22, 60, 18, 60);
            Draw.Quad(18, 60, 22, 60, 21, 62, 19, 62);
            Draw.FillColor = B2[0];
            Draw.Quad(32, 58, 34, 56, 35, 58, 36, 58);
            Draw.Quad(32, 58, 36, 58, 36, 61, 32, 62);
            Draw.Quad(32, 62, 36, 61, 35, 63, 34, 63);

            Draw.Quad(20, 57, 21, 57, 22, 58, 19, 58);
            Draw.Quad(19, 58, 22, 58, 22, 60, 19, 60);
            Draw.Quad(19, 60, 22, 60, 19, 62, 20, 62);

            //darker outlines
            Draw.LineColor = B4[1];
            Draw.LineSize = 2;
            Draw.Line(65, 28, 48, 52);
            Draw.Line(48, 52, 50, 59);
            Draw.Line(65, 28, 68, 59);
            Draw.Line(68, 59, 61, 66);
            Draw.Line(42, 69, 35, 71);
            Draw.Line(35, 71, 22, 69);
            Draw.Line(22, 69, 18, 64);
        }
        void ShinyChari(int x, int y)
        {
            Draw.FillColor = B1[2];
            Draw.LineSize = 0;
            //legs
            Draw.Quad(22, 69, 35, 72, 34, 98, 21, 97);
            Draw.Quad(42, 69, 55, 74, 54, 97, 42, 97);
            Draw.Quad(55, 74, 70, 72, 68, 92, 57, 91);

            //body
            Draw.Quad(44, 59, 70, 72, 55, 80, 35, 80);
            Draw.Quad(35, 72, 42, 69, 55, 80, 35, 80);
            Draw.Triangle(44, 59, 57, 60, 42, 69);

            Draw.FillColor = B4[2];
            Draw.Triangle(21, 90, 25, 98, 21, 97);
            Draw.Triangle(29, 92, 31, 98, 25, 98);

            Draw.Triangle(42, 96, 44, 92, 45, 96);
            Draw.Triangle(45, 96, 47, 90, 50, 96);
            Draw.Triangle(50, 96, 52, 92, 54, 96);

            Draw.Triangle(57, 92, 58, 87, 60, 92);
            Draw.Triangle(60, 92, 62, 86, 66, 92);
            Draw.Triangle(66, 92, 66, 88, 68, 92);

            //bulb
            Draw.FillColor = B3[2];
            Draw.Quad(65, 28, 53, 64, 50, 59, 48, 52);
            Draw.Quad(65, 28, 53, 64, 61, 66, 68, 59);
            Draw.Quad(65, 28, 33, 45, 37, 58, 47, 60);
            Draw.Quad(65, 28, 78, 66, 70, 72, 58, 66);
            Draw.Triangle(64, 28, 60, 21, 57, 35);
            Draw.Triangle(64, 28, 70, 23, 70, 44);

            //Head
            Draw.FillColor = B1[2];
            Draw.Quad(42, 79, 34, 72, 22, 69, 18, 64);
            Draw.Quad(20, 54, 44, 59, 42, 79, 18, 64);
            Draw.Quad(20, 54, 30, 49, 43, 52, 44, 59);

            //Ears
            Draw.Quad(34, 49, 42, 52, 42, 46, 36, 45);
            Draw.Quad(36, 45, 38, 43, 40, 42, 42, 46);
            Draw.Triangle(20, 55, 24, 52, 20, 48);

            //Mouth
            Draw.FillColor = B2[1];
            Draw.Quad(18, 64, 22, 65, 22, 69, 19, 67);
            Draw.Quad(22, 65, 30, 66, 30, 70, 22, 69);
            Draw.Quad(30, 66, 37, 64, 36, 66, 30, 70);
            Draw.FillColor = Color.White;
            Draw.Triangle(32, 66, 35, 65, 34, 68);
            Draw.Triangle(18, 64, 22, 65, 19, 68);

            //Eyes
            Draw.Quad(32, 58, 34, 56, 36, 57, 39, 67);
            Draw.Quad(32, 58, 39, 67, 39, 60, 32, 62);
            Draw.Quad(32, 62, 39, 60, 36, 62, 34, 63);

            Draw.Quad(19, 65, 21, 55, 22, 58, 18, 58);
            Draw.Quad(18, 59, 22, 58, 22, 60, 18, 60);
            Draw.Quad(18, 60, 22, 60, 21, 62, 19, 62);
            Draw.FillColor = B2[1];
            Draw.Quad(32, 58, 34, 56, 35, 58, 36, 58);
            Draw.Quad(32, 58, 36, 58, 36, 61, 32, 62);
            Draw.Quad(32, 62, 36, 61, 35, 63, 34, 63);

            Draw.Quad(20, 57, 21, 57, 22, 58, 19, 58);
            Draw.Quad(19, 58, 22, 58, 22, 60, 19, 60);
            Draw.Quad(19, 60, 22, 60, 19, 62, 20, 62);

            //darker outlines
            Draw.LineColor = B4[2];
            Draw.LineSize = 2;
            Draw.Line(65, 28, 48, 52);
            Draw.Line(48, 52, 50, 59);
            Draw.Line(65, 28, 68, 59);
            Draw.Line(68, 59, 61, 66);
            Draw.Line(42, 69, 35, 71);
            Draw.Line(35, 71, 22, 69);
            Draw.Line(22, 69, 18, 64);
        }

    }

}
