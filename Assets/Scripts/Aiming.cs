using UnityEngine;
using UnityEngine.InputSystem;

public class Aiming : MonoBehaviour
{
    protected void LookAt(Vector3 target)
    {
        // Calculate angle between transform and target
        float lookAngle = AngleBetweenTwoPoints(transform.position, target);

        // Assign the target rotation on the Z axis
        transform.eulerAngles = new Vector3(0, 0, lookAngle);
    }

    private float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - -b.x) * Mathf.Rad2Deg;
    }

  //*  private Camera mainCam;
   // private Vector3 mousePos;

   // private void Start()
  //  {
  //      mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
  //  }

  //  private void Update()
  //  {
   //     mousePos = mainCam.ScreenToWorldPoint(Mouse.current.position.ReadValue());
   //     Vector3 rotation = mousePos - transform.position;
   //     float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
    //    transform.rotation = Quaternion.Euler(0, 0, rotZ);
   // }
}