using System.Collections.Generic;
using System.Linq;
using EasyToolKit.Core.Events;
using UnityEngine;

namespace EasyToolKit.TileWorldPro.Editor
{
    public class CompositeEraseTool : CompositeDraggableDrawingTool
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
    }
}
