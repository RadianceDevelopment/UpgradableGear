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
			// DisplayName.SetDefault("Soulcake");
            // Tooltip.SetDefault("Minor increase to all stats\nIsn't a lie, but also isn't real.");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.useStyle = ItemUseStyleID.EatFood;
            Item.UseSound = SoundID.Item2; // Should be a food chomp
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useTurn = true;
            Item.maxStack = 20;
            Item.consumable = true;
            Item.rare = 0;
            Item.buffType = BuffID.WellFed;
            Item.buffTime = 25200; // 7 mins
			Item.value = 0;
		}	
	    
		public override void AddRecipes() 
		{
			CreateRecipe(1)
				.AddIngredient<StraySoul>(10)
				.AddTile(96) // Cooking Pot
                .Register();
		}
    }
}