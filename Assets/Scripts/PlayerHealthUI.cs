using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Slider slider;

    void Start()
    {
        if (playerHealth == null) Debug.Log("Player Health is the one null");
        if (slider == null) Debug.Log("slider is null");
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = (float)playerHealth.currentHealth / playerHealth.maxHealth;
    }
}