using System;

namespace TextRPG
{
    public class Game
    {
        private Player player = new Player();
        private Inventory inventory = new Inventory();
        private Shop shop = new Shop();

        public void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점\n");
                Console.Write("원하시는 행동을 입력해주세요.\n>> ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        player.ShowStatus();
                        break;
                    case "2":
                        inventory.ShowInventory();
                        break;
                    case "3":
                        shop.EnterShop();
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다. 아무 키나 누르면 다시 선택 화면으로 돌아갑니다.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
