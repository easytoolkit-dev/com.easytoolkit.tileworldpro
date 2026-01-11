using EasyToolKit.Core;
using EasyToolKit.Core.Mathematics;
using UnityEngine;

namespace EasyToolKit.TileWorldPro
{
    public class TileWorldStartPoint : MonoBehaviour
    {
        public static readonly float Epsilon = 0.00001f;

        public TileCoordinate PositionToTileCoordinate(Vector3 position, float tileSize)
        {
            var local = position - transform.position;
            int coordX = (local.x / tileSize).FloorToIntApproximately(Epsilon);
            int coordY = (local.y / tileSize).FloorToIntApproximately(Epsilon);
            int coordZ = (local.z / tileSize).FloorToIntApproximately(Epsilon);

            return new TileCoordinate(coordX, coordY, coordZ);
        }

        public Vector3 TileCoordinateToPosition(TileCoordinate tileCoordinate, float tileSize)
        {
            return transform.position + (Vector3)tileCoordinate * tileSize;
        }

        public Vector3 AlignTilePosition(Vector3 position, float tileSize)
        {
            var tileCoordinate = PositionToTileCoordinate(position, tileSize);
            var tilePosition = TileCoordinateToPosition(tileCoordinate, tileSize);
            return tilePosition;
        }
    }
}
