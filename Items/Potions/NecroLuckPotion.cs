using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SoulSang.Items.Potions
{
	public class NecroLuckPotion : ModItem
	{
        public override void SetStaticDefaults()
        {
			// DisplayName.SetDefault("Necromantic Luck Potion");
            // Tooltip.SetDefault("Changes one's Luck\nGained through unsavoury means...");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
			Item.consumable = true;
			Item.useStyle = ItemUseStyleID.EatFood;
			Item.UseSound = SoundID.Item3;
			Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useTurn = true;
            Item.maxStack = 30;
			Item.rare = ItemRarityID.Green;
			Item.buffType = 257; // Lucky
			Item.buffTime = 108000; // 30 mins
			Item.value = Item.sellPrice(gold: 30);
		}
	    
		public override void AddRecipes() 
		{
			CreateRecipe(3)
				.AddIngredient<StraySoul>(30)
				.AddIngredient(4477) // Lesser Luck Potion
				.AddIngredient(4478) // Luck Potion
				.AddIngredient(4479) // Greater Luck Potion
				.AddTile(TileID.Bottles)
				.Register();

			CreateRecipe(6)
				.AddIngredient<StraySoul>(125)
				.AddIngredient(4479, 3) // Greater Luck Potion
				.AddTile(TileID.Bottles)
				.Register();
		}
    }
}