using System;
using UnityEngine;

public enum StatType
{
    Vitalidade,
    Vigor,
    Fagulhas,
    Simbologia
}

[Serializable]
public class StatChange
{
    [Header("Atributo")]
    [SerializeField] private StatType statType;

    [Header("Valor")]
    [SerializeField] private int amount;

    public StatType StatType => statType;
    public int Amount => amount;
}
