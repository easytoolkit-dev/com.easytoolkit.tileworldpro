using EasyToolkit.Inspector.Editor;
using EasyToolkit.TileWorldPro;
using UnityEditor;
using UnityEngine;

namespace EasyToolkit.TileWorldPro.Editor
{
    public class ChunkAreaDrawer : EasyValueDrawer<ChunkArea>
    {
        protected override void Draw(GUIContent label)
        {
            var value = ValueEntry.SmartValue;

            EditorGUI.BeginChangeCheck();
            var position = EditorGUILayout.Vector2IntField("Position", value.Coordinate);
            var size = EditorGUILayout.Vector2IntField("Size", value.Size);
            if (EditorGUI.EndChangeCheck())
            {
                ValueEntry.SmartValue = new ChunkArea(position, size);
            }
        }
    }
}
