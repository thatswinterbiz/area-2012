using UnityEngine;
using UnityEngine.InputSystem;

namespace AimingScripts
{
    public class PlayerRotation : Rotator
    {
        // Determine mouse position and look that way
        private void OnLook(InputValue value)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(value.Get<Vector2>());
            LookAt(mousePosition);
        }
    }
}