using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class changeCamera : MonoBehaviour
{
    public CinemachineVirtualCamera campj1;
    public CinemachineVirtualCamera campj2;
    public CinemachineVirtualCamera camDual;
    private CinemachineBasicMultiChannelPerlin cbmcp;
    private float time = 1f;
    private bool againShake = true;

    void Start(){
        cbmcp = campj1.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            campj1.m_Priority = 100;
            campj2.m_Priority = 10;
            camDual.m_Priority = 10;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            campj1.m_Priority = 10;
            campj2.m_Priority = 100;
            camDual.m_Priority = 10;
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)){
            campj1.m_Priority = 10;
            campj2.m_Priority = 10;
            camDual.m_Priority = 100;
        }
        if(Input.GetMouseButtonDown(0)){
            if(againShake){
                cbmcp.m_AmplitudeGain = 5f;
                againShake = false;
                StartCoroutine(shakeCamera());
            }
        }
    }

     IEnumerator shakeCamera(){
        yield return new WaitForSeconds(time);
        cbmcp.m_AmplitudeGain = 0f;
        againShake = true;
    }
}
