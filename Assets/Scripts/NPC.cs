using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] private DialogueTrigger dialogueTrigger;
    private bool readyTalk = false;

    [SerializeField] private Canvas canvasDialogue;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        readyTalk = true;
        canvasDialogue.gameObject.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        readyTalk = false;
        canvasDialogue.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (readyTalk && canvasDialogue.gameObject.active)
            if (Input.GetKeyDown(KeyCode.Space))
            {
                canvasDialogue.gameObject.SetActive(false);
                dialogueTrigger.TriggerDialogue();
            }
    }
}
