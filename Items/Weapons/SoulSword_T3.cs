using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Weapons
{
	public class SoulSword_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("True Soul Sword");
			Tooltip.SetDefault("The sword has reached its zenith\nInflicts Cursed Flames and Ichor 50% of the time.");
		}
		// Be sure to make this shoot the ghost orb!
		public override void SetDefaults() 
		{
			Item.damage = 200;
			Item.knockBack = 5;
			Item.crit = 1;
			// Remember that Item.crit adds to the base 4%
			Item.DamageType = DamageClass.Melee;
			Item.width = 30;
			Item.height = 30;
			Item.scale = 0.85f;
			Item.useTime = 5;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.autoReuse = true;
            Item.rare = ItemRarityID.Purple;
			Item.UseSound = SoundID.Item1;
			Item.value = Item.sellPrice(gold: 8, silver: 82, copper: 50);
		}

		public override void AddRecipes() 
		{
			CreateRecipe(1)
				.AddIngredient<SoulSword_Cursed>(1)
				.AddIngredient<SoulSword_Ichor>(1)
				.AddIngredient<MobSoul>(12)
				.AddIngredient(ItemID.LunarBar, 5)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
		}
		
		 public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// Remember, 60 ticks = 1 second
			if(Main.rand.NextBool(2)){
			target.AddBuff(BuffID.CursedInferno, 420); // Nice!
			// 7 Seconds^
		  }
			// Remember, 60 ticks = 1 second
			if(Main.rand.NextBool(2)){
			target.AddBuff(BuffID.Ichor, 300);
			// 5 Seconds^
		  }
		}
	}
}