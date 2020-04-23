using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pixel.Tiles
{
    public class YellowTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true; // is the tile solid
            Main.tileMergeDirt[Type] = true; // does the tile merges with dirt
            Main.tileLighted[Type] = true;
            Main.tileBlockLight[Type] = true; // does the tile emit light

            drop = mod.ItemType("Yellow"); // What item drops
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Yellow");
            AddMapEntry(new Color(255, 255, 0), name); // color of tile on map
            minPick = 40; // What power pick is needed to break the block
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 1.0f;
            g = 1.0f;
            b = 1.0f;
        }
    }
}

