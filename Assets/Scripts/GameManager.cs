using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public CharacterAppearance characterAppearance; // 캐릭터 외형 관리 컴포넌트(보수 필요)
    public TMP_InputField nameInputField; // 이름 입력 필드
    public GameObject startScreenPanel; // 시작 화면 패널
    public TextMeshProUGUI warningMessage; // 경고 메시지를 표시할 텍스트
    public GameObject player; // 조건 만족 시 오브젝트 활성화
    public PlayerAppearance playerAppearance; // 플레이어 외형
    public PlayerNameDisplay playerNameDisplay; // 플레이어 이름 표시

    private void Start()
    {
        warningMessage.gameObject.SetActive(false);
    }

    // Join 버튼 클릭 시 호출
    public void OnJoinClicked()
    {
        string playerName = nameInputField.text;

        // 이름의 길이를 검사
        if (IsNameValid(playerName))
        {
            SavePlayerInfo(playerName);
            EnterGame();
        }
        else
        {
            // 유효하지 않은 경우 경고 메시지를 표시
            ShowWarning("The name must be between 2 and 10 characters.");
        }
    }

    // 이름의 유효성을 검사
    private bool IsNameValid(string name)
    {
        return !string.IsNullOrEmpty(name) && name.Length >= 2 && name.Length <= 10;
    }

    // 플레이어 정보를 저장(보수 필요)
    private void SavePlayerInfo(string playerName)
    {
        int selectedAppearance = characterAppearance.GetSelectedAppearance();
        PlayerData playerData = new PlayerData(playerName, selectedAppearance);
    }

    // 게임에 진입
    private void EnterGame()
    {
        startScreenPanel.SetActive(false);

        player.SetActive(true);

        string playerName = nameInputField.text; // 플레이어 이름 가져오기
        playerNameDisplay.SetPlayerName(playerName); // 이름 설정
    }

    // 경고 메시지를 표시
    private void ShowWarning(string message)
    {
        warningMessage.text = message;
        warningMessage.gameObject.SetActive(true);
    }
}
