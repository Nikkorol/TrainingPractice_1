namespace Rnc_Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PushingPHP = 300;
            int OppHP = 690;

            bool Scream = false;
            bool Still = false;
            string skill = null;

            Console.WriteLine("Hello MF! Вы, true rapper.\nВаша задача убить Opp'a в этих гадских рэперах врунишках, используя 5 разных флоу.\n" +
               "Запомни, что за каждое использованное флоу вы будете получать урон. " +
                "Игра закончится, когда кто нибудь умрет.\nМаксимальное здоровье PushingP - 300. Здоровье opp'a - 690." + "\n");
            Console.WriteLine("Flow Eminem. Наносит 75 урона и сбивает с ног opp'a, вы получаете 15 урона.\n" + "\n" +
                "Flow RaMxSiD. Возможно только после использования Flow Eminem. Если вы все сделаете правильно,то opp получит 75 урона, а вы получите 40 урона.\n" + "\n" +
                "Flow Rocket. Возможно только после того как вы используте Flow RaMxSiD. Если вы выполните условия opp получит 125 урона, а вы получите 25 урона.\n" + "\n" +
                "Flow 21 savage. Спасает вас от атаки opp'a (то есть вы не получите урон). Также cash восстановит вам 20 единиц здоровья.\n" + "\n" +
                "Flow Og Buda. Удар без малейших сомнений на 50 урона. Вы получите 25 урона.");

            while (PushingPHP > 0 && OppHP > 0)
            {
                Console.Write("\n" + "Введите команду:");
                skill = Console.ReadLine();
                if (skill == "Flow Eminem")
                {
                    OppHP -= 75;
                    PushingPHP -= 15;
                    Console.WriteLine("\n" + "Вы сбили с ног Opp'a и нанесли 75 урона и получили 15 урона. Ваше здоровье {0}. Здоровье Opp'a {1}", PushingPHP, OppHP);
                    Scream = true;
                }
                else if (skill == "Flow RaMxSiD")
                {
                    if (Scream == false)
                    {
                        PushingPHP -= 50;
                        Console.WriteLine("\n" + "Для начала нужно было использовать Flow Eminem! Вы не смогли ничего сделать! " +
                            "Вы получили 50 урона. Ваше здоровье {0}. Здоровье Opp'a {1}", PushingPHP, OppHP);
                    }
                    else
                    {
                        OppHP -= 100;
                        PushingPHP -= 40;
                        Console.WriteLine("\n" + "Вы украли 5% cashs opp'a, тем самым нанесли 75 урона. Вы получили 40 урона. Ваше здоровье {0}. Здоровье Opp'a {1}", PushingPHP, OppHP);
                        Scream = false;
                        Still = true;
                    }
                }

                else if (skill == "Flow 21 savage" && PushingPHP <= 100)
                {
                    PushingPHP += 20;
                    Console.WriteLine("\n" + "Вас окружило защитным куполом и вы не получили урона. Также вы восстановили 20 единиц здоровья. Ваше здоровье {0}. Здоровье Opp'a {1}", PushingPHP, OppHP);
                }
                else if (skill == "Flow 21 savage" && PushingPHP >= 100)
                {
                    Console.WriteLine("\n" + "Вас окружило защитным куполом и вы не получили урона. Вы не восстановили здоровье. Ваше здоровье {0}. Здоровье Opp'a {1}", PushingPHP, OppHP);
                }
                else if (skill == "Удар По кайфу")
                {
                    if (Still == false)
                    {
                        PushingPHP -= 100;
                        Console.WriteLine("\n" + "Для начала нужно было Украсть cash! Удар не был нанесён! " +
                            "Вы получили 100 урона. Ваше здоровье {0}. Здоровье Opp'a {1}", PushingPHP, OppHP);
                    }
                    else
                    {
                        OppHP -= 125;
                        PushingPHP -= 25;
                        Console.WriteLine("\n" + "Ваш удар нанес 125 урона. Вы получили 25 урона. Ваше здоровье {0}. Здоровье Opp'a {1}", PushingPHP, OppHP);
                        Still = false;
                    }
                }
                else if (skill == "Flow Og Buda")
                {
                    OppHP -= 50;
                    PushingPHP -= 25;
                    Console.WriteLine("\n" + "Удар Кайфовый на 50 урона. Вы получили 25 урона. Ваше здоровье {0}. Здоровье Opp'a {1}", PushingPHP, OppHP);
                }
                else
                {
                    Console.WriteLine("\n" + "Скилл не опознан. Попробуйте еще раз");
                }

            }

            if (PushingPHP <= 0)
            {
                Console.WriteLine("\n" + "Вы погибли!");
            }
            else
            {
                Console.WriteLine("\n" + "Вы выйграли! Поздравляю!");
            }
            Console.WriteLine("\n" + "Спасибо, что покатались по районe в этом SRT! Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}