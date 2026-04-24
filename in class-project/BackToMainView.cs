using UnityEngine;
using TMPro;

public class BackToMainView : MonoBehaviour
{
    public CameraFollowTarget cameraFollow;
    public TMP_Text factText;

    public Vector3 mainViewPosition = new Vector3(0, 6, -12);

    public void GoBack()
    {
        cameraFollow.StopFollowing(mainViewPosition);

        if (factText != null)
        {
            factText.text = "Click Earth or the Moon to learn!";
        }
    }
}