using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace ValuableBossBags
{
    public class ValuableBossBagsConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        public static ValuableBossBagsConfig Instance => ModContent.GetInstance<ValuableBossBagsConfig>();

        [Header("ValueMultiplier")]
        [Range(0.5f, 10f)]
        public float ValueMultiplier { get; set; } = 1f;

        [Header("BossBagsEnable/DisableValue")]
        public bool EnableEyeOfCthulhu { get; set; } = true;
        public bool EnableKingSlime { get; set; } = true;
        public bool EnableEaterOfWorlds { get; set; } = true;
        public bool EnableBrainOfCthulhu { get; set; } = true;
        public bool EnableQueenBee { get; set; } = true;
        public bool EnableSkeletron { get; set; } = true;
        public bool EnableWallOfFlesh { get; set; } = true;
        public bool EnableTwins { get; set; } = true;
        public bool EnableDestroyer { get; set; } = true;
        public bool EnableSkeletronPrime { get; set; } = true;
        public bool EnablePlantera { get; set; } = true;
        public bool EnableGolem { get; set; } = true;
        public bool EnableFishron { get; set; } = true;
        public bool EnableCultist { get; set; } = true;
        public bool EnableMoonLord { get; set; } = true;
        public bool EnableDeerclops { get; set; } = true;
        public bool EnableFairyQueen { get; set; } = true;
        public bool EnableQueenSlime { get; set; } = true;
        public bool EnableDarkMage { get; set; } = true;
        public bool EnableOgre { get; set; } = true;
        public bool EnableBetsy { get; set; } = true;

        [Header("BossBagValues")]
        public int ValueEyeOfCthulhu { get; set; } = 80;
        public int ValueKingSlime { get; set; } = 50;
        public int ValueEaterOfWorlds { get; set; } = 80;
        public int ValueBrainOfCthulhu { get; set; } = 80;
        public int ValueQueenBee { get; set; } = 70;
        public int ValueSkeletron { get; set; } = 100;
        public int ValueWallOfFlesh { get; set; } = 130;
        public int ValueTwins { get; set; } = 140;
        public int ValueDestroyer { get; set; } = 140;
        public int ValueSkeletronPrime { get; set; } = 140;
        public int ValuePlantera { get; set; } = 180;
        public int ValueGolem { get; set; } = 200;
        public int ValueFishron { get; set; } = 200;
        public int ValueCultist { get; set; } = 250;
        public int ValueMoonLord { get; set; } = 350;
        public int ValueDeerclops { get; set; } = 150;
        public int ValueFairyQueen { get; set; } = 220;
        public int ValueQueenSlime { get; set; } = 180;
        public int ValueDarkMage { get; set; } = 160;
        public int ValueOgre { get; set; } = 180;
        public int ValueBetsy { get; set; } = 300;
    }
}
