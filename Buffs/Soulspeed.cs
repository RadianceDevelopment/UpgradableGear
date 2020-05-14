using Terraria;
using Terraria.ModLoader;

namespace SoulSang.Buffs
{
    public class Soulspeed : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Soulpeed");
            Description.SetDefault("40% increased movement speed");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed+= 0.40f;
        }
    }
}