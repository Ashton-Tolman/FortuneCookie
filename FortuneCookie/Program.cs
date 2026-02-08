/* Ashton Tolman
 * Spring 2026
 * FortuneCookie
 * https://github.com/Ashton-Tolman/FortuneCookie.git
 */
namespace FortuneCookie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opening message
            Console.WriteLine($"I AM THE CASTER OF SPELLS " +
                              $"\n YOU WHO SPEAKS TO ME" +
                              $"\n YOUR FUTURE SHALL BE TOLD");
            Console.WriteLine();

            //generate random number
            Random randy = new Random();
            int n = randy.Next(1, 8);

            //random number picks a fortune
            switch(n)
            {
                case 0:
                    Console.WriteLine("YOU WILL SEE GREAT SUCCESS IN YOUR VIDEO GAMING EXPLOITS");
                    break;
                case 1:
                    Console.WriteLine("YOUR FACE WILL TAKE A DECLINE IN RELATIVE SOCIETAL ATTRACTIVNESS");
                    break;
                case 2:
                    Console.WriteLine("A LOSER LIKE YOUR MOTHER WILL TRY TO MAKE FRIENDS WITH YOU");
                    break;
                case 3:
                    Console.WriteLine("YOUR LIFE WILL TAKE A TURN FOR THE HUNGRY");
                    break;
                case 4:
                    Console.WriteLine($"Not a fortune, just. " +
                                      $"\nYou gotta drink water dude. " +
                                      $"\nI can sense that youre dehydrated");
                    break;
                case 5:
                    Console.WriteLine("YOUR FUTURE IS CLOUDED BY THOUGHTS OF TACO BELL");
                    break;
                case 6:
                    Console.WriteLine("THE SCARS IN YOUR SOUL WILL CARVE THE PATH TO YOUR DESTINY");
                    break;
                case 7:
                    Console.WriteLine("Family will guide you through hard times <3");
                    break;
            }


            //pause
            Console.Read();
        }
    }
}
