using System;

namespace EasyToolkit.TileWorldPro
{
    public class RemoveTilesEvent
    {
        public Guid TerrainGuid;
        public TileCoordinate[] TilePositions;

        public RemoveTilesEvent(Guid terrainGuid, TileCoordinate[] tilePositions)
        {
            TerrainGuid = terrainGuid;
            TilePositions = tilePositions;
        }
    }
}