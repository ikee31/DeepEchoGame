using System;

public class Monster
{                           //몬스터 정보
    public string Name;      //몬스터 이름, 저장
    public int AttackPower;     //몬스터 공격력, 
    public int Position;        //몬스터 현 구역 위치
    public bool IsAlive;        //몬스터 생사여부 판단

    public virtual void Move() // 몬스터가 자신의 이동 방식으로 덮어씀. 실행
    {
        Position--; // 포지션 값을 감소시켜 탐사선에 접근

        if (Position < 0)
        {
            Position = 0; // 0 아래로 내려가는 것 방지
        }

        Console.WriteLine($"{Name}가 접근했다.");
        Console.WriteLine($"현재 위치: {Position}");
    }

    // 해치 상태를 받아서 공격 가능 여부 판단
    public void Attack(bool isHatchClosed)
    {
        if (isHatchClosed) //해치 상태 판단
        {
            Console.WriteLine("해치가 닫혀 있어 공격을 막았다!");
            return; //반복
        }

        Console.WriteLine($"{Name}의 공격!");
        Console.WriteLine($"{AttackPower} 피해를 입힌다!");
    }

    // 음파 공격을 받으면 뒤로 밀려남
    public void HitBySonicAttack()
    {
        Position++; // 포지션 증가 시 탐사선에서 멀어짐

        if (Position > 3)
        {
            Position = 3; //0~3 총 4개의 구역을 넘어가는 걸 막음
        }

        Console.WriteLine($"{Name}이 음파 공격을 받고 뒤로 밀려났다!");
        Console.WriteLine($"현재 위치: {Position}");
    }
}