using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulKnuckles : ModItem
	{
		public override void SetStaticDefaults() 
		{
            // DisplayName.SetDefault("Soulified Clawed Knuckles");
            // Tooltip.SetDefault("+5 Defense\n+20% Melee Speed\nA set of claws that have fleshy knuckles embedded into them\nInfused with many souls to amplify its power\nStrange whispers seem to emanate from it....");
            /*
			 Total stat gains:
				+10 defense
				+15% melee damage (combo is 12)
				+30% melee speed (combo is 24)
				Hellfire debuff on hit
				+400 aggro

				Extra size (20%) & knockback (200%)
				Autoswing on everything
			 */
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            Item.rare = ItemRarityID.Yellow;
			Item.accessory = true;
			Item.value = Item.sellPrice(gold: 15);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statDefense+= 10;
            player.GetDamage(DamageClass.Melee) += 0.15f;
            player.GetAttackSpeed(DamageClass.Melee)+= 0.30f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(ItemID.BerserkerGlove)
                .AddIngredient(ItemID.FireGauntlet)
                .AddIngredient<StraySoul>(500)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
        }
    }
}