using System;

namespace Lesson_1
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Lesson1())
                game.Run();
        }
    }
}
