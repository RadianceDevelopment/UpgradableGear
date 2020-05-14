using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SoulSang.Items.Potions
{
	public class Soulcake : ModItem
	{
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Soulcake");
            Tooltip.SetDefault("Minor increase to all stats\nStacks to 40");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 25;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 15;
            item.useTime = 15;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 40;
            item.consumable = true;
            item.rare = 1;
			item.value = Item.sellPrice(0, 0, 0, 20);
            item.buffType = BuffType<Buffs.Soulskin>(); // Change to Well Fed
            item.buffTime = 72000; //20 Mins
		}	
	    
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 20);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}