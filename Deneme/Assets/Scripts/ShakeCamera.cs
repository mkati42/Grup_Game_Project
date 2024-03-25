using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ShakeCamera : MonoBehaviour
{
    private CinemachineVirtualCamera cam;
    private CinemachineBasicMultiChannelPerlin noise;
    // Start is called before the first frame update
    void Awake()
    {
        cam = GetComponent<CinemachineVirtualCamera>();
        noise = cam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
    }

    public void StartShakeCoroutine(float duration, float amplitude)
    {
        StartCoroutine(ShakeCoroutine(duration, amplitude));
    }

    public IEnumerator ShakeCoroutine(float duration, float amplitude)
    {
        // Titreşim efekti süresince
        noise.m_AmplitudeGain = amplitude;
        yield return new WaitForSeconds(duration);
        // Titreşim efekti sona erince
        noise.m_AmplitudeGain = 0f;
    }
}
