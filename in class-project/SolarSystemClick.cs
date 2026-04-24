using UnityEngine;
using TMPro;

public class SolarSystemClick : MonoBehaviour
{
    public CameraFollowTarget cameraFollow;
    public TMP_Text factText;

    [TextArea]
    public string fact;

    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void OnMouseDown()
    {
        if (cameraFollow != null)
        {
            cameraFollow.Follow(transform);
        }

        if (factText != null)
        {
            factText.text = fact;
        }

        transform.localScale = originalScale * 1.3f;
        Invoke("ResetScale", 0.5f);
    }

    void ResetScale()
    {
        transform.localScale = originalScale;
    }
}