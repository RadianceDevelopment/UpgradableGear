using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items
{
	public class MobSoul : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Monster Soul");
			Tooltip.SetDefault("The concentrated form of a monsters' very will and fabric of their being\nCan be used to create various powerful relics.\nBut be warned, this strays into Necromantic territory.");
		}

		public override void SetDefaults() 
		{
			Item.width = 20;
			Item.height = 20;
			Item.maxStack = 9999;
            Item.rare = ItemRarityID.White;
			Item.value = Item.sellPrice(copper: 0);
		}

		public override void AddRecipes() 
		{
			CreateRecipe(1)
				.AddIngredient(ItemID.Gel, 3)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			CreateRecipe(2)
				.AddIngredient(ItemID.Lens, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			CreateRecipe(15)
				.AddIngredient(ItemID.BlackLens, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			CreateRecipe(5)
				.AddIngredient(ItemID.Feather, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			CreateRecipe(7)
				.AddIngredient(ItemID.AntlionMandible, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			CreateRecipe(3)
				.AddIngredient(ItemID.WormTooth, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			CreateRecipe(4)
				.AddIngredient(ItemID.RottenChunk, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			CreateRecipe(4)
				.AddIngredient(ItemID.Vertebrae, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			CreateRecipe(5)
				.AddIngredient(ItemID.Bone, 3)
				.AddTile(TileID.BoneWelder)
				.Register();
			
			CreateRecipe(6)
				.AddIngredient(ItemID.Stinger, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			CreateRecipe(7)
				.AddIngredient(ItemID.ShadowScale, 1)
				.AddTile(TileID.Anvils)
				.Register();
			
			CreateRecipe(7)
				.AddIngredient(ItemID.TissueSample, 1)
				.AddTile(TileID.Anvils)
				.Register();
			
			CreateRecipe(8)
				.AddIngredient(ItemID.PinkGel, 2)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			CreateRecipe(12)
				.AddIngredient(ItemID.TatteredCloth, 1) // Not quite sure how souls are in the cloth, but oh well. Maybe it got caught there after the guy died and became a zombie?
				.AddTile(TileID.WorkBenches)
				.Register();
			
			CreateRecipe(20)
				.AddIngredient(ItemID.Ectoplasm, 1)
				.AddTile(TileID.MythrilAnvil)
				.Register();
			
			CreateRecipe(25)
				.AddIngredient(ItemID.DarkShard, 1)
				.AddTile(TileID.MythrilAnvil)
				.Register();
			
			CreateRecipe(25)
				.AddIngredient(ItemID.LightShard, 1)
				.AddTile(TileID.MythrilAnvil)
				.Register();
			
			CreateRecipe(10)
				.AddIngredient(ItemID.BeetleHusk, 1)
				.AddTile(303) // Lihzahrd Furnace
				.Register();
				
			CreateRecipe(50)
				.AddIngredient(ItemID.ZombieArm, 1)
				.AddTile(TileID.Anvils)
				.Register();
			
			CreateRecipe(75)
				.AddIngredient(ItemID.LizardEgg, 1)
				.AddTile(303) // Lihzahrd Furnace
				.Register();
		}
	}
}