using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip audioClip;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioSource.PlayClipAtPoint(audioClip, transform.position);
        }
    }
}
