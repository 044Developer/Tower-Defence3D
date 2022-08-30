using System.Collections.Generic;
using UnityEngine;

namespace TowerDefence.Core.Data.RunTimeData
{
    public class EnemyWaypointsData
    {
        public IEnumerable<Vector2> EnemyWaypoints => _enemyWaypointsList;
        public Vector3 EnemySpawnerPosition => _enemySpawnPosition;
        
        private List<Vector2> _enemyWaypointsList = null;
        private Vector3 _enemySpawnPosition = Vector3.zero;

        public void InitializeEnemyWaypointsData(List<Vector2> currentWaypoints, Vector3 spawnerPosition)
        {
            _enemyWaypointsList = new List<Vector2>();
            _enemyWaypointsList.AddRange(currentWaypoints);
            _enemySpawnPosition = spawnerPosition;
        }
    }
}