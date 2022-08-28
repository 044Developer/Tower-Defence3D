using TowerDefence.Core.Configurations.FieldTiles.Container;
using TowerDefence.Core.MonoModels.BaseTile;
using UnityEngine;

namespace TowerDefence.Core.MonoModels.MapFieldElement
{
    public class MapFieldElementViewModel : MonoBehaviour
    {
        [SerializeField] private FieldTileConfigurationContainer _tileConfigurationContainer = null;

        private BaseFieldTileViewModel _fieldTile = null;
        
        public FieldTileConfigurationContainer TileConfigurationContainer => _tileConfigurationContainer;
        public BaseFieldTileViewModel FieldTile => _fieldTile;

        public void SetFieldTile(BaseFieldTileViewModel fieldTile)
        {
            _fieldTile = fieldTile;
        }
    }
}