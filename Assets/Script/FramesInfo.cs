using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace Script
{
    public static class FramesInfo
    {
        public static Dictionary<int, FrameDetail> frames = new Dictionary<int, FrameDetail>();
        
        public static void SetFrameDetail(int currentTime, FrameDetail frameDetail, int totalFrames)
        {
            if (frames.Count >= totalFrames)
            {
                KeyValuePair<int, FrameDetail> firstKvp = frames.First();
                frames.Remove(firstKvp.Key);
                var shiftedDict = frames.ToDictionary(
                    kvp => kvp.Key - 1,
                    kvp => kvp.Value
                );
            
                frames = shiftedDict;
            }
            
            frames.Add(frames.Count ,frameDetail);
        }

        public static FrameDetail GetFrameDetail(int frameTime)
        {
            Debug.Log($"player time {frameTime} was at{frames[frameTime].position}");
            FrameDetail outputFrameDetail;
            outputFrameDetail = frames.TryGetValue(frameTime, out outputFrameDetail)
                ? outputFrameDetail
                : new FrameDetail();
            return outputFrameDetail;
        }

    }

    public struct FrameDetail
    {
        public FrameDetail(Vector3 position, float HP, int ammo)
        {
            this.position = position;
            this.HP = HP;
            this.ammo = ammo;
        }

        public Vector3 position { get; }
        public float HP { get; }
        public int ammo { get; }

    }
}