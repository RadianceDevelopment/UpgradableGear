using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulTargeter_T1 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Targeter I");
			Tooltip.SetDefault("Souls that have been fashioned in a way that makes them enhance the bearer's ability to inflict great damage\nGrants +3% Critical Chance");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.White;
			Item.value = Item.sellPrice(copper: 0);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetCritChance(DamageClass.Magic) += 3;
			player.GetCritChance(DamageClass.Melee) += 3;
			player.GetCritChance(DamageClass.Ranged) += 3;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<MobSoul>(30)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}