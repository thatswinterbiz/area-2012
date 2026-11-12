using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthUI : MonoBehaviour
{
    public EnemyHealth enemyHealth;
    public Slider slider;

    // Update is called once per frame
    void Update()
    {
        slider.value = enemyHealth.enemyCurrentHealth;
    }
}