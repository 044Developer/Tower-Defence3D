using UnityEngine;

namespace TowerDefence.Core.MonoModels.BaseTile
{
    public abstract class BaseFieldTileViewModel : MonoBehaviour, IBaseFieldTile
    {
        public Transform TileTransform => transform;
    }
}