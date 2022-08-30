using System;
using System.Collections.Generic;

namespace TowerDefence.Core.Configurations.WavesConfig.Data
{
    [Serializable]
    public class EnemyWavesConfigData
    {
        public int LevelNumber = 0;
        public List<EnemyWaveData> EnemyWavesData = new List<EnemyWaveData>();
    }
}