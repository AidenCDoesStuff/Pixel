using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pixel.Projectiles.Pets
{
	public class PixelPetProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("PixelPetProjectile");
			Main.projFrames[projectile.type] = 1;
			Main.projPet[projectile.type] = true;
            ProjectileID.Sets.LightPet[projectile.type] = true;
        }

		public override void SetDefaults()
		{
            projectile.CloneDefaults(ProjectileID.CompanionCube);
            aiType = ProjectileID.CompanionCube;
            projectile.width = 26;
            projectile.height = 26;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.companionCube = false;
            return true;
        }

        const int fadeInTicks = 30;
		const int fullBrightTicks = 200;
		const int fadeOutTicks = 30;
		const int range = 500;
		int rangeHypoteneus = (int)Math.Sqrt(range * range + range * range);
        
		public override void AI()
		{
			Player player = Main.player[projectile.owner];
            PixelPlayer modPlayer = player.GetModPlayer<PixelPlayer>();
            if (player.dead)
			{
				modPlayer.PixelPet = false;
			}
			if (modPlayer.PixelPet)
			{
				projectile.timeLeft = 2;
			}
            if (!player.active)
			projectile.ai[1]++;
			if (projectile.ai[1] > 1000 && ((int)projectile.ai[0] % 100 == 0))
			{
				for (int i = 0; i < Main.npc.Length; i++)
				{
					if (Main.npc[i].active && !Main.npc[i].friendly && player.Distance(Main.npc[i].Center) < rangeHypoteneus)
					{
						Vector2 vectorToEnemy = Main.npc[i].Center - projectile.Center;
						projectile.velocity += 10f * Vector2.Normalize(vectorToEnemy);
						projectile.ai[1] = 0f;
						Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/PixelPetSound"));
						break;
					}
				}
			}
            Lighting.AddLight(projectile.Center, ((255 - projectile.alpha) * 1.0f) / 255f, ((255 - projectile.alpha) * 1.0f) / 255f, ((255 - projectile.alpha) * 1.0f) / 255f);
        }
	}
}