using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class FadeIn : MonoBehaviour

{
    public GameObject CenterEyeObj;
    OVRScreenFade OFade;
    void Start()
    {
        OFade = CenterEyeObj.transform.GetComponent<OVRScreenFade>();
        //OVRScreenFade 스크립트도 컴포넌트로 가져온다
    }

    void Update()
    {
            
    }
    public void FadeOut()
    {
        OFade.FadeOut();
    }

}
