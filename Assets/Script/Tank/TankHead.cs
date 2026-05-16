using UnityEngine;

namespace Script
{
    public class TankHead : MonoBehaviour
    {
        [SerializeField] private Transform head;
        [SerializeField] private float rotateSpeed = 100f;
        [SerializeField] private float minAngle = 45f;
        [SerializeField] private float maxAngle = 135f;

        private float currentRotation;


        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        void Update()
        {
            RotateHead();
        }

        void RotateHead()
        {
            Vector2 mouseDelta = InputManager.Instance.Controls.TankHead
                .Rotate
                .ReadValue<Vector2>();

            currentRotation -= mouseDelta.x * rotateSpeed * Time.deltaTime;

            currentRotation = Mathf.Clamp(currentRotation, minAngle, maxAngle);

            head.localRotation = Quaternion.Euler(0, 0, currentRotation);
        }
    }
}