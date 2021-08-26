using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Potions
{
	public class SoulHealingPotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soul Healing Potion");
			Tooltip.SetDefault("Stacks to 40");
		}

		public override void SetDefaults() {
			Item.width = 20;
			Item.height = 26;
			Item.scale = 0.50f;
			Item.useStyle = ItemUseStyleID.EatFood;
			Item.useAnimation = 20;
			Item.useTime = 18;
			Item.useTurn = true;
			Item.UseSound = SoundID.Item3;
			Item.maxStack = 40;
			Item.consumable = true;
			Item.rare = 7;
			Item.healLife = 350;
			Item.potion = true;
		}
		
		public override void AddRecipes() 
		{
			CreateRecipe(4)
				.AddIngredient(ItemID.SuperHealingPotion, 4)
				.AddIngredient(mod.GetItem("MobSoul"), 40)
				.AddTile(TileID.Bottles)
				.Register();
		}
	}
}
// Idea by a friend of mine, Xorger128