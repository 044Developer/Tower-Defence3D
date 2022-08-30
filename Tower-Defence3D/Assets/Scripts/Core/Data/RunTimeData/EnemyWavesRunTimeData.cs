using System.Collections.Generic;
using TowerDefence.Core.Configurations.WavesConfig.Data;

namespace TowerDefence.Core.Data.RunTimeData
{
    public class EnemyWavesRunTimeData
    {
        public EnemyWaveData CurrentWave => _currentWave;
        public int CurrentWaveIndex => _currentWaveIndex;
        
        private List<EnemyWaveData> _enemyWavesData = null;
        private EnemyWaveData _currentWave = null;
        private int _currentWaveIndex = 0;

        public void InitializeEnemyWavesData(List<EnemyWaveData> enemyWavesData)
        {
            _enemyWavesData = new List<EnemyWaveData>();
            _enemyWavesData.AddRange(enemyWavesData);
            _currentWaveIndex = -1;
        }

        public void InitializeNewWave()
        {
            _currentWaveIndex++;

            if (_enemyWavesData[_currentWaveIndex] != null)
            {
                _currentWave = _enemyWavesData[_currentWaveIndex];
            }
        }
    }
}