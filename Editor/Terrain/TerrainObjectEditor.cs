using EasyToolkit.Inspector;
using EasyToolkit.Inspector.Editor;
using EasyToolkit.TileWorldPro;
using UnityEditor;

namespace EasyToolkit.TileWorldPro.Editor
{
    [CustomEditor(typeof(ChunkTerrainObject))]
    public class TerrainObjectEditor : EasyEditor
    {
        protected override void DrawTree()
        {
            Tree.BeginDraw();
            EditorGUILayout.LabelField("地形GUID", ((ChunkTerrainObject)target).TerrainDefinition.Guid.ToString("D"));
            Tree.DrawElements();
            Tree.EndDraw();
        }
    }
}
