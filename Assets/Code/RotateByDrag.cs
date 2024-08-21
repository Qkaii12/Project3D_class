using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateByDrag : MonoBehaviour
{
    public float anglePerInch;
    public Transform player;
    public Transform cameraHolder;
    public float minPitch;
    public float maxPitch;
    public bool hideCursor;
    public float sensitivity;

    private Vector2 startPos;
    private Vector2 delta;
    private float yaw;
    private float pitch;
    private float currentYaw;
    private float currentPtich;
    private float isDragging;
    private Quaternion desiredPlayerRotation;
    private Quaternion desiredCameraRotation;

    //public void OnPointerDown(PointerEventData eventData)
    //{
    //    startPos = eventData.position;
    //    isDragging = true;

    //}
    //public void OnDrag(PointerEventData eventData)
    //{
    //    delta = eventData.position - startPos;
    //    UpdateYaw();
    //    UpdatePitch();
    //}
    private void UpdateYaw()
    {
        float deltaYaw = delta.x * anglePerInch / Screen.dpi;
        currentYaw = yaw + deltaYaw;
        desiredPlayerRotation = Quaternion.Euler(0, currentYaw, 0);
    }
    private void UpdatePitch()
    {
        float deltaPitch = -delta.y * anglePerInch / Screen.dpi;
        currentPtich = Mathf.Clamp(pitch + deltaPitch, minPitch, maxPitch);
        desiredCameraRotation = Quaternion.Euler(currentPtich, 0, 0);
    }
    //public void OnPointerUp(PointerEventData eventData)
    //{
    //    pitch = currentPtich;
    //    yaw = currentYaw;
    //    isDragging = false;
    //}
    private void Update()
    {
        //if (isDragging)
        //{
        //    player.localRotation = Quaternion.Lerp(player.localRotation, desiredPlayerRotation, sensitivity * Time.deltaTime);
        //    cameraHolder.localRotation = Quaternion.Lerp(cameraHolder.localRotation, desiredCameraRotation, sensitivity * Time.deltaTime);
        //}
    }

}
