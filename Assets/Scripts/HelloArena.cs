using UnityEngine;

public class HelloArena : MonoBehaviour
{
    [SerializeField] private string playerName = "Ziutek";
    [SerializeField] private int lives = 3;
    private float speed = 5.5f;
    private bool poz = true;
    void Start()
    {
        Debug.Log($"Witaj, {playerName}! Masz {lives} życia, twoja predkość to {speed}. Poziom: {poz} ");
    }

}
