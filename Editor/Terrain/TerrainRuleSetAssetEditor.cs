using EasyToolkit.Core.Editor;
using EasyToolkit.Inspector.Editor;
using UnityEditor;
using UnityEngine;

namespace EasyToolkit.TileWorldPro.Editor
{
    [CustomEditor(typeof(TerrainRuleSetAsset))]
    public class TerrainRuleSetAssetEditor : EasyEditor
    {
        private static readonly GUIContent TempContent = new GUIContent();

        protected override void DrawTree()
        {
            Tree.BeginDraw();

            if (!IsInlineEditor)
            {
                MetroBoxGroupDrawer.BeginDraw(TempContent.SetText("地形规则集"), null);
            }

            Tree.DrawElements();

            if (!IsInlineEditor)
            {
                MetroBoxGroupDrawer.EndDraw();
            }

            Tree.EndDraw();
        }
    }
}
