using UnityEngine;
using TMPro;

public class AppleManager : MonoBehaviour
{
    public static AppleManager instance;
    public int apples;
    [SerializeField] private TMP_Text applesDisplay;

    private void Awake()
    {
        if(!instance)
        {
            instance = this;
        }

    }

    private void OnGUI()
    {
        applesDisplay.text = apples.ToString();
    }

    public void ChangeApples(int amount)
    {
        apples += amount;
    }

}
