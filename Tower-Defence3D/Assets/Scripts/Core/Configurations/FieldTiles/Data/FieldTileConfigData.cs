using System;
using TowerDefence.Core.CoreConstants.Enums;
using TowerDefence.Core.MonoModels.BaseTile;
using UnityEngine;

namespace TowerDefence.Core.Configurations.FieldTiles.Data
{
    [Serializable]
    public class FieldTileConfigData
    {
        [SerializeField] private FieldTileType _fieldTileType = FieldTileType.None;
        [SerializeField] private BaseFieldTileViewModel _fieldTilePrefab = null;
        [SerializeField] private Vector3 _tileRotation = Vector3.zero;
        
        public FieldTileType FieldTileType => _fieldTileType;
        public BaseFieldTileViewModel FieldTilePrefab => _fieldTilePrefab;
        public Quaternion TileRotation => Quaternion.Euler(_tileRotation);
    }
}