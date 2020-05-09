using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UpgradableGear.Items.Weapons
{
	public class SoulSword_T8 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Sword");
			Tooltip.SetDefault("The sword resonants with power, and lights up with cursed flames...\nHeals equal to the damage dealt divided by 8\nEnemies are enveloped in cursed fire 33% of the time\nLaunches a ghostly projectile when swung (Still WIP!)\nCurrent Tier: VIII");
	    }

		public override void SetDefaults() 
		{
			item.damage = 70;
			item.knockBack = 7;
			item.crit = 8;
			item.melee = true;
			item.width = 50;
			item.height = 60;
			item.useTime = 19;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.value = Item.sellPrice(0, 4, 50, 0);
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulSword_T7"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 75);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 7);
			recipe.AddIngredient(ItemID.SoulofFright, 5);
			recipe.AddIngredient(ItemID.SoulofMight, 5);
			recipe.AddIngredient(ItemID.SoulofSight, 5);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	    public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// I assume you can make healingAmount any number or formula?
			int healingAmount = damage/8;
			player.statLife +=healingAmount;
			player.HealEffect(healingAmount, true);
		
			if(Main.rand.NextBool(2)){
			target.AddBuff(BuffID.Frostburn, 300);
		}
	  }
	}
}
// Shoutout to absoluteAquarian#5189 on the TML Discord for fixing the debuff application not working
// Item.crit adds to the base 4%

// Add projectile