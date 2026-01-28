using EasyToolkit.Core.Editor;
using EasyToolkit.Inspector.Editor;
using EasyToolkit.TileWorldPro;
using UnityEngine;

namespace EasyToolkit.TileWorldPro.Editor
{
    [DrawerPriority(DrawerPriorityLevel.Value + 100)]
    public class TileCoordinateDrawer : EasyValueDrawer<TileCoordinate>
    {
        private IElement _coordinateElement;

        protected override void Initialize()
        {
            base.Initialize();
            _coordinateElement = Element.Children!["_coordinate"];
        }

        protected override void Draw(GUIContent label)
        {
            _coordinateElement.Draw(label);
        }
    }
}
