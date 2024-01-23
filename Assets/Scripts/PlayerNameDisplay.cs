using UnityEngine;
using TMPro;

public class PlayerNameDisplay : MonoBehaviour
{
    public TMP_Text playerNameText; // 플레이어 이름을 표시

    public void SetPlayerName(string name)
    {
        playerNameText.text = name; // 플레이어 이름 설정
    }
}
