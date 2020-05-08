using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UpgradableGear.Items.Accessories
{
	public class WarriorEssence_T2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Warrior's Essence");
			Tooltip.SetDefault("The Essence of monsters compressed into a form that imbues the user with limited power.\nGrants +4% melee damage");
		}
		
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 0, 0, 15);
            item.rare = 0;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.meleeDamage += 0.04f;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("WarriorEssence_T1"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 10);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}