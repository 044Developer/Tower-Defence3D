using System.Collections.Generic;
using ModestTree;
using TowerDefence.Core.MonoModels.BaseTile;
using TowerDefence.Core.MonoModels.MapFieldElement;
using UnityEngine;

namespace TowerDefence.Core.MonoModels.LevelField
{
    public class LevelFieldViewModel : MonoBehaviour
    {
        [Header("Level Field Settings")]
        [SerializeField] private bool _drawFieldGizmos = false;
        [SerializeField] private Color _fieldGizmosColor = Color.green;
        [SerializeField] private float _fieldWidth = 1;
        [SerializeField] private float _fieldLength = 1;
        [SerializeField] private Vector3 _tileSize = Vector3.one;

        [Header("Level Field Components")]
        [SerializeField] private Transform _mapFieldParent = null;
        [SerializeField] private MapFieldElementViewModel _mapFieldElement = null;

        private List<MapFieldElementViewModel> _mapFieldElementList = new List<MapFieldElementViewModel>();

        [ContextMenu("Generate Field")]
        private void GenerateField()
        {
            return;
            
            float xSpawnOffset = _fieldWidth / 2 - _tileSize.x / 2;
            float zSpawnOffset = _fieldLength / 2 - _tileSize.z / 2;
            
            for (int x = 0; x < _fieldWidth; x++)
            {
                for (int z = 0; z < _fieldLength; z++)
                {
                    Vector3 newPosition = new Vector3(x - xSpawnOffset, 0, z - zSpawnOffset);
                    
                    SpawnMapFieldElement(newPosition);
                }
            }
        }
        
        [ContextMenu("Clear Field")]
        private void ClearField()
        {
            return;
            
            if (_mapFieldElementList.IsEmpty())
            {
                return;
            }
            
            foreach (MapFieldElementViewModel elementViewModel in _mapFieldElementList)
            {
                DestroyImmediate(elementViewModel.gameObject);
            }
            
            _mapFieldElementList.Clear();
        }
        
        [ContextMenu("Create Tiles")]
        private void CreateTiles()
        {
            return;
            
            if (_mapFieldElementList.IsEmpty())
            {
                return;
            }
            
            foreach (MapFieldElementViewModel elementViewModel in _mapFieldElementList)
            {
                BaseFieldTileViewModel prefab = elementViewModel.TileConfigurationContainer.TileConfigData.FieldTilePrefab;
                Quaternion tileRotation = elementViewModel.TileConfigurationContainer.TileConfigData.TileRotation;

                BaseFieldTileViewModel tileElement = Instantiate(prefab, elementViewModel.transform.position, tileRotation, elementViewModel.transform);
                
                elementViewModel.SetFieldTile(tileElement);
            }
        }

        private void SpawnMapFieldElement(Vector3 position)
        {
            return;
            
            var mapFieldElement = Instantiate(_mapFieldElement, position, Quaternion.identity, _mapFieldParent);
            mapFieldElement.name = mapFieldElement.name.Replace("(Clone)", "");
            
            _mapFieldElementList.Add(mapFieldElement);
        }
#if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            return;
            
            if (!_drawFieldGizmos)
            {
                return;
            }
            
            Gizmos.color = _fieldGizmosColor;

            foreach (MapFieldElementViewModel elementViewModel in _mapFieldElementList)
            {
                Gizmos.DrawCube(elementViewModel.transform.position, _tileSize);
            }
        }
#endif
    }
}