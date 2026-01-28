using System;
using UnityEngine;

namespace EasyToolkit.TileWorldPro
{
    public struct TerrainTileCoordinate
    {
        public TileCoordinate TileCoordinate;
        public Guid TerrainGuid;

        public TerrainTileCoordinate(TileCoordinate tileCoordinate, Guid terrainGuid)
        {
            TileCoordinate = tileCoordinate;
            TerrainGuid = terrainGuid;
        }
    }
}
