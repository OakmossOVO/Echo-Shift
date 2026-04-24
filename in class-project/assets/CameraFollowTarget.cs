using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 1.5f, -3f);
    public bool isFollowing = false;

    void LateUpdate()
    {
        if (isFollowing && target != null)
        {
            transform.position = target.position + offset;
            transform.LookAt(target.position);
        }
    }

    public void Follow(Transform newTarget)
    {
        target = newTarget;
        isFollowing = true;
    }

    public void StopFollowing(Vector3 mainPosition)
    {
        isFollowing = false;
        target = null;

        transform.position = mainPosition;
        transform.LookAt(Vector3.zero);
    }
}