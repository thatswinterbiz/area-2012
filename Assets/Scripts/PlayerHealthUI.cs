using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Slider slider;

    // Update is called once per frame
    void Update()
    {
        slider.value = playerHealth.currentHealth;
    }
}
