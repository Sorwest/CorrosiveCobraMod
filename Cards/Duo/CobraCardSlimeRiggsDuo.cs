﻿namespace Sorwest.CorrosiveCobra.Cards;

[CardMeta(dontOffer = true)]
public class CobraCardSlimeRiggsDuo : Card
{
    public override CardData GetData(State state)
    {
        CardData result = new CardData
        {
            cost = 0,
            exhaust = true,
        };
        return result;
    }
    public override List<CardAction> GetActions(State s, Combat c)
    {
        List<CardAction> result = new List<CardAction>
        {
            new AAttack()
            {
                damage = GetDmg(s, 1),
                fast = true,
            },
            new ADrawCard()
            {
                count = 2,
            },
        };
        return result;
    }
}