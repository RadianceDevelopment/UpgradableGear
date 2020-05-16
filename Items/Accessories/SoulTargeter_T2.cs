using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulTargeter_T2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Tier II Soul Targeter");
			Tooltip.SetDefault("You've added more Souls into the housing to double the efficiency\nGrants +6% Critical Chance");
		}
		
        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 25;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 3, 20, 75);
            item.rare = 4;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.magicCrit+= 6;
			player.meleeCrit+= 6;
			player.rangedCrit+= 6;
			
			player.thrownCrit+= 6;
			
			player.magicDamage+= 0.07f;
			player.meleeDamage+= 0.07f;
			player.rangedDamage+= 0.07f;
			player.minionDamage+= 0.07f;
		
			player.thrownDamage+= 0.07f;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulTargeter_T1")); //Inherited
			recipe.AddIngredient(mod.GetItem("MobSoul"), 45); //+45 Copper
			recipe.AddIngredient(ItemID.HellstoneBar, 5); //+2 Gold
			recipe.AddIngredient(ItemID.CobaltBar, 5); //+~1 Gold, 20 Silver (if average price per bar is 24 Silver since both have dif values)
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulTargeter_T1"));
			recipe.AddIngredient(mod.GetItem("MobSoul"), 45);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddIngredient(ItemID.PalladiumBar, 5);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}