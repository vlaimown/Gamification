using UnityEngine;

[System.Serializable]
public class Dialogue
{
    [SerializeField] private string name;

    [TextArea(3, 10)]
    [SerializeField] private string[] sentences;

    public string GetName() => name;
    public string[] GetSentences() => sentences;
}
