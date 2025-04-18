using System;

namespace TextRPG
{
    public class Shop
    {
        public void EnterShop()
        {
            Console.Clear();
            Console.WriteLine("[상점]");
            Console.WriteLine("1. 체력 포션 - 10G");
            Console.WriteLine("2. 철 검 - 50G");
            Console.WriteLine("3. 철 갑옷 - 75G");
            Console.WriteLine("\n상점은 아직 구현되지 않았습니다.");
            Console.WriteLine("아무 키나 누르면 마을로 돌아갑니다.");
            Console.ReadKey();
        }
    }
}