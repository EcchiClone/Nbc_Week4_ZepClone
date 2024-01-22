using UnityEngine;

public class PlayerAppearance : MonoBehaviour
{
    public SpriteRenderer mainSpriteRenderer; // MainSprite 오브젝트의 SpriteRenderer

    // 플레이어 외형을 설정하는 메서드
    public void SetAppearance(Sprite newAppearance)
    {
        mainSpriteRenderer.sprite = newAppearance;
    }
}
