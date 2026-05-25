using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int randomPosition = random.Next(0, 4);
        int monsterType = random.Next(0, 4);

        Monster spawnedMonster = null;

        switch (monsterType)
        {
            case 0:
                spawnedMonster = new Spearfish();
                break;

            case 1:
                spawnedMonster = new Leviathan();
                break;

            case 2:
                spawnedMonster = new Siren();
                break;

            case 3:
                spawnedMonster = new PaleWhale();
                break;
        }

        //몬스터 랜덤 위치 생성
        spawnedMonster.Position = randomPosition;

        Console.WriteLine("===== 심해 반응 감지 =====");
        Console.WriteLine($"출현 몬스터: {spawnedMonster.Name}");
        Console.WriteLine($"출현 위치: {spawnedMonster.Position}");
        Console.WriteLine();

        // 몬스터 이동
        spawnedMonster.Move();

        //해설, 선택지
        Console.WriteLine();
        Console.WriteLine("행동을 선택하세요.");
        Console.WriteLine("1. 해치 폐쇄");
        Console.WriteLine("2. 음파 공격");
        Console.WriteLine("3. 아무것도 하지 않음");
        Console.Write("선택: ");

        string input = Console.ReadLine();

        bool isHatchClosed = false;

        if (input == "1")
        {
            isHatchClosed = true;
            Console.WriteLine("해치를 폐쇄했다.");
        }
        else if (input == "2")
        {
            spawnedMonster.HitBySonicAttack();
        }
        else
        {
            Console.WriteLine("아무 행동도 하지 않았다.");
        }

        Console.WriteLine();

        // 몬스터가 가까우면 공격
        if (spawnedMonster.Position == 0)
        {
            spawnedMonster.Attack(isHatchClosed);
        }
        else
        {
            Console.WriteLine($"{spawnedMonster.Name}은 아직 공격 거리 밖에 있다.");
        }

        Console.WriteLine();

        // 몬스터별 특수 능력 실행
        if (spawnedMonster is Spearfish)
        {
            Spearfish spearfish = (Spearfish)spawnedMonster;
            spearfish.Pierce();
        }
        else if (spawnedMonster is Leviathan)
        {
            Leviathan leviathan = (Leviathan)spawnedMonster;
            leviathan.DrainPower();
        }
        else if (spawnedMonster is Siren)
        {
            Siren siren = (Siren)spawnedMonster;
            siren.JamSonar();
            siren.Whisper();
        }
        else if (spawnedMonster is PaleWhale)
        {
            PaleWhale whale = (PaleWhale)spawnedMonster;
            whale.CrushHull();
            whale.Fear();
            whale.AbyssRoar();
        }
    }
}