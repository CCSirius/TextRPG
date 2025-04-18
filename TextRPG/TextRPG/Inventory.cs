using System;

namespace TextRPG
{
    public class Inventory
    {
        public void ShowInventory()
        {
            Console.Clear();
            Console.WriteLine("[인벤토리]");
            Console.WriteLine(" - 초보자 검");
            Console.WriteLine(" - 체력 포션 x3");
            Console.WriteLine("\n아무 키나 누르면 마을로 돌아갑니다.");
            Console.ReadKey();
        }
    }
}