using System;

public class Leviathan : Monster
{
    public int PowerDrain;

    public Leviathan() //전력 감소
    {
        Name = "레비아탄";
        AttackPower = 10;
        Position = 3;
        IsAlive = true;

        PowerDrain = 15;
    }

    // 레비아탄은 조용히 접근
    public override void Move()
    {
        Position--;

        if (Position < 0)
        {
            Position = 0;
        }

        Console.WriteLine($"{Name}이 전력 신호를 따라 조용히 접근한다...");
        Console.WriteLine($"현재 위치: {Position}");
    }

    public void DrainPower()
    {
        Console.WriteLine($"{Name}이 탐사선 전력을 갉아먹는다!");
        Console.WriteLine($"전력 {PowerDrain} 감소!");
    }
}