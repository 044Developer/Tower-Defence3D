using System;
using System.Collections.Generic;
using TowerDefence.Core.Data.Enums;

namespace TowerDefence.Core.Configurations.WavesConfig.Data
{
    [Serializable]
    public class EnemyWaveData
    {
        public List<WaveEnemyTypes> WaveEnemyTypes = new List<WaveEnemyTypes>();
        public float WaveSpawnRatio = 0f;
        public float WaveDuration = 0f;
    }

    [Serializable]
    public class WaveEnemyTypes
    {
        public EnemyWaveType EnemyWaveType = EnemyWaveType.None;
        public int EnemyCount = 0;
    }
}