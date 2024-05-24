using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class WarriorEssence_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Soul Warrior's Essence III");
			// Tooltip.SetDefault("The Essence starts to hum, as if preparing for something...\nGrants +15% melee damage and 10% melee speed\nBoosts melee critical chance by 3%\nCurrent Tier: III");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Orange;
			Item.value = Item.sellPrice(gold: 1, silver: 70);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Melee) += 0.15f;
			player.GetCritChance(DamageClass.Melee) += 3;
			player.GetAttackSpeed(DamageClass.Melee)+= 0.10f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<WarriorEssence_T2>(1)
				.AddIngredient<StraySoul>(75)
				.AddIngredient(ItemID.HellstoneBar, 3)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}