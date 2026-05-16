using System;
using System.Collections.Generic;
using UnityEngine;


namespace Script
{
    public class RewindSystem : MonoBehaviour
    {
        private float lastUpdatedTime;
        private float elapsedTime;

        [SerializeField] private int rewindFrame;

        void Start()
        {
            lastUpdatedTime = 0f;
        }

        void LateUpdate()
        {
            elapsedTime += Time.deltaTime;
            if (InputManager.Instance.Controls.FindAction("Rewind").IsPressed())
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