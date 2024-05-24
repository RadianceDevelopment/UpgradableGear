using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Weapons
{
	public class SoulSword_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("True Soul Sword");
			// Tooltip.SetDefault("The sword has reached its zenith\nInflicts Cursed Inferno for 7 seconds and Ichor for 5 seconds 50% of the time.");
		}
		// Be sure to make this shoot the ghost orb!
		public override void SetDefaults() 
		{
			Item.damage = 200;
			Item.knockBack = 5;
			Item.crit = 1;
			// Remember that Item.crit adds to the base 4%
			Item.DamageType = DamageClass.Melee;
			Item.width = 90;
			Item.height = 100;
			Item.scale = 0.85f;
			Item.useTime = 10;
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
				.AddIngredient<StraySoul>(24)
				.AddIngredient(ItemID.LunarBar, 5)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
		}
		
		 public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
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