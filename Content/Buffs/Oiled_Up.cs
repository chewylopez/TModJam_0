using Terraria;
using Terraria.ModLoader;

namespace TModJam_0.Content.Buffs
{
    internal class Oiled_Up : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true; // This buff can be applied by other players in Pvp, so we need this to be true.
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetDamage(DamageClass.Generic) *= 1.5f;
            player.maxRunSpeed *= 1.5f;
            player.statDefense *= 1.5f;

            player.electrified = true;
            player.onFire = true;
            player.burned = true;
        }

    }
}
