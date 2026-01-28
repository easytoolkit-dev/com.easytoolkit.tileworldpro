using System;
using EasyToolkit.Inspector.Attributes;
using UnityEngine;

namespace EasyToolkit.TileWorldPro
{
    [MetroFoldoutGroup("填充规则集", IconTextureGetter = "-t:EasyToolkit.TileWorldPro.Editor.TileWorldIcons -p:Instance.TerrainFillTypeIcon")]
    [HideLabel]
    [Serializable]
    public class TerrainFillRule : TerrainRuleBase
    {
        [TerrainTileRuleType(TerrainTileRuleType.Fill)]
        [SerializeField] private TerrainTileDefinition _fillTileDefinition;

        public override TerrainRuleType RuleType => TerrainRuleType.Fill;

        public override GameObject GetTileInstanceByRuleType(TerrainTileRuleType ruleType)
        {
            if (ruleType == TerrainTileRuleType.Fill)
            {
                return _fillTileDefinition.TryInstantiate();
            }

            throw new ArgumentOutOfRangeException(nameof(ruleType), ruleType, null);
        }
    }
}
