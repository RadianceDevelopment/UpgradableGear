using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Potions
{
	public class SoulHealingPotion : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Stacks to 40");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 26;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.useAnimation = 20;
			item.useTime = 18;
			item.useTurn = true;
			item.UseSound = SoundID.Item3;
			item.maxStack = 40;
			item.consumable = true;
			item.rare = 7;
			item.healLife = 300;
			item.potion = true;
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SuperHealingPotion, 4);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 40);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}
// Idea by a friend of mine, Xorger128