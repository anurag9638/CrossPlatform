using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerScriptSystem
{
    public class FPSCameraController : MonoBehaviour
    {
        private readonly float mouseSensitivity = 10;
        private Transform playerBody;
        private float xRotation = 0f;
        public bool isCameraFreeze = false;

        void Awake()
        {
            playerBody = GameObject.FindGameObjectWithTag("Player").transform;
           // Cursor.lockState = CursorLockMode.Locked;
        }


        // Update is called once per frame
        void FixedUpdate()
        {
            CameraRotation();
        }

        private void CameraRotation()
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                float mouseX = Input.GetTouch(0).deltaPosition.x * mouseSensitivity * Time.deltaTime;
                float mouseY = Input.GetTouch(0).deltaPosition.y * mouseSensitivity * Time.deltaTime;

                if (!isCameraFreeze)
                {
                    playerBody.Rotate(Vector3.up * mouseX);
                    xRotation -= mouseY;
                    xRotation = Mathf.Clamp(xRotation, -90f, 90f);
                }
            }
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        }
    }
}
