using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class StoryChoice
{
    [Header("Texto da Escolha")]
    [TextArea(2, 5)]
    [SerializeField] private string description;

    [Header("Consequências")]
    [SerializeField] private List<StatChange> statChanges = new List<StatChange>();

    [Header("Navegação")]
    [SerializeField] private StoryEventSO nextEvent;

    public string Description => description;
    public IReadOnlyList<StatChange> StatChanges => statChanges;
    public StoryEventSO NextEvent => nextEvent;
}
