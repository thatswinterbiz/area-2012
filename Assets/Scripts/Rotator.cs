using UnityEngine;

namespace AimingScripts
{
    public class Rotator : MonoBehaviour
    {
        public void LookAt(Vector3 target)
        {
            // Calculate angle between transform and target
            float lookAngle = AngleBetweenTwoPoints(transform.position, target) + 90;

            // Assign the target rotation on the Z axis
            transform.eulerAngles = new Vector3(0, 0, lookAngle);
        }

        private float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
        {
            return Mathf.Atan2(a.y - b.y, a.x - -b.x) * Mathf.Rad2Deg;
        }
    }
}