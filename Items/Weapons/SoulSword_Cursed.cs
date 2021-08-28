using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Weapons
{
	public class SoulSword_Cursed : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cursed Soul Sword");
			Tooltip.SetDefault("You've transformed the sword into a more specialized one.\nInflicts Cursed Flames for 5 seconds 50% of the time");
	    }

		public override void SetDefaults() 
		{
			Item.damage = 30;
			Item.knockBack = 3;
			Item.crit = 8;
			// Remember that Item.crit adds to the base 4%
			Item.DamageType = DamageClass.Melee;
			Item.width = 70;
			Item.height = 85;
			Item.scale = 0.75f;
			Item.useTime = 10;
			Item.useAnimation = 15;
			Item.useStyle = 1;
			Item.autoReuse = true;
            Item.rare = ItemRarityID.Orange;
			Item.UseSound = SoundID.Item1;
			Item.value = Item.sellPrice(silver: 80);
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient<SoulSword_T2>(1)
				.AddIngredient<MobSoul>(150)
				.AddIngredient(ItemID.CursedFlame, 10)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
		
	    public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// Remember, 60 ticks = 1 second
			if(Main.rand.NextBool(2)){
			target.AddBuff(BuffID.CursedInferno, 300);
			// 5 Seconds^
		  }
		}
	}
}
// Shoutout to absoluteAquarian#5189 on the TML Discord for fixing the debuff application not working