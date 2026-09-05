using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private float cooldown = 0.25f;
    private float cooldownTimer;

    //public GameObject bulletPrefab;
    //public Transform firePoint;
    //public float bulletForce;

    private void Update()
    {
        cooldownTimer += Time.deltaTime;
    }

    private void Shoot()
    {
        if (cooldownTimer < cooldown) return;

        Debug.Log("Shot!");
        cooldownTimer = 0;
       // GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation, null);
    }

    #region Input
    private void OnShoot()
    {
        Shoot();
    }
    #endregion
}