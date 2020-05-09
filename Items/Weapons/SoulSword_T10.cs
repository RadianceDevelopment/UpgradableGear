using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UpgradableGear.Items.Weapons
{
	public class SoulSword_T10 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("True Soul Sword");
			Tooltip.SetDefault("The sword convulses for a moment, then reveals its true form.\nAt last, you have fed it enough energy to weild its ultimate power.\nHeals equal to the damage dealt divided by 5\nInflicts Frostburn and On Fire! 50% of the time\nLaunches a ghostly projectile when swung (Still WIP!)\n Inflicts Frostburn 50% of the time\nFoes drop extra money when killed\nCurrent Tier: X");
	    }

		public override void SetDefaults() 
		{
			item.damage = 225;
			item.knockBack = 10;
			item.crit = 16;
			item.melee = true;
			item.width = 70;
			item.height = 85;
			item.useTime = 10;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.value = Item.sellPrice(2, 0, 0, 0);
			item.expert = true;
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Meowmere, 1);
			recipe.AddIngredient(mod.GetItem("SoulSword_T9"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 250);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.AncientManipulator);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	    public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// I assume you can make healingAmount any number or formula?
			int healingAmount = damage/5;
			player.statLife +=healingAmount;
			player.HealEffect(healingAmount, true);

		if(Main.rand.NextBool(2)){
			target.AddBuff(BuffID.Frostburn, 420);
		}
		    if(Main.rand.NextBool(2)){
			target.AddBuff(BuffID.OnFire, 600);
		}
		// This should apply Midas (enemies drop 10 -50% more coins when killed) for 5 minutes
		if(Main.rand.NextBool(1)){
			target.AddBuff(BuffID.Midas, 18000);
		}
	  }
	}
}
// Shoutout to absoluteAquarian#5189 on the TML Discord for fixing the debuff application not working
// Item.crit adds to the base 4%

// Add projectile