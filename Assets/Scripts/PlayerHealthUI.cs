using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Scrollbar scrollbar;

    // Update is called once per frame
    void Update()
    {
        scrollbar.value = playerHealth.currentHealth;
    }
}
