using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateByMouse : MonoBehaviour
{
    public float anglePerSecond;
    public Transform cameraHolder;
    public float minPitch;
    public float maxPitch;
    private float pitch;
    public bool hideCursor;
#if UNITY_EDITOR || UNITY_STANDALONE
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Update()
    {
        UpdateYaw();
        UpdatePitch();
    }
    private void UpdateYaw()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float deltaYaw = mouseX * anglePerSecond * Time.deltaTime;
        transform.Rotate(0, deltaYaw, 0);
    }
    private void UpdatePitch()
    {
        float mouseY = Input.GetAxis("Mouse Y");
        float deltaPitch = -mouseY * anglePerSecond * Time.deltaTime;
        pitch = Mathf.Clamp(pitch + deltaPitch, minPitch, maxPitch);
        cameraHolder.localEulerAngles = new Vector3(pitch, 0, 0);
    }

#endif
}

