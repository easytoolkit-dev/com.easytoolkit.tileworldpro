using EasyToolkit.Core.Patterns;
using EasyToolkit.Inspector.Attributes;
using UnityEngine;

namespace EasyToolkit.TileWorldPro
{
    [EasyInspector]
    [ScriptableObjectSingletonConfiguration(null, ScriptableObjectLoadMode.Asset)]
    public class TileWorldConfigAsset : ScriptableObjectSingleton<TileWorldConfigAsset>
    {
        [LabelText("世界高度限制")]
        [SerializeField] private int _heightLimit = 256;

        [LabelText("世界区块大小")]
        [SerializeField] private Vector2Int _chunkSize = new Vector2Int(16, 16);

        public Vector2Int ChunkSize => _chunkSize;
        public int HeightLimit => _heightLimit;
    }
}
