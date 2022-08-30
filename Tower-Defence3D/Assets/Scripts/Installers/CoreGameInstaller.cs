using TowerDefence.Core.Bootstrapper;
using TowerDefence.Core.Data.RunTimeData;
using TowerDefence.Core.StateManagement.Controller;
using TowerDefence.Core.StateManagement.States;
using TowerDefence.Core.Systems.MapInitSystem;
using TowerDefence.Core.Systems.TowersInitSystem;
using TowerDefence.Core.Systems.WaveInitSystem;
using Zenject;

public class CoreGameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        BindRuntimeData();
        
        BindInitializeSystems();
        
        BindCoreGameStateController();

        BindCoreBootstrapper();
    }

    private void BindRuntimeData()
    {
        Container.Bind<EnemyWaypointsData>().AsSingle();
        Container.Bind<EnemyWavesRunTimeData>().AsSingle();
    }

    private void BindInitializeSystems()
    {
        Container.Bind<IMapInitializeSystem>().To<MapInitializeSystem>().AsSingle();
        Container.Bind<IWavesInitializeSystem>().To<WavesInitializeSystem>().AsSingle();
        Container.Bind<ITowersInitializeSystem>().To<TowersInitializeSystem>().AsSingle();
    }

    private void BindCoreGameStateController()
    {
        Container.Bind<GameInitializeState>().AsSingle();
        Container.Bind<GameLoopState>().AsSingle();
        Container.Bind<GameWinState>().AsSingle();
        Container.Bind<GameLooseState>().AsSingle();
        Container.Bind<GameExitState>().AsSingle();

        Container.BindInterfacesAndSelfTo<GameStateController>().AsSingle();
    }

    private void BindCoreBootstrapper()
    {
        Container.BindInterfacesAndSelfTo<CoreGameBootstrapper>().AsSingle();
    }
}