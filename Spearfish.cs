using System;

public class Spearfish : Monster
{
    public Spearfish()//빠른 물리 공격
    {
        Name = "청새치";
        AttackPower = 25;
        Position = 3;
        IsAlive = true;
    }

    // 청새치는 빠르게 돌진
    public override void Move()
    {
        Position -= 2;

        if (Position < 0)
        {
            Position = 0;
        }

        Console.WriteLine($"{Name}가 엄청난 속도로 돌진한다!");
        Console.WriteLine($"현재 위치: {Position}");
    }

    public void Pierce()
    {
        Console.WriteLine($"{Name}가 해치를 꿰뚫으려 한다!");
    }
}