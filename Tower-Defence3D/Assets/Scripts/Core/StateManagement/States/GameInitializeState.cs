using TowerDefence.Core.CoreConstants.Enums;
using TowerDefence.Core.StateManagement.Controller;
using TowerDefence.Core.Systems.MapInitSystem;
using TowerDefence.Core.Systems.TowersInitSystem;
using TowerDefence.Core.Systems.WaveInitSystem;

namespace TowerDefence.Core.StateManagement.States
{
    public class GameInitializeState : GameBaseState
    {
        private readonly IMapInitializeSystem _mapInitializeSystem = null;
        private readonly IWavesInitializeSystem _wavesInitializeSystem = null;
        private readonly ITowersInitializeSystem _towersInitializeSystem = null;

        private IGameStateController _gameStateController = null;

        public GameInitializeState(IMapInitializeSystem mapInitializeSystem,
            IWavesInitializeSystem wavesInitializeSystem,
            ITowersInitializeSystem towersInitializeSystem)
        {
            _mapInitializeSystem = mapInitializeSystem;
            _wavesInitializeSystem = wavesInitializeSystem;
            _towersInitializeSystem = towersInitializeSystem;
        }
        
        public override void Initialize(IGameStateController gameStateController)
        {
            base.Initialize(_gameStateController);
            
            _gameStateController = gameStateController;
        }

        public override void Enter()
        {
            _mapInitializeSystem.InitializeMapLevel();
            
            _wavesInitializeSystem.InitializeLevelWaves();
            
            _towersInitializeSystem.InitializeLevelTowers();
            
            _gameStateController.SwitchState(CoreGameStateType.GameLoopState);
        }

        public override void Exit()
        {
        }
    }
}