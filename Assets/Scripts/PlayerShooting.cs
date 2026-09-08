using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private float cooldown = 0.25f;
    private float cooldownTimer;

    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce;
    InputAction shootAction;

    private void Start()
    {
        
    }

    private void Update()
    {
        //cooldownTimer += Time.deltaTime;

        if(shootAction.IsPressed())
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation, null);
        }
    }

   // public void Shoot(InputAction.CallbackContext context)
    //{
       // if (cooldownTimer < cooldown) return;

       // Debug.Log("Shot!");
       // cooldownTimer = 0;
       // GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation, null);
   // }
}