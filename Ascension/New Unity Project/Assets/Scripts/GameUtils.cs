using UnityEngine;
using System.Collections;

public static class GameUtils
{
    public enum CardType { Minion, Spell, Field, Incarnation };
    public enum Classes { Bellum, Draknyd, Sygmuth, Kraïm, Maskorme, Ganymede, Xeos, Zyglon, Pendulus, Vertera,
                          Kameoz, Flibius, Neutral };
    public enum Rarity { Common, Atypical, Rare, Legendary, Mythic };
    public enum Tribe { Fire, Water, Wind, Ground, Demon, Light, Beast, Human };
    public enum State { Alive, Dead };

    public const int MAX_CARDS_IN_HAND = 10;

    public static bool IsBetweenInclusive(int value, int botValue, int topValue)
    {
        return value >= botValue && value <= topValue;
    }

    public static bool IsBetweenExclusive(int value, int botValue, int topValue)
    {
        return value > botValue && value < topValue;
    }

    public static bool IsZeroOrNegative(int value)
    {
        return value <= 0;
    }
}
