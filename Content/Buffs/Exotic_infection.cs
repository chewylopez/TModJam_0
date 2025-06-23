using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace TModJam_0.Content.Buffs
{
    internal class Exotic_Infection : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true; 
        }

        public override void Update(Player player, ref int buffIndex)
        {
            Random rnd = new Random();
            double rand1 = 10 * rnd.NextDouble();
            double rand2 = 10 * rnd.NextDouble();
            double rand3 = 10 * rnd.NextDouble();
            double rand4 = 10 * rnd.NextDouble();
            double rand5 = 10 * rnd.NextDouble();
            

            if(rand1 > 8)
            {
                player.poisoned = true;
            }
            if (rand1 > 8)
            {
                player.statDefense += 3;
            }
            if (rand1 > 8)
            {
                player.statLifeMax2 += 20;
            }
            if (rand1 > 8)
            {
                player.onFire = true;
            }
            if (rand1 > 8)
            {
                player.runAcceleration += 3;
            }

        }

    }
}
