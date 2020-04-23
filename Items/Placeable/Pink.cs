using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pixel.Items.Placeable
{
    public class Pink : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pink"); //Name
            Tooltip.SetDefault(""); //Tooltip
        }
        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.value = 100;
            item.maxStack = 999; 
            item.useTime = 3; // Speed before reuse
            item.useAnimation = 15; //Animation speed
            item.useStyle = 1; //Broadsword
            item.autoReuse = true; // autoreuse
            item.consumable = true; //Uses item when used
            item.createTile = mod.TileType("PinkTile");
        }
    }
}

