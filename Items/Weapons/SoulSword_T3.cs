using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Weapons
{
	public class SoulSword_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Sword III");
			Tooltip.SetDefault("The sword has reached its zenith");
		}
		// Be sure to make this shoot the ghost orb!
		public override void SetDefaults() 
		{
			item.damage = 100;
			item.knockBack = 10;
			item.melee = true;
			item.autoReuse = true;
			item.width = 30;
			item.height = 30;
			item.scale = 0.73f;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(0, 5, 0, 0);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulSword_Cursed"), 1);
			recipe.AddIngredient(mod.GetItem("SoulSword_Ichor"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 380);
			recipe.AddIngredient(ItemID.LunarBar, 1);
			//recipe.AddTile(TileID.SoulInfuser);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}