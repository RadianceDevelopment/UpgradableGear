using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Potions
{
	public class SoulHealingPotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Soul Healing Potion");
		}

		public override void SetDefaults() {
			Item.width = 20;
			Item.height = 26;
			Item.scale = 0.50f;
			Item.useStyle = ItemUseStyleID.EatFood;
            Item.UseSound = SoundID.Item3;
            Item.useAnimation = 20;
			Item.useTime = 18;
			Item.useTurn = true;
			Item.maxStack = 30;
			Item.consumable = true;
			Item.rare = 7;
			Item.healLife = 300;
			Item.potion = true;
			Item.value = Item.sellPrice(silver: 30);
		}
		
		public override void AddRecipes() 
		{
			CreateRecipe(4)
				.AddIngredient(ItemID.SuperHealingPotion, 4)
				.AddIngredient<StraySoul>(50)
				.AddTile(TileID.Bottles)
				.Register();
		}
	}
}
// Idea by a former friend of mine, Xorger128