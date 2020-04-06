using Citadel;
using Citadel.Display;
using SdlSharp;

namespace RoguelikeTutorial
{
    internal class Program
    {
        private static readonly Size s_screenSize = (1280, 720);

        private static void Main()
        {
            using var game = new Game(new[]
            {
                new DisplayConfiguration(
                    title: "RougelikeTutorial",
                    size: s_screenSize
                )
            });

            if (game.Initialize())
            {
                game.Run();
            }
        }
    }
}
