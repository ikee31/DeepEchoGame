using System;

public class Siren : Monster // 소나 교란
{
    public int JamLevel;

    public Siren()
    {
        Name = "세이렌";
        AttackPower = 5;
        Position = 3;
        IsAlive = true;

        JamLevel = 40;
    }

    public override void Move()
    {
        Random random = new Random();

        int moveAmount = random.Next(0, 3);

        Position -= moveAmount;

        if (Position < 0)
        {
            Position = 0;
        }

        Console.WriteLine($"{Name}의 위치 신호가 불안정하다...");
        Console.WriteLine($"추정 위치: {Position}");
    }

    public void JamSonar()
    {
        Console.WriteLine($"{Name}이 소나를 교란한다!");
        Console.WriteLine($"교란 수치: {JamLevel}%");
    }

    public void Whisper()
    {
        Console.WriteLine("무전기 너머에서 속삭임이 들린다...");
        Console.WriteLine("\"문을 열어...\"");
    }
}

public class PaleWhale : Monster // 보스급. 높은 기본 체급
{
    public int HullDamage;
    public int FearLevel;

    public PaleWhale()
    {
        Name = "창백한 고래";
        AttackPower = 40;
        Position = 3;
        IsAlive = true;

        HullDamage = 25;
        FearLevel = 100;
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

    public void CrushHull()
    {
        Console.WriteLine($"{Name}이 선체를 압박한다!");
        Console.WriteLine($"선체 내구도 {HullDamage} 감소!");
    }

    public void Fear()
    {
        Console.WriteLine("모든 모니터가 잠시 암전된다...");
        Console.WriteLine("심해 속 거대한 눈동자가 보인다.");
        Console.WriteLine($"공포 수치: {FearLevel}");
    }

    public void AbyssRoar()
    {
        Console.WriteLine($"{Name}이 심해 전체를 울리는 괴성을 낸다!");
        Console.WriteLine("산소 공급 장치가 불안정해진다...");
    }
}