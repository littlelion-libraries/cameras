using UnityEngine;
using Vector3 = System.Numerics.Vector3;

namespace Cameras
{
    public class UnityCamera : ICamera
    {
        private Camera _impl;

        public Camera Impl
        {
            set => _impl = value;
        }

        public Vector3 WorldToScreenPoint(Vector3 position)
        {
            return UnityUtils.Convert(_impl.WorldToScreenPoint(UnityUtils.Convert(position)));
        }
    }
}