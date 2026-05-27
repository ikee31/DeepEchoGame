using System;

public class Spearfish : Monster
{
    public Spearfish()
    {
        Name = "청새치";
        AttackPower = 25;
        Position = 3;
        IsAlive = true;
    }

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

    public override void UseAbility()
    {
        Console.WriteLine($"{Name}가 날카로운 주둥이로 선체를 꿰뚫으려 한다!");
    }
}