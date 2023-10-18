using UnityEngine;

public class MiniGameLoader : MonoBehaviour
{
    GameController gameController;
    [SerializeField] string miniGameName;

    private void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();

        if (gameController == null)
            Debug.Log($"Не назначен gameController на объект {gameController.name}");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameController.LoadMiniGame(miniGameName);
    }
}
