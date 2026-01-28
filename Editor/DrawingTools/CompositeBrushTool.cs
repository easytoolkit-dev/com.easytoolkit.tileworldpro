using System.Collections.Generic;
using System.Linq;
using EasyToolkit.Core;
using EasyToolkit.Core.Events;
using UnityEngine;

namespace EasyToolkit.TileWorldPro.Editor
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
