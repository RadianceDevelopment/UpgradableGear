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
			Tooltip.SetDefault("The Sword convulses for a moment, then reveals its true form.\nAt last, you have fed it enough energy to weild its ultimate power.\nHeals equal to the damage dealt divided by 5\nInflicts Ichor 33% of the time\nInflicts Cursed Inferno 50% of the time\nInflicts Frostburn 100% of the time\nFoes drop extra money when killed\nCurrent Tier: X");
	    }

		public override void SetDefaults() 
		{
			item.damage = 225;
			item.knockBack = 12;
			item.crit = 16;
			item.melee = true;
			item.width = 70;
			item.height = 85;
			item.useTime = 5;
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
			recipe.AddIngredient(mod.GetItem("SoulSword_T9"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 250);
			recipe.AddIngredient(ItemID.Meowmere, 1);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	    public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// I assume you can make healingAmount any number or formula?
			int healingAmount = damage/5;
			player.statLife +=healingAmount;
			player.HealEffect(healingAmount, true);
			
			if(Main.rand.NextBool(3)){
			target.AddBuff(BuffID.Ichor, 180);
		}
		if(Main.rand.NextBool(2)){
			target.AddBuff(BuffID.CursedInferno, 300);
		}
		if(Main.rand.NextBool(1)){
			target.AddBuff(BuffID.Frostburn, 420);
		}
		if(Main.rand.NextBool(1)){
			target.AddBuff(BuffID.Midas, 3600);
		}
	  }
	}
}
// Shoutout to absoluteAquarian#5189 on the TML Discord for fixing the debuff application not working
// Item.crit adds to the base 4%

// Add projectile