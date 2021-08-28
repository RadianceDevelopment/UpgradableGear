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
			Tooltip.SetDefault("The essence convulses for a moment, shoots a salvo of ectoplasm, then reveals its true form\nGrants +25% Ranged Damage\nBoosts ranged critical chance by 8%\nCurrent Tier: V");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Cyan;
			Item.value = Item.sellPrice(gold: 6, silver: 55);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Ranged) += 0.25f;
			player.GetCritChance(DamageClass.Ranged) += 8;
			// Add 20% reduced ammo usage
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<RangerEssence_T4>(1)
				.AddIngredient<MobSoul>(500)
				.AddIngredient(ItemID.FragmentVortex, 5)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
        }
    }
}