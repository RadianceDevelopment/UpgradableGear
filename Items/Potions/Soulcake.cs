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
            item.width = 20;
            item.height = 25;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 15;
            item.useTime = 15;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 40;
            item.consumable = true;
            item.rare = 0;
			item.value = Item.sellPrice(0, 0, 0, 20);
            item.buffType = BuffID.WellFed;
            item.buffTime = 25200; //7 Mins
		}	
	    
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 20);
			// Cooking Pot
			recipe.AddTile(96);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}