using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulTargeter_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Targeter III");
			Tooltip.SetDefault("You've crammed as many souls as possible into this thing to double its efficiency, yet again\nGrants +12% Critical Chance\nMight do more...");
		}
		
        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 25;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 15, 0, 0);
            item.rare = 6;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.magicCrit+= 12;
			player.meleeCrit+= 12;
			player.rangedCrit+= 12;
			
			player.thrownCrit+= 12;
			
			player.magicDamage+= 0.10f;
			player.meleeDamage+= 0.10f;
			player.rangedDamage+= 0.10f;
			player.minionDamage+= 0.10f;
		
			player.thrownDamage+= 0.10f;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulTargeter_T2"));
			recipe.AddIngredient(mod.GetItem("MobSoul"), 60);
			recipe.AddIngredient(ItemID.SpectreBar, 8);
			recipe.AddIngredient(ItemID.ShroomiteBar, 4);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}