using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class WarriorEssence_T4 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Soul Warrior's Essence IV");
			// Tooltip.SetDefault("The humming grows louder...\nGrants +20% melee damage and 15% melee speed\nBoosts melee critical chance by 5%\nCurrent Tier: IV");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Lime;
			Item.value = Item.sellPrice(gold: 6, silver: 20);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Melee) += 0.20f;
			player.GetCritChance(DamageClass.Melee) += 5;
			player.GetAttackSpeed(DamageClass.Melee)+= 0.15f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<WarriorEssence_T3>(1)
				.AddIngredient<StraySoul>(225)
				.AddIngredient(ItemID.ChlorophyteBar, 5) //1006
				.AddTile(TileID.MythrilAnvil)
				.Register();
        }
    }
}