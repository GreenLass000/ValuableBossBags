using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ValuableBossBags;

namespace ValuableBossBags
{
    public class BossBagValue : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            base.SetDefaults(item);

            // Acceder a la configuración usando ValuableBossBagsConfig
            var config = ValuableBossBagsConfig.Instance;
            float multiplier = config.ValueMultiplier;
            multiplier = RoundToNearest(multiplier, 0.05f);

            // Modificar el valor de las bolsas de jefes según la configuración
            switch (item.type)
            {
                case ItemID.KingSlimeBossBag:
                    UpdateBossBagValue(
                        item,
                        config.EnableKingSlime,
                        multiplier,
                        50
                    );
                    break;

                case ItemID.EyeOfCthulhuBossBag:
                    UpdateBossBagValue(
                        item,
                        config.EnableEyeOfCthulhu,
                        multiplier,
                        80
                    );
                    break;

                case ItemID.EaterOfWorldsBossBag:
                    UpdateBossBagValue(
                        item,
                        config.EnableEaterOfWorlds,
                        multiplier,
                        80
                    );
                    break;

                case ItemID.BrainOfCthulhuBossBag:
                    UpdateBossBagValue(
                        item,
                        config.EnableBrainOfCthulhu,
                        multiplier,
                        80
                    );
                    break;

                case ItemID.QueenBeeBossBag:
                    UpdateBossBagValue(
                        item,
                        config.EnableQueenBee,
                        multiplier,
                        70
                    );
                    break;

                case ItemID.SkeletronBossBag:
                    UpdateBossBagValue(
                        item,
                        config.EnableSkeletron,
                        multiplier,
                        100
                    );
                    break;

                case ItemID.WallOfFleshBossBag:
                    UpdateBossBagValue(
                        item,
                        config.EnableWallOfFlesh,
                        multiplier,
                        130
                    );
                    break;

                case ItemID.DestroyerBossBag:
                    UpdateBossBagValue(
                        item,
                        config.EnableDestroyer,
                        multiplier,
                        140
                    );
                    break;

                case ItemID.TwinsBossBag:
                    UpdateBossBagValue(
                        item,
                        config.EnableTwins,
                        multiplier,
                        140
                    );
                    break;

                case ItemID.SkeletronPrimeBossBag:
                    UpdateBossBagValue(
                        item,
                        config.EnableSkeletronPrime,
                        multiplier,
                        140
                    );
                    break;

                case ItemID.PlanteraBossBag:
                    UpdateBossBagValue(
                        item,
                        config.EnablePlantera,
                        multiplier,
                        180
                    );
                    break;

                case ItemID.GolemBossBag:
                    UpdateBossBagValue(
                        item,
                        config.EnableGolem,
                        multiplier,
                        200
                    );
                    break;

                case ItemID.FishronBossBag:
                    UpdateBossBagValue(
                        item,
                        config.EnableFishron,
                        multiplier,
                        200
                    );
                    break;

                case ItemID.CultistBossBag:
                    UpdateBossBagValue(
                        item,
                        config.EnableCultist,
                        multiplier,
                        250
                    );
                    break;

                case ItemID.MoonLordBossBag:
                    UpdateBossBagValue(
                        item,
                        config.EnableMoonLord,
                        multiplier,
                        350
                    );
                    break;

                case ItemID.BossBagBetsy:
                    UpdateBossBagValue(
                        item,
                        config.EnableBetsy,
                        multiplier,
                        300
                    );
                    break;

                case ItemID.BossBagOgre:
                    UpdateBossBagValue(
                        item,
                        config.EnableOgre,
                        multiplier,
                        180
                    );
                    break;

                case ItemID.BossBagDarkMage:
                    UpdateBossBagValue(
                        item,
                        config.EnableDarkMage,
                        multiplier,
                        160
                    );
                    break;

                case ItemID.FairyQueenBossBag:
                    UpdateBossBagValue(
                        item,
                        config.EnableFairyQueen,
                        multiplier,
                        220
                    );
                    break;

                case ItemID.QueenSlimeBossBag:
                    UpdateBossBagValue(
                        item,
                        config.EnableQueenSlime,
                        multiplier,
                        180
                    );
                    break;

                case ItemID.DeerclopsBossBag:
                    UpdateBossBagValue(
                        item,
                        config.EnableDeerclops,
                        multiplier,
                        150
                    );
                    break;

                default:
                    break;
            }
        }

        private void UpdateBossBagValue(Item item, bool isEnabled, float multiplier, int baseValue)
        {
            if (isEnabled)
            {
                // Convertir el valor base a cobre y aplicarle el multiplicador
                int valueInCoppers = Item.sellPrice(gold: baseValue);
                item.value = (int)(valueInCoppers * multiplier);
            }
            else
            {
                item.value = 0;
            }
        }

        private float RoundToNearest(float value, float step)
        {
            return (float)(System.Math.Round(value / step) * step);
        }
    }
}
