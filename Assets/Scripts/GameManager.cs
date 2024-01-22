using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public CharacterAppearance characterAppearance; // 캐릭터 외형 관리 컴포넌트
    public TMP_InputField nameInputField; // 이름 입력 필드
    public GameObject startScreenPanel; // 시작 화면 패널
    public TextMeshProUGUI warningMessage; // 경고 메시지를 표시할 텍스트
    public PlayerAppearance playerAppearance; // 플레이어 외형
    public PlayerNameDisplay playerNameDisplay; // 플레이어 이름 표시

    private void Start()
    {
        warningMessage.gameObject.SetActive(false); // 경고 메시지를 숨깁니다.
    }

    // Join 버튼 클릭 시 호출될 메서드
    public void OnJoinClicked()
    {
        string playerName = nameInputField.text;

        // 이름의 길이를 검사합니다.
        if (IsNameValid(playerName))
        {
            SavePlayerInfo(playerName);
            EnterGame();
        }
        else
        {
            // 유효하지 않은 경우 경고 메시지를 표시합니다.
            ShowWarning("The name must be between 2 and 10 characters.");
        }
    }

    // 이름의 유효성을 검사하는 메서드
    private bool IsNameValid(string name)
    {
        return !string.IsNullOrEmpty(name) && name.Length >= 2 && name.Length <= 10;
    }

    // 플레이어 정보를 저장하는 메서드
    private void SavePlayerInfo(string playerName)
    {
        int selectedAppearance = characterAppearance.GetSelectedAppearance();
        PlayerData playerData = new PlayerData(playerName, selectedAppearance);
        // 플레이어 데이터를 저장하는 로직을 여기에 구현합니다.
        // 예: 데이터베이스, 파일, 서버 등에 저장
    }

    // 게임에 진입하는 메서드
    private void EnterGame()
    {
        startScreenPanel.SetActive(false); // 시작 화면 패널을 비활성화합니다.

        // 플레이어 외형 설정
        Sprite selectedSprite = characterAppearance.GetSelectedSprite();
        playerAppearance.SetAppearance(selectedSprite); // PlayerAppearance 스크립트가 이 스프라이트를 사용하도록 설정

        string playerName = nameInputField.text; // 플레이어 이름을 얻어옵니다.
        playerNameDisplay.SetPlayerName(playerName); // 이름 설정
    }

    // 경고 메시지를 표시하는 메서드
    private void ShowWarning(string message)
    {
        warningMessage.text = message;
        warningMessage.gameObject.SetActive(true);
    }
}
