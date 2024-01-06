using FrogGun.Content.Items.Weapons;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace Content.Changes
{
    internal class NPCLoot : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, Terraria.ModLoader.NPCLoot npcLoot)
        {
            if(npc.type == NPCID.DukeFishron) {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FrogLauncher>(), 4, 1, 1));
            }
            if (npc.type == NPCID.Frog)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FrogLauncher>(), 512, 1, 1));
            }
            if (npc.type == NPCID.GoldFrog)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FrogLauncher>(), 1, 1, 1));
            }
        }
    }
}