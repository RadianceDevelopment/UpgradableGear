using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Weapons
{
	public class SoulSword_T2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Soul Sword II");
			// Tooltip.SetDefault("The sword pulses with energy...");
		}

		public override void SetDefaults() 
		{
			Item.damage = 25;
			Item.knockBack = 3;
			Item.crit = 2;
			// Remember that Item.crit adds to the base 4%
			Item.DamageType = DamageClass.Melee;
			Item.width = 25;
			Item.height = 25;
			Item.scale = 0.70f;
			Item.useTime = 25;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.rare = 1;
			Item.autoReuse = false;
			Item.UseSound = SoundID.Item1;
			Item.value = Item.sellPrice(gold: 1, silver: 12, copper: 50);
		}

		public override void AddRecipes() 
		{
			CreateRecipe(1)
				.AddIngredient<SoulSword_T1>(1)
				.AddIngredient<StraySoul>(6)
				.AddIngredient(ItemID.Ruby, 5)
				.AddTile(TileID.Anvils)
				.Register();
				
			CreateRecipe(1)
				.AddIngredient<SoulSword_T1>(1)
				.AddIngredient<StraySoul>(6)
				.AddIngredient(ItemID.Diamond, 1)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}