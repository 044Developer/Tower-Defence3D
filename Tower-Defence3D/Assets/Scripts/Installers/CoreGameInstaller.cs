using TowerDefence.Core.Bootstrapper;
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
        BindInitializeSystems();
        
        BindCoreGameStateController();

        BindCoreBootstrapper();
    }

    private void BindInitializeSystems()
    {
        Container.Bind<IMapInitializeSystem>().To(x => x.AllTypes().DerivingFrom<IMapInitializeSystem>()).AsSingle();
        Container.Bind<IWavesInitializeSystem>().To(x => x.AllTypes().DerivingFrom<IWavesInitializeSystem>()).AsSingle();
        Container.Bind<ITowersInitializeSystem>().To(x => x.AllTypes().DerivingFrom<ITowersInitializeSystem>()).AsSingle();
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