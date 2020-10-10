using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VRGaze : MonoBehaviour
{
    public Image imgGaze;
    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;
    public Text textHitam, textMerah; 

    public int  distanceOfRay = 10;
    private RaycastHit _hit;

    // void Awake(){
    //     textHitam = GameObject.Find("textHitam");
    //     textMerah = GameObject.Find("textMerah");
    // }
    // Start is called before the first frame update
    void Start()
    {
        // textHitam.SetActive(false);
        // textMerah.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(gvrStatus){
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

            if(Physics.Raycast(ray, out _hit, distanceOfRay)){
                if(_hit.transform.CompareTag("BlackCube")){
                    textHitam.text = "Ini Kubus Hitam";
                    // textHitam.SetActive(true);
                }

                if(_hit.transform.CompareTag("RedCube")){
                    // textMerah.SetActive(true);
                    textMerah.text = "Ini Kubus Merah";
                }

                if(_hit.transform.CompareTag("Cube")){
                    gvrTimer += Time.deltaTime;
                    imgGaze.fillAmount = gvrTimer / totalTime;
                }
            }


        }

    }

    

    public void GVRon(){
        gvrStatus = true;
    }

    public void GVRoff(){
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;

        textHitam.text = "";
        textMerah.text = "";
    }
}
