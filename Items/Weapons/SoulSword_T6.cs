using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UpgradableGear.Items.Weapons
{
	public class SoulSword_T6 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Sword");
			Tooltip.SetDefault("The sword demands blood...\nHeals equal to the damage dealt divided by 10\nApplies On Fire! 33% of the time\nCurrent Tier: VI\nThe answer to life, the universe, and everything");
		}

		public override void SetDefaults() 
		{
			item.damage = 42;
			item.knockBack = 6;
			item.crit = 4;
			item.melee = true;
			item.width = 47;
			item.height = 52;
			item.useTime = 21;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.value = Item.sellPrice(0, 1, 75, 0);
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulSword_T5"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 42);
			recipe.AddIngredient(ItemID.CobaltBar, 7);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulSword_T5"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 32);
			recipe.AddIngredient(ItemID.PalladiumBar, 7);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	    public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// I assume you can make healingAmount any number or formula?
			int healingAmount = damage/10;
			player.statLife +=healingAmount;
			player.HealEffect(healingAmount, true);
			
			if(Main.rand.NextBool(3)){
			target.AddBuff(BuffID.OnFire, 240);
		}
	  }
	}
}
// Shoutout to absoluteAquarian#5189 on the TML Discord for fixing the debuff application not working
// Item.crit adds to the base 4%