using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulShield_T2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Shield: Tier II");
			Tooltip.SetDefault("+4 Defense\nMonster souls that have been forced to protect you\nYou've added more souls into the mix, improving the defense provided");
		}
		
        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 25;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 0, 0, 50);
            item.rare = 1;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statDefense+= 4;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulShield_T1"));
			recipe.AddIngredient(mod.GetItem("MobSoul"), 30);
			recipe.AddIngredient(ItemID.Diamond, 2);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulShield_T1"));
			recipe.AddIngredient(mod.GetItem("MobSoul"), 30);
			recipe.AddIngredient(ItemID.DemoniteBar, 4);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulShield_T1"));
			recipe.AddIngredient(mod.GetItem("MobSoul"), 30);
			recipe.AddIngredient(ItemID.CrimtaneBar, 4);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}