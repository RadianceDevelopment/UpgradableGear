using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulTargeter_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Targeter III");
			Tooltip.SetDefault("You've crammed as many souls as possible into this thing to double its efficiency, yet again\nGrants +12% Critical Chance\nMight do something extra...");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Lime;
			Item.value = Item.sellPrice(gold: 12, silver: 65);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetCritChance(DamageClass.Magic) += 12;
			player.GetCritChance(DamageClass.Melee) += 12;
			player.GetCritChance(DamageClass.Ranged) += 12;
			
			player.GetDamage(DamageClass.Magic) += 0.10f;
			player.GetDamage(DamageClass.Melee) += 0.10f;
			player.GetDamage(DamageClass.Ranged) += 0.10f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<SoulTargeter_T2>(1)
				.AddIngredient<MobSoul>(60)
				.AddIngredient(ItemID.SpectreBar, 5)
				.AddIngredient(ItemID.ShroomiteBar, 5)
				.AddTile(TileID.MythrilAnvil)
				.Register();
        }
    }
}