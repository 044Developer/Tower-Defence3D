using System.Collections.Generic;
using TowerDefence.Core.Configurations.WavesConfig.Data;
using UnityEngine;

namespace TowerDefence.Core.Configurations.WavesConfig.Container
{
    [CreateAssetMenu(menuName = "Configurations/Core/Enemy Waves/Enemy Waves Config", fileName = "Enemy_Waves_Config")]
    public class EnemyWavesConfig : ScriptableObject
    {
        public List<EnemyWavesConfigData> WavesConfiguration = new List<EnemyWavesConfigData>();
    }
}