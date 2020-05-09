using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Weapons
{
	public class SoulSword_T9 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Sword");
			Tooltip.SetDefault("The sword hums with assurance, and drains you of your endurance\nHeals equal to the damage dealt divided by 7\nInflicts Frostburn 33% of the time\nInflicts On Fire! 50% of the time\nLaunches a ghostly projectile when swung (Still WIP!)\nCurrent Tier: IX\nThe sword seems to speak to you, saying 'The time is near...'");
	    }

		public override void SetDefaults() 
		{
			item.damage = 100;
			item.knockBack = 8;
			item.crit = 10;
			item.melee = true;
			item.width = 55;
			item.height = 65;
			item.useTime = 15;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.value = Item.sellPrice(0, 15, 0, 0);
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TerraBlade, 1);
			recipe.AddIngredient(mod.GetItem("SoulSword_T8"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 100);
			recipe.AddIngredient(ItemID.SpectreBar, 10);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TerraBlade, 1);
			recipe.AddIngredient(mod.GetItem("SoulSword_T8"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 100);
			recipe.AddIngredient(ItemID.ShroomiteBar, 10);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	    public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// I assume you can make healingAmount any number or formula?
			int healingAmount = damage/7;
			player.statLife +=healingAmount;
			player.HealEffect(healingAmount, true);
			
		if(Main.rand.NextBool(3)){
			target.AddBuff(BuffID.Frostburn, 360);
		}
		    if(Main.rand.NextBool(2)){
			target.AddBuff(BuffID.OnFire, 360);
		}
	  }
	}
}
// Shoutout to absoluteAquarian#5189 on the TML Discord for fixing the debuff application not working
// Item.crit adds to the base 4%

// Add projectile