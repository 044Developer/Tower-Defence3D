using TowerDefence.Core.StateManagement.Controller;

namespace TowerDefence.Core.StateManagement.States
{
    public interface IGameBaseState
    {
        void Initialize(IGameStateController gameStateController);
        void Enter();
        void Exit();
        void Dispose();
    }
}