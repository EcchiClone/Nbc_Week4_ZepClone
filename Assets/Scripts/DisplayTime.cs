using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour
{
    public GameObject textObject; // Text 컴포넌트가 있는 GameObject

    private TMP_Text timeTextTMP;
    private Text timeTextLegacy;

    private void Awake()
    {
        timeTextTMP = textObject.GetComponent<TMP_Text>();
        timeTextLegacy = textObject.GetComponent<Text>();
    }

    void Update()
    {
        // HH:mm:ss 형식으로 시간 가져오기
        string time = DateTime.Now.ToString("HH:mm:ss");

        if (timeTextTMP != null)
        {
            timeTextTMP.text = time;
        }

        else if (timeTextLegacy != null)
        {
            timeTextLegacy.text = time;
        }
    }
}
