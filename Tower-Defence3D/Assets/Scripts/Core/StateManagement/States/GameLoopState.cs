using TowerDefence.Core.StateManagement.Controller;

namespace TowerDefence.Core.StateManagement.States
{
    public class GameLoopState : GameBaseState
    {
        private IGameStateController _gameStateController = null;
        
        public override void Initialize(IGameStateController gameStateController)
        {
            _gameStateController = gameStateController;
        }

        public override void Enter()
        {
        }

        public override void Exit()
        {
        }

        public override void Dispose()
        {
        }
    }
}