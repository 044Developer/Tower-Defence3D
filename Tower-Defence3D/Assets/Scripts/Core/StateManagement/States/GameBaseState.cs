using TowerDefence.Core.StateManagement.Controller;

namespace TowerDefence.Core.StateManagement.States
{
    public abstract class GameBaseState : IGameBaseState
    {
        public abstract void Initialize(GameStateController gameStateController);

        public abstract void Enter();

        public abstract void Exit();
        public abstract void Dispose();
    }
}