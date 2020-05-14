using Terraria;
using Terraria.ModLoader;

namespace SoulSang.Buffs
{
    public class Soulskin : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Soulskin");
            Description.SetDefault("Grants +12 defense");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 12;
        }
    }
}
