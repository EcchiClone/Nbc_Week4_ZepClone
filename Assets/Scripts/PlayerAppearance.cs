using UnityEngine;

public class PlayerAppearance : MonoBehaviour
{
    public SpriteRenderer mainSpriteRenderer;
    public Animator animator;

    // 플레이어 외형을 설정
    public void SetAppearance(Sprite newAppearance)
    {
        mainSpriteRenderer.sprite = newAppearance;
    }
    // 플레이어 애니메이션 설정
    public void SetAnimation(int CharacterNum)
    {
        animator.SetInteger("CharacterNum", CharacterNum);
    }
}
