using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulTargeter_T2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Targeter II");
			Tooltip.SetDefault("You've added more Souls into the housing to double the efficiency\nGrants +6% Critical Chance\nMight do something extra...");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Orange;
			Item.value = Item.sellPrice(gold: 2, silver: 65);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetCritChance(DamageClass.Magic) += 6;
			player.GetCritChance(DamageClass.Melee) += 6;
			player.GetCritChance(DamageClass.Ranged) += 6;
			
			player.GetDamage(DamageClass.Magic) += 0.07f;
			player.GetDamage(DamageClass.Melee) += 0.07f;
			player.GetDamage(DamageClass.Ranged) += 0.07f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<SoulTargeter_T1>(1)
				.AddIngredient<MobSoul>(45)
				.AddIngredient(ItemID.HellstoneBar, 5)
				.AddIngredient(ItemID.CobaltBar, 3)
				.AddTile(TileID.Anvils)
				.Register();
			
			CreateRecipe(1)
				.AddIngredient<SoulTargeter_T1>(1)
				.AddIngredient<MobSoul>(45)
				.AddIngredient(ItemID.HellstoneBar, 5)
				.AddIngredient(ItemID.PalladiumBar, 3)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}