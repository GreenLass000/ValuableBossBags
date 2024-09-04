using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ValuableBossBags
{
    public class BossBagValue : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            base.SetDefaults(item);

            // Obtener la configuración
            var config = ModContent.GetInstance<ValuableBossBagsConfig>();
            float multiplier = config.ValueMultiplier;
            multiplier = RoundToNearest(multiplier, 0.05f);

            // Modificar el valor de las bolsas de jefes según la configuración
            switch (item.type)
            {
                case ItemID.EyeOfCthulhuBossBag:
                    UpdateBossBagValue(item, config.EnableEyeOfCthulhu, multiplier, config.ValueEyeOfCthulhu);
                    break;
                case ItemID.KingSlimeBossBag:
                    UpdateBossBagValue(item, config.EnableKingSlime, multiplier, config.ValueKingSlime);
                    break;
                    // Añadir más jefes aquí si es necesario
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
