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
			Tooltip.SetDefault("The sword grows in power...\nCurrent Tier: III");
		}

		public override void SetDefaults() 
		{
			item.damage = 15;
			item.knockBack = 4;
			item.melee = true;
			item.width = 40;
			item.height = 42;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.value = Item.sellPrice(0, 0, 3, 25);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulSword_T2"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 15);
			recipe.AddRecipeGroup("IronBar", 3);
			//recipe.AddTile(TileID.SoulInfuser);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}