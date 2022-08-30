using TowerDefence.Core.Configurations.WavesConfig.Container;
using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "CoreConfigsInstaller", menuName = "Installers/CoreConfigsInstaller")]
public class CoreConfigsInstaller : ScriptableObjectInstaller<CoreConfigsInstaller>
{
    [SerializeField] private EnemyWavesConfig _enemyWavesConfig = null;    
    
    public override void InstallBindings()
    {
        BindEnemyWavesConfig();
    }

    private void BindEnemyWavesConfig()
    {
        Container.BindInstance(_enemyWavesConfig).AsSingle();
    }
}