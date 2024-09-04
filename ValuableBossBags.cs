using Terraria;
using Terraria.ModLoader;

namespace ValuableBossBags
{
    public class BossBagValue : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            base.SetDefaults(item);

            var config = ModContent.GetInstance<ValuableBossBagsConfig>();
            float multiplier = config.ValueMultiplier;
            multiplier = RoundToNearest(multiplier, 0.05f);

            switch (item.type)
            {
                case ItemID.EyeOfCthulhuBossBag:
                    UpdateBossBagValue(item, config.EnableEyeOfCthulhu, multiplier, config.ValueEyeOfCthulhu);
                    Mod.Logger.Info($"EyeOfCthulhu Boss Bag Value: {item.value}");
                    break;
                case ItemID.KingSlimeBossBag:
                    UpdateBossBagValue(item, config.EnableKingSlime, multiplier, config.ValueKingSlime);
                    Mod.Logger.Info($"King Slime Boss Bag Value: {item.value}");
                    break;
            }
        }
    }
}
