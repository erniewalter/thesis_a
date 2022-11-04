using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class getwandposition : MonoBehaviour

    
{
    private Vector3 TipPos, BasePos, distance;
    public TMP_Text posText;

    // Start is called before the first frame update
    void Start()
    {
        TipPos.Set(0, 0, 0);
        posText.text = TipPos.ToString("F4");
    }

    // Update is called once per frame
    void Update()
    {
        TipPos = GameObject.Find("WandSphere").transform.position;
        BasePos = GameObject.Find("BaseCube").transform.position;
        distance = BasePos - TipPos;
        posText.text = distance.ToString("F4");
    }
}
