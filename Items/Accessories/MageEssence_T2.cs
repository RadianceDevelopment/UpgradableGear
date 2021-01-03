using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class MageEssence_T2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Mage's Essence II");
			Tooltip.SetDefault("The Souls stir, as if trying to converse with you...\nGrants +10% magic damage\nReduces mana usage by 3%\nCurrent Tier: II");
		}
		
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 0, 25, 0);
            item.rare = 2;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.magicDamage+= 0.10f;
			player.manaCost-= 0.03f;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MageEssence_T1"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 10);
			recipe.AddIngredient(ItemID.Sapphire, 3);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MageEssence_T1"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 10);
			recipe.AddIngredient(ItemID.Diamond, 1);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}