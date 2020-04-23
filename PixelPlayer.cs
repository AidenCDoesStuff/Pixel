using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pixel
{
    public class PixelPlayer : ModPlayer
    {
        public bool PixelPet;
        public bool LightPixelPet;

        public override void ResetEffects()
        {
            PixelPet = false;
        }
    }
}
