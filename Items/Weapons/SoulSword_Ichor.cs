using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Weapons
{
	public class SoulSword_Ichor : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ichor-Coated Soul Sword");
			Tooltip.SetDefault("You've transformed the sword into a more specialized one.\nInflicts Ichor for 3 seconds 50% of the time");
	    }

		public override void SetDefaults() 
		{
			Item.damage = 33;
			Item.knockBack = 5;
			Item.crit = 6;
			// Remember that Item.crit adds to the base 4%
			Item.DamageType = DamageClass.Melee;
			Item.width = 70;
			Item.height = 85;
			Item.scale = 0.75f;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = 1;
			Item.autoReuse = true;
            Item.rare = ItemRarityID.Orange;
			Item.UseSound = SoundID.Item1;
			Item.value = Item.sellPrice(silver: 90);
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient<SoulSword_T2>(1)
				.AddIngredient<MobSoul>(150)
				.AddIngredient(ItemID.Ichor, 10)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
		
	    public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// Remember, 60 ticks = 1 second
			if(Main.rand.NextBool(2)){
			target.AddBuff(BuffID.Ichor, 180);
			// 3 Seconds^
		  }
		}
	}
}
// Shoutout to absoluteAquarian#5189 on the TML Discord for fixing the debuff application not working