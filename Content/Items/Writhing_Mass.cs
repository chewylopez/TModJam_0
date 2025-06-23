using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria;
using Terraria.GameContent;
using Microsoft.Xna.Framework;

namespace TModJam_0.Content.Items
{
    public class Writhing_Mass : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 26;
            Item.scale = 2f;
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.rare = ItemRarityID.Green;
        }

        public override bool? UseItem(Player player)
        {

            int npcType = ModContent.NPCType<Content.NPCs.Mad_Alchemist>();

            // Spawn the NPC
            int index = NPC.NewNPC(null, (int)player.Center.X, (int)player.Center.Y, npcType);

            if (index != 200) // 200 means invalid NPC slot
            {
                NPC npc = Main.npc[index];
                npc.homeless = true; // Without a house, the NPC can still spawn
                npc.homeTileX = (int)(player.Center.X / 16f);
                npc.homeTileY = (int)(player.Center.Y / 16f);
                npc.netUpdate = true;
                Main.NewText($"Spawned {npc.FullName} at your location.");
            }
            else
            {
                Main.NewText("Failed to spawn NPC.");
            }
            return true;
        }
    }
}
