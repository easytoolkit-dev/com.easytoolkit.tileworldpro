using System;
using EasyToolkit.Inspector.Attributes;
using UnityEngine;

namespace EasyToolkit.TileWorldPro
{
    [Serializable]
    public class TileWorldBuilderSettings
    {
        [LabelText("实时增量构建")]
        [SerializeField] private bool _realTimeIncrementalBuild = true;

        public bool RealTimeIncrementalBuild => _realTimeIncrementalBuild;
    }
}
