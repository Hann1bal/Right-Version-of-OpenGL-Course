using System;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace RetryGame
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)

        {
            var gameWindowSettings = GameWindowSettings.Default;

            NativeWindowSettings nativeWindowSettings = new()
            {
                Size = new Vector2i(800, 600),
                Title = "Retry again",
                Flags = ContextFlags.Default,
                APIVersion = new Version(4, 0)
            };
            using (var gameEngine = new GameEngine(gameWindowSettings, nativeWindowSettings))
            {
                gameEngine.Run();
            }
        }
    }
}