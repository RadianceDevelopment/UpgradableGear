using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class WarriorEssence_T1 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Warrior's Essence");
			Tooltip.SetDefault("The Essence of monsters compressed into a form that imbues the user with a bit of power.\nGrants +5% melee damage\nCurrent Tier: I");
		}
		
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 0, 0, 50);
            item.rare = 0;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.meleeDamage+= 0.05f;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 10);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
// No, the name isn't a Hollow Knight reference. I didn't even think of that until recently tbh