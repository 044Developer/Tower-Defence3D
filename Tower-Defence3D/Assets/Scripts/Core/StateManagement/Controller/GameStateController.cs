using System.Collections.Generic;
using TowerDefence.Core.CoreConstants.Enums;
using TowerDefence.Core.StateManagement.States;

namespace TowerDefence.Core.StateManagement.Controller
{
    public class GameStateController
    {
        private Dictionary<CoreGameStateType, IGameBaseState> _cachedStates = null;
        private IGameBaseState _currentState = null;

        public GameStateController(GameInitializeState gameInitializeState,
            GameLoopState gameLoopState,
            GameWinState gameWinState,
            GameLooseState gameLooseState,
            GameExitState gameExitState)
        {
            _cachedStates = new Dictionary<CoreGameStateType, IGameBaseState>()
            {
                [CoreGameStateType.GameInitializeState] = gameInitializeState,
                [CoreGameStateType.GameLoopState] = gameLoopState,
                [CoreGameStateType.GameWinState] = gameWinState,
                [CoreGameStateType.GameLooseState] = gameLooseState,
                [CoreGameStateType.GameExitState] = gameExitState,
            };
        }

        public void Initialize()
        {
            foreach (IGameBaseState state in _cachedStates.Values)
            {
                state.Initialize(this);
            }
        }

        public void SwitchState(CoreGameStateType stateType)
        {
            IGameBaseState nextState = GetNextState(stateType);
            
            ClosePreviousState();
            
            EnterNewState(nextState);
        }

        public void Dispose()
        {
            foreach (IGameBaseState state in _cachedStates.Values)
            {
                state.Dispose();
            }
        }

        private IGameBaseState GetNextState(CoreGameStateType stateType)
        {
            if (_cachedStates.ContainsKey(stateType))
            {
                return _cachedStates[stateType];
            }

            return null;
        }

        private void ClosePreviousState()
        {
            if (_currentState != null)
            {
                _currentState.Exit();
            }
        }

        private void EnterNewState(IGameBaseState newState)
        {
            if (newState != null)
            {
                _currentState = newState;
                _currentState.Enter();
            }
        }
    }
}