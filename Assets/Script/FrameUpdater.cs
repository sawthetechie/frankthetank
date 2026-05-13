using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace Script
{
    public class FrameUpdater : MonoBehaviour
    {
        private float lastUpdatedTime;
        private float elapsedTime;
        
        public Dictionary<int, FrameDetail> frames;

        [SerializeField] private int totalAvailableFrames;
        void Start()
        {
            lastUpdatedTime = 0f;
        }
        void Update()
        {
            frames = FramesInfo.frames;
            elapsedTime += Time.deltaTime;
            if (Mathf.Floor(elapsedTime - lastUpdatedTime) == 1f)
            {
                FramesInfo.SetFrameDetail(Mathf.FloorToInt(elapsedTime % 4), new FrameDetail(transform.position, 100, 1), totalAvailableFrames);
                lastUpdatedTime = elapsedTime;
            }
        }
    }
}