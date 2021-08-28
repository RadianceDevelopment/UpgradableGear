using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class MageEssence_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Mage's Essence III");
			Tooltip.SetDefault("You hear the Souls whispering...\nGrants +15% Magic Damage\nIncreases magical critical chance by 4%\nReduces mana usage by 4%\nCurrent Tier: III");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Orange;
			Item.value = Item.sellPrice(gold: 1, silver: 50);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Magic) += 0.15f;
			player.GetCritChance(DamageClass.Magic) += 3;
			player.manaCost-= 0.04f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<MageEssence_T2>(1)
				.AddIngredient<MobSoul>(75)
				.AddIngredient(ItemID.HellstoneBar, 3)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}