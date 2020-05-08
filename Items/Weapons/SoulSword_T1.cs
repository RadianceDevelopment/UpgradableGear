using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UpgradableGear.Items.Weapons
{
	public class SoulSword_T1 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Sword");
			Tooltip.SetDefault("Monster Essence concentrated into a blade.\nCan be infused with more Souls to increase its power, up to a maximum Tier of X (10).\nCurrent Tier: I");
		}

		public override void SetDefaults() 
		{
			item.damage = 10;
			item.knockBack = 2;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.value = Item.sellPrice(0, 0, 1, 0);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperShortsword, 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 5);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
/* Tiers (10 total, so far):

Try to make every higher-tier Sword inflict the debuffs of lower-tier ones

I - This (10 Damage, 5 Souls)

II - 15 Damage, 10 souls
III - 20 Damage, 12 souls. Cyan gem in hilt. Tooltip: The sword grows in power...
IV - 24 Damage, 15 souls + 1 Sapphire. Blue gem decals on hilt

Autoswing (all below here):
V - 27 Damage, 24 Souls + 7 Hellstone Bar. Red decals, inflicts On Fire! for 3 seconds (33% chance). Base Crit Chance of 6%
VI - 35 Damage, 32 Souls + 7 Cobalt/Palladium Ingot. Blue/orange decals, has lifesteal. Base crit chance of 8%
VII - 42 Damage, 42 Souls + 5 Hallowed Bars + 1 Frost Core. Gold-ish decals, inflicts Frostburn for 5 seconds (50% chance) Tooltip: The answer to life, the universe, and everything. +1 KB

Shoots a projectile (when implemented):
VIII - 60 Damage, 60 Souls + 5 Chlorophyte Bars + 1 of each mech soul (orange, blue, light green). Decals corresponding to the colour of the souls. Inflices Cursed Inferno for 4 seconds (33% chance). Tooltip: The Sword resonants with power....
IX - 75 Damage, 85 Souls + 10 Spectre bars. Ghostly decals, Inflicts Ichor (50) for 2 seconds
X - 225 Damage, Meowmere + 250 Souls + T9 Sword. Base crit of 10%. Inflicts  Midas (100% chance) for 1 minute. Tooltip: The Sword convulses for a moment, then reveals its true form. 12 Knockback. Worth 2 Platinum. 5 Use Time, 15 animation
*/