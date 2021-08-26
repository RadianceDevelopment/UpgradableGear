using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SoulSang.Items.Potions
{
	public class Soulcake : ModItem
	{
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Soulcake");
            Tooltip.SetDefault("Minor increase to all stats\nStacks to 40");
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.useStyle = ItemUseStyleID.EatingUsing;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item2; //Should be a food chomp
            Item.maxStack = 40;
            Item.consumable = true;
            Item.rare = 0;
			Item.value = Item.sellPrice(0, 0, 0, 20);
            Item.buffType = BuffID.WellFed; //Should be the low-tier one when (if) mod is ported to 1.4
            Item.buffTime = 25200; //7 Mins
		}	
	    
		public override void AddRecipes() 
		{
			CreateRecipe(1)
				.AddIngredient(mod.GetItem("MobSoul"), 20)
				// Cooking Pot
				.AddTile(96)
				.Register();
		}
    }
}