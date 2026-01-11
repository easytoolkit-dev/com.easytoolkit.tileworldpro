using System.Collections.Generic;
using System.Linq;
using EasyToolKit.Core;
using EasyToolKit.Core.Events;
using UnityEngine;

namespace EasyToolKit.TileWorldPro.Editor
{
    public class CompositeBrushTool : CompositeDraggableDrawingTool
    {
        protected override void DoTiles(DrawingToolContext context, IReadOnlyList<TileCoordinate> tileCoordinates)
        {
            context.Designer.TileWorldAsset.SetTilesAt(tileCoordinates, context.TerrainDefinition.Guid);
            EventManager.Instance.Dispatch(new SetTilesEvent(context.TerrainDefinition.Guid, tileCoordinates.ToArray()));
        }

        protected override Color GetHitColor(DrawingToolContext context)
        {
            return context.TerrainDefinition.DebugCubeColor;
        }
    }
}
