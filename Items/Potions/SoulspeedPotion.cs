using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SoulSang.Items.Potions
{
	public class SoulspeedPotion : ModItem
	{
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Soulspeed Potion");
            Tooltip.SetDefault("Increases movement speed by 40%\nStacks to 40");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 25;
			Item.scale = 0.50f;
			Item.useStyle = ItemUseStyleID.EatFood;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item3;
            Item.maxStack = 40;
            Item.consumable = true;
            Item.rare = ItemRarityID.Blue;
            Item.buffType = BuffType<Buffs.Soulspeed>();
            Item.buffTime = 14400; // 4 mins
			Item.value = Item.sellPrice(silver: 5);
		}	
	    
		public override void AddRecipes() 
		{
			CreateRecipe(1)
				.AddIngredient<MobSoul>(6)
				.AddIngredient(ItemID.SwiftnessPotion)
				.AddIngredient(ItemID.SoulofNight)
				.AddTile(TileID.Bottles)
				.Register();
			
			CreateRecipe(1)
				.AddIngredient<MobSoul>(6)
				.AddIngredient(ItemID.SwiftnessPotion)
				.AddIngredient(ItemID.SoulofLight, 2)
				.AddTile(TileID.Bottles)
				.Register();
		}
    }
}