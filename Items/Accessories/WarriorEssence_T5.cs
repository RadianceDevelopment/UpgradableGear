using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class WarriorEssence_T5 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("True Soul Warrior's Essence");
			// Tooltip.SetDefault("The Essence twists and convulses, then reveals its true form\nGrants +25% melee damage and +20% melee speed\nBoosts melee critical chance by 8%\nCurrent Tier: V");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Cyan;
			Item.value = Item.sellPrice(gold: 7, silver: 20);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Melee) += 0.25f;
			player.GetCritChance(DamageClass.Melee) += 8;
			player.GetAttackSpeed(DamageClass.Melee)+= 0.20f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<WarriorEssence_T4>(1)
				.AddIngredient<StraySoul>(500)
				.AddIngredient(ItemID.FragmentSolar, 10)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
        }
    }
}