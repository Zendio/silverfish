﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_FP1_004 : SimTemplate//Mad Scientist
    {
        //<deDE>&lt;b&gt;TodesrÃ¶cheln:&lt;/b&gt; Legt ein &lt;b&gt;Geheimnis&lt;/b&gt; aus Eurem Deck auf das Schlachtfeld.</deDE>

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                if (p.ownHeroName == HeroEnum.mage)
                {
                    p.ownSecretsIDList.Add(CardDB.cardIDEnum.EX1_289);
                }
                if (p.ownHeroName == HeroEnum.hunter)
                {
                    p.ownSecretsIDList.Add(CardDB.cardIDEnum.EX1_554);
                }
                if (p.ownHeroName == HeroEnum.pala)
                {
                    p.ownSecretsIDList.Add(CardDB.cardIDEnum.EX1_130);
                }
            }
            else
            {
                if (p.enemyHeroName == HeroEnum.mage || p.enemyHeroName == HeroEnum.hunter || p.enemyHeroName == HeroEnum.pala)
                {
                    p.enemySecretCount++;
                }
            }
            
        }
    }
}
