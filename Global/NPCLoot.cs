using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace SoulSang.Global
{
	public class MyGlobalNPC : GlobalNPC
	{
		public override void ModifyGlobalLoot(GlobalLoot globalLoot) {
			// This is where we add global rules for all NPC. Here is a simple example:
			globalLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.StraySoul>(), 1));
		}
	}
}