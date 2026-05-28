using System;
using System.Collections.Generic;

namespace DeepEchoGame
{
    internal class MonsterManager
    {
        private readonly Random random = new Random();
        private readonly MonsterSpawner spawner = new MonsterSpawner();

        private readonly List<Monster> activeMonsters = new List<Monster>();
        private int turn = 1;

        internal void Spawn(Map mainMap)
        {
            List<Monster> monsters = spawner.Spawn(turn);

            foreach (Monster monster in monsters)
            {
                int randomPosition = random.Next(1, 6);

                monster.Position = randomPosition;
                mainMap.MonsterIn(randomPosition);

                activeMonsters.Add(monster);

                Console.WriteLine($"\n[경고] {monster.Name} 등장!");
                Console.WriteLine($"[SYSTEM] cam{randomPosition} 에서 위협 반응 감지!");
            }

            turn++;
        }

        internal List<Monster> GetActiveMonsters()
        {
            activeMonsters.RemoveAll(monster => !monster.IsAlive);
            return activeMonsters;
        }
    }
}