using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ecos de Eire/Story Event", fileName = "NewStoryEvent")]
public class StoryEventSO : ScriptableObject
{
    [Header("Identificação")]
    [SerializeField] private string eventId;
    [SerializeField] private string title;

    [Header("Narrativa")]
    [TextArea(4, 10)]
    [SerializeField] private string description;

    [SerializeField] private Sprite illustration;

    [Header("Opções")]
    [SerializeField] private List<StoryChoice> choices = new List<StoryChoice>();

    public string EventId => eventId;
    public string Title => title;
    public string Description => description;
    public Sprite Illustration => illustration;
    public IReadOnlyList<StoryChoice> Choices => choices;
}