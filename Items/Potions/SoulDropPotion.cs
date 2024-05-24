/*
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SoulSang.Items.Potions
{
	public class SoulDropPotion : ModItem
	{
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Soul Stealer's Potion");
            Tooltip.SetDefault("Increases droprate of Monster Souls by 25% (for 5 mins)\nStacks to 20");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 25;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 15;
            item.useTime = 15;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 20;
            item.consumable = true;
            item.rare = 3;
            item.buffType = BuffType<Buffs.ExampleDefenseBuff>(); //Specify an existing buff to be applied when used.
            item.buffTime = 5400; //The amount of time the buff declared in item.buffType will last in ticks. 5400/60 is 90, so this buff will last 90 seconds.
			Item.value = Item.sellPrice(copper: 0);
        }
    }
}

This will increase the droprate of Monster Souls if I ever figure out how to do that

*/