using System;
using System.Collections.Generic;
using System.Linq;
using EasyToolKit.Core.Events;
using UnityEngine;

namespace EasyToolKit.TileWorldPro.Editor
{
    public class EraseTool : DraggableDrawingTool
    {
        protected override void DoTiles(DrawingToolContext context, IReadOnlyList<TileCoordinate> tileCoordinates)
        {
            context.Designer.TileWorldAsset.RemoveTilesAt(tileCoordinates, context.TerrainDefinition.Guid);
            EventManager.Instance.Dispatch(new RemoveTilesEvent(context.TerrainDefinition.Guid, tileCoordinates.ToArray()));
        }

        protected override Color GetHitColor(DrawingToolContext context)
        {
            return Color.red;
        }

        protected override bool FilterHitTile(DrawingToolContext context, TileCoordinate tileCoordinate)
        {
            if (context.Designer.TileWorldAsset.TryGetChunkAt(tileCoordinate, out Chunk chunk))
            {
                if (chunk.TryGetTerrainGuidsAt(tileCoordinate, out var terrainGuids))
                {
                    if (Array.FindIndex(terrainGuids, guid => guid == context.TerrainDefinition.Guid) != -1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
