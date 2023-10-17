using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> queueSentences;

    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI dialogueText;

    [SerializeField] private Canvas canvasDialogue;

    private void Start()
    {
        if (canvasDialogue == null)
            Debug.Log($"Не назначен canvasDialogue на {gameObject.name}");

        queueSentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        canvasDialogue.gameObject.SetActive(true);

        nameText.text = dialogue.GetName();

        queueSentences.Clear();

        string[] sentences = dialogue.GetSentences();

        foreach (string sentence in sentences)
            queueSentences.Enqueue(sentence);

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (queueSentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = queueSentences.Dequeue();

        dialogueText.text = sentence;

    }

    private void EndDialogue()
    {
        canvasDialogue.gameObject.SetActive(false);
    }
}
