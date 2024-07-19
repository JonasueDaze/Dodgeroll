using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace Dodgeroll
{
    public class DodgerollConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        public static DodgerollConfig Instance;

        [DefaultValue(true)]
        public bool EnableDodgeroll { get; set; }

        [Slider]
        [DefaultValue(0.75)]
        public float InvulnerableRatio { get; set; }

        [Header("Stamina")]

        [DefaultValue(true)]
        public bool EnableStamina { get; set; }

        [Slider]
        [DefaultValue(0.2)]
        public float StaminaUsage { get; set; }

        [Slider]
        [DefaultValue(0.5)]
        public float StaminaRegenRate { get; set; }

        [Slider]
        [DefaultValue(1)]
        public float StaminaCooldown { get; set; }
    }
}