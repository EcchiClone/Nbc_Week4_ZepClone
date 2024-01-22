using UnityEngine;
using UnityEngine.UI;

public class CharacterAppearance : MonoBehaviour
{
    public Image characterImage; // 시작 화면의 캐릭터 이미지
    public GameObject characterSelectionPanel; // 캐릭터 외형 선택 패널
    public Sprite[] characterSprites; // 사용 가능한 캐릭터 외형 이미지 배열

    private int selectedAppearance = 0; // 선택된 외형의 인덱스

    private void Start()
    {
        // 기본 외형 설정 
        characterImage.sprite = characterSprites[selectedAppearance];
    }

    // 캐릭터 외형 선택 패널을 열기
    public void OpenCharacterSelectionPanel()
    {
        characterSelectionPanel.SetActive(true);
    }

    // 캐릭터 외형 선택
    public void SelectAppearance(int appearanceIndex)
    {
        selectedAppearance = appearanceIndex;
        characterImage.sprite = characterSprites[selectedAppearance];
        characterSelectionPanel.SetActive(false);
    }

    // 현재 선택된 외형의 인덱스를 가져옴
    public int GetSelectedAppearance()
    {
        return selectedAppearance;
    }

    // 또는 현재 선택된 스프라이트를 반환
    public Sprite GetSelectedSprite()
    {
        return characterSprites[selectedAppearance];
    }
}
