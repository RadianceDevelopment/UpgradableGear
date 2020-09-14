using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Weapons
{
	public class SoulSword_T5 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Sword V");
			Tooltip.SetDefault("The sword crackles with flames...\nInflicts On Fire! 33% of the time\nCurrent Tier: V");
		}

		public override void SetDefaults() 
		{
			item.damage = 30;
			item.knockBack = 5;
			item.crit = 2;
			item.melee = true;
			item.width = 45;
			item.height = 50;
			item.useTime = 18;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.value = Item.sellPrice(0, 0, 65, 0);
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulSword_T4"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 30);
			recipe.AddIngredient(ItemID.HellstoneBar, 3);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	    public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// 60 frames = 1 second
			// Formula is 1 in X (x = 3 in this case) chance to be applied
			if(Main.rand.NextBool(3)){
			target.AddBuff(BuffID.OnFire, 120);
		}
	  }
	}
}
// Shoutout to absoluteAquarian#5189 on the TML Discord for fixing the debuff application not working
// Item.crit adds to the base 4%