using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace SoulSang.Global
{
    public class RecipeGroups : ModSystem
    {
        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.LastPrism)}", ItemID.LastPrism, ItemID.LunarFlareBook);
            RecipeGroup.RegisterGroup(nameof(ItemID.LastPrism), "FinalMagic");
        }
    }
}