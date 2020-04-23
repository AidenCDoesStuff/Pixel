using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pixel.Items.Placeable
{
    public class CyanWall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cyan Wall"); //Name
            Tooltip.SetDefault(""); //Tooltip
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.value = 25;
            item.maxStack = 999;
            item.useTime = 3;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.consumable = true;
            item.createWall = mod.WallType("CyanWallTile");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cyan");
            recipe.SetResult(this, 4);
            recipe.AddRecipe();
        }
    }
}

