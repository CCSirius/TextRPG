using System;

namespace TextRPG
{
    public class Player
    {
        public String Job { get; set; } = "전사";
        public int Level { get; set; } = 1;
        public int Health { get; set; } = 100;
        public int Attack { get; set; } = 10;
        public int Defense { get; set; } = 5;
        public int Gold { get; set; } = 100;

        public void ShowStatus()
        {
            Console.Clear();
            Console.WriteLine("[내 상태]");
            Console.WriteLine($"Siri {Job}");
            Console.WriteLine($"레벨 : {Level}");
            Console.WriteLine($"체력 : {Health}");
            Console.WriteLine($"공격력 : {Attack}");
            Console.WriteLine($"방어력 : {Defense}");
            Console.WriteLine($"Gold : {Gold}G");
            Console.WriteLine("\n아무 키나 누르면 마을로 돌아갑니다.");
            Console.ReadKey();
        }
    }
}
