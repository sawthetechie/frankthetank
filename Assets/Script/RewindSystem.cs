using System.Collections.Generic;
using UnityEngine;


namespace Script
{
    public class RewindSystem : MonoBehaviour
    {
        private float lastUpdatedTime;
        private float elapsedTime;

        [SerializeField] private int rewindFrame;
        PlayerInput PlayerInput;

        void Start()
        {
            lastUpdatedTime = 0f;
            PlayerInput = new PlayerInput();
            PlayerInput.Enable();
        }

        void LateUpdate()
        {
            elapsedTime += Time.deltaTime;
            if (PlayerInput.Player.Rewind.IsPressed())
            {
                FrameDetail targetFrame = FramesInfo.GetFrameDetail(Mathf.FloorToInt(elapsedTime % rewindFrame));
                transform.position = targetFrame.position;

            }
        }

        void Rewind()
        {
            
        }

    }
}