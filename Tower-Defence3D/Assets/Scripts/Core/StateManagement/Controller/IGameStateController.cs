using TowerDefence.Core.CoreConstants.Enums;

namespace TowerDefence.Core.StateManagement.Controller
{
    public interface IGameStateController
    {
        void SwitchState(CoreGameStateType stateType);
    }
}