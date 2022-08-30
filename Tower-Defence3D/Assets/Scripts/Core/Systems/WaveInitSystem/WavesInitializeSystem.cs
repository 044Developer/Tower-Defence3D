using TowerDefence.Core.Configurations.WavesConfig.Container;
using TowerDefence.Core.Data.RunTimeData;

namespace TowerDefence.Core.Systems.WaveInitSystem
{
    public class WavesInitializeSystem : IWavesInitializeSystem
    {
        private readonly EnemyWavesConfig _enemyWavesConfig = null;
        private readonly EnemyWavesRunTimeData _enemyWavesRunTimeData = null;

        public WavesInitializeSystem(EnemyWavesConfig enemyWavesConfig, EnemyWavesRunTimeData enemyWavesRunTimeData)
        {
            _enemyWavesConfig = enemyWavesConfig;
            _enemyWavesRunTimeData = enemyWavesRunTimeData;
        }
        
        public void InitializeLevelWaves()
        {
            InitializeRunTimeData();
        }

        private void InitializeRunTimeData()
        {
            int currentLevel = 1;

            var tempWave = _enemyWavesConfig.WavesConfiguration.Find(it => it.LevelNumber == currentLevel);

            if (tempWave != null)
            {
                _enemyWavesRunTimeData.InitializeEnemyWavesData(tempWave.EnemyWavesData);
            }
            
            _enemyWavesRunTimeData.InitializeNewWave();
        }
    }
}