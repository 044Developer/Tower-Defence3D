using TowerDefence.Core.Configurations.FieldTiles.Data;
using UnityEngine;

namespace TowerDefence.Core.Configurations.FieldTiles.Container
{
    [CreateAssetMenu(menuName = "Configurations/Core/Field Element/Field Tile Config", fileName = "_Field_Tile_Config")]
    public class FieldTileConfigurationContainer : ScriptableObject
    {
        [SerializeField] private FieldTileConfigData _tileConfigData = null;

        public FieldTileConfigData TileConfigData => _tileConfigData;
    }
}