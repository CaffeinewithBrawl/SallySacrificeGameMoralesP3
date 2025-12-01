using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotat;
    float yRotat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        // crosshair
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        xRotat += mouseY;
        xRotat = Mathf.Clamp(xRotat, -90f, 90f);

        yRotat -= mouseX;

        // rotate cam & orientation
        transform.rotation = Quaternion.Euler(xRotat, yRotat, 0);
        orientation.rotation = Quaternion.Euler(0, yRotat, 0);
    }
}
