using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Weapons
{
	public class SoulSword_T1 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Sword I");
			Tooltip.SetDefault("Monster Essence concentrated into a blade.\nCan be infused with Souls and other materials to increase its power");
		}

		public override void SetDefaults() 
		{
			Item.damage = 11;
			Item.knockBack = 2;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 20;
			Item.scale = 0.67f;
			Item.useTime = 27;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.rare = 0;
			Item.autoReuse = false;
			Item.UseSound = SoundID.Item1;
			Item.value = Item.sellPrice(copper: 0);
		}

		public override void AddRecipes() 
		{
			CreateRecipe(1)
				.AddIngredient<MobSoul>(12)
				.AddTile(TileID.WorkBenches)
				.Register();
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