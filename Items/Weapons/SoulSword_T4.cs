using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Weapons
{
	public class SoulSword_T4 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Sword IV");
			Tooltip.SetDefault("The sword ripples with energy...\nCurrent Tier: IV");
		}

		public override void SetDefaults() 
		{
			item.damage = 22;
			item.knockBack = 4;
			item.melee = true;
			item.width = 42;
			item.height = 45;
			item.useTime = 22;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.value = Item.sellPrice(0, 0, 30, 0);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulSword_T3"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 20);
			recipe.AddIngredient(ItemID.Ruby, 3);
			//recipe.AddTile(TileID.SoulInfuser);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}