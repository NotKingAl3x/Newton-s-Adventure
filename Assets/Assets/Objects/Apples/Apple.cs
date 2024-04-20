using UnityEngine;

public class Apple : MonoBehaviour
{
    [SerializeField] private int value;
    private bool hasTriggered;

    private AppleManager appleManager;

    private void Start()
    {
        appleManager = AppleManager.instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;
            appleManager.ChangeApples(value);
            Destroy(gameObject);
        }
    }

}
