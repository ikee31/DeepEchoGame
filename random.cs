Random random = new Random();

int randomPosition = random.Next(0, 4); //몬스타 위치는 0~3
int monsterType = random.Next(0, 4); //몹은 숫자에 따라 결정

Monster spawnedMonster = null; //지역 변수 초기화

switch (monsterType)
{
    case 0: //0 = 청새치
        spawnedMonster = new Spearfish();
        break;

    case 1: //1 = 레비아탄
        spawnedMonster = new Leviathan();
        break;

    case 2://2 = 세이렌
        spawnedMonster = new Siren();
        break;

    case 3: //3 = 창백한 고래
        spawnedMonster = new PaleWhale();
        break;
}

spawnedMonster.Position = randomPosition; //생성된 몬스터의 위치는 랜덤

Console.WriteLine("===== 심해 반응 감지 =====");
Console.WriteLine($"출현 몬스터: {spawnedMonster.Name}");
Console.WriteLine($"출현 위치: {spawnedMonster.Position}");

spawnedMonster.Move();

bool isLightOn = false;

// 메인 코드의 방어 선택지에서 1번이 불 켜기라면
// isLightOn = true;

spawnedMonster.Attack(isLightOn);
spawnedMonster.UseAbility();