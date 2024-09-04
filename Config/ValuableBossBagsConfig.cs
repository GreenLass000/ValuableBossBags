using Terraria.ModLoader.Config;

namespace ValuableBossBags
{
    public class ValuableBossBagsConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Header("ValueMultiplier")]
        [Range(0.5f, 10f)]
        public float ValueMultiplier { get; set; } = 1f;

        [Header("BossBagsEnable/DisableValue")]
        public bool EnableEyeOfCthulhu { get; set; } = true;
        public bool EnableKingSlime { get; set; } = true;

        [Header("BossBagValues")]
        public int ValueEyeOfCthulhu { get; set; } = 10;
        public int ValueKingSlime { get; set; } = 15;
    }
}
