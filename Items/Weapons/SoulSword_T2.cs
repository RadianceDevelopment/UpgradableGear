using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Weapons
{
	public class SoulSword_T2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Sword II");
			Tooltip.SetDefault("The sword pulses with energy");
		}

		public override void SetDefaults() 
		{
			item.damage = 25;
			item.knockBack = 3;
			item.melee = true;
			item.width = 25;
			item.height = 25;
			item.scale = 0.70f;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.value = Item.sellPrice(0, 0, 1, 75);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulSword_T1"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 8);
			recipe.AddIngredient(ItemID.Ruby, 4);
			//recipe.AddTile(TileID.SoulInfuser);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}