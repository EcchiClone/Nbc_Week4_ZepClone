using UnityEngine;
using TMPro;
using System;
public class DisplayTime : MonoBehaviour
{
    public TMP_Text timeText;
    void Update()
    {
        // HH:mm:ss 형식으로 시간 가져오기
        string time = DateTime.Now.ToString("HH:mm:ss");
        // 텍스트 컴포넌트에 현재 시간 표시
        timeText.text = time;
    }
}
