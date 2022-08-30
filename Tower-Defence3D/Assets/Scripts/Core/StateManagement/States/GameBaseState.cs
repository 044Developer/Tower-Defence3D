using TowerDefence.Core.StateManagement.Controller;

namespace TowerDefence.Core.StateManagement.States
{
    public abstract class GameBaseState : IGameBaseState
    {
        public virtual void Initialize(IGameStateController gameStateController) { }

        public abstract void Enter();

        public abstract void Exit();
        public virtual void Dispose() { }
    }
}