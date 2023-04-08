using System.Numerics;

namespace Cameras
{
    public interface ICamera
    {
        Vector3 WorldToScreenPoint(Vector3 position);
    }
}