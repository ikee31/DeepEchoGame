using System;

public class Siren : Monster
{
    public Siren()
    {
        Name = "세이렌";
        AttackPower = 5;
        Position = 3;
        IsAlive = true;
    }

    public override void Move()
    {
        Random random = new Random();

        int moveAmount = random.Next(0, 3);//0~3중 랜덤한만큼 이동

        Position -= moveAmount; //위치에서 이동 값만큼 마이너스

        if (Position < 0)
        {
            Position = 0;// 위치는 0 혹은 그 이상
        }

        Console.WriteLine($"{Name}의 위치 신호가 불안정하다...");
        Console.WriteLine($"추정 위치: {Position}");
    }

    public override void UseAbility() //몬스터 특수능력 사용
    {
        Console.WriteLine($"{Name}이 불규칙한 음파로 소나 신호를 흔든다.");
    }
}

public class PaleWhale : Monster
{
    public int HullDamage;

    public PaleWhale()
    {
        Name = "창백한 고래";
        AttackPower = 40;
        Position = 3;
        IsAlive = true;

        HullDamage = 25;
    }

    public override void Move()
    {
        Position--;

        if (Position < 0)
        {
            Position = 0;
        }

        Console.WriteLine($"{Name}의 거대한 그림자가 천천히 다가온다...");
        Console.WriteLine("탐사선 전체가 낮게 흔들린다.");
        Console.WriteLine($"현재 위치: {Position}");
    }

    public override void UseAbility()
    {
        Console.WriteLine($"{Name}이 선체를 압박한다!");
        Console.WriteLine($"선체 내구도 {HullDamage} 감소!");
    }
}