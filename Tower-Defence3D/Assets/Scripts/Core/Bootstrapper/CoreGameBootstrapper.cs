using TowerDefence.Core.CoreConstants.Enums;
using TowerDefence.Core.StateManagement.Controller;
using Zenject;

namespace TowerDefence.Core.Bootstrapper
{
    public class CoreGameBootstrapper : IInitializable
    {
        private readonly IGameStateController _gameStateController = null;

        public CoreGameBootstrapper(IGameStateController gameStateController)
        {
            _gameStateController = gameStateController;
        }
        
        public void Initialize()
        {
            _gameStateController.SwitchState(CoreGameStateType.GameInitializeState);
        }

        public void Dispose()
        {
        }
    }
}