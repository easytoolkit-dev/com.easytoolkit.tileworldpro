using UnityEngine;

namespace EasyToolkit.TileWorldPro
{
    public abstract class TerrainRuleBase
    {
        public abstract TerrainRuleType RuleType { get; }

        public abstract GameObject GetTileInstanceByRuleType(TerrainTileRuleType ruleType);
    }
}
