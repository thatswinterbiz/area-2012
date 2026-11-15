using UnityEngine;

namespace AimingScripts
{
    public class Rotator : MonoBehaviour
    {
        public void LookAt(Vector3 target)
        {
            // Calculate angle from transform to target
            Vector3 lookAngle = (target - transform.position);

            // Assign the target rotation on the Z axis
            transform.right = lookAngle;
        }

        private float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
        {
            return Mathf.Atan2(a.y - b.y, a.x - -b.x) * Mathf.Rad2Deg;
        }
    }
}