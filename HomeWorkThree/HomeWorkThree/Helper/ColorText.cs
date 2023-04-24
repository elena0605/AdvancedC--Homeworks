

namespace HomeWorkThree.Helper
{
   public static class ColorText
    {
        public static void ChangeColorText (this string text,ConsoleColor color, ConsoleColor color2)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = color2;
            Console.WriteLine(text);
            Console.ResetColor();
           

        }
    }
}
