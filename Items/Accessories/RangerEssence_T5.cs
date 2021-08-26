using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class RangerEssence_T5 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("True Soul Sniper's Essence");
			Tooltip.SetDefault("The essence convulses for a moment, shoots a salvo of ectoplasm, then reveals its true form\nGrants +25% Ranged Damage\nBoosts ranged critical chance by 12%\nCurrent Tier: V");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            Item.rare = 9;
			Item.accessory = true;
			Item.value = Item.sellPrice(copper: 0);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			Player.GetDamage(DamageClass.Ranged) += 0.25f;
			player.rangedCrit+= 12;
			// Add 20% reduced ammo usage
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(mod.GetItem("RangerEssence_T4"), 1)
				.AddIngredient(mod.GetItem("MobSoul"), 40)
				.AddIngredient(ItemID.FragmentVortex, 5)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
        }
    }
}