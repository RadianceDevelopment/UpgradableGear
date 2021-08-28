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
            Tooltip.SetDefault("Minor increase to all stats\nStacks to 20");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.useStyle = ItemUseStyleID.EatFood;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item2; // Should be a food chomp
            Item.maxStack = 20;
            Item.consumable = true;
            Item.rare = 0;
            Item.buffType = BuffID.WellFed;
            Item.buffTime = 25200; // 7 mins
			Item.value = Item.sellPrice(copper: 0);
		}	
	    
		public override void AddRecipes() 
		{
			CreateRecipe(1)
				.AddIngredient<MobSoul>(10)
				// Cooking Pot
				.AddTile(96)
				.Register();
		}
    }
}