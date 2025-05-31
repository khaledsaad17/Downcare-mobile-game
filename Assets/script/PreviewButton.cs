using UnityEngine;
using UnityEngine.UI;

public class PreviewButton : MonoBehaviour
{
    public GameObject imageObject; // الـ Image اللي هتظهر وتختفي
    public Image imageComponent;   // مكون Image لعرض الـ sprite

    private bool isVisible = false;

    void Start()
    {
        if (imageObject != null)
        {
            imageObject.SetActive(false); // نبدأ وهي مخفية
        }

        // لو فيه صورة متخزنة
        if (SpriteHolder.Instance != null && SpriteHolder.Instance.selectedSprite != null && imageComponent != null)
        {
            imageComponent.sprite = SpriteHolder.Instance.selectedSprite;
            imageComponent.preserveAspect = true;
        }
    }

    public void ToggleImage()
    {
        isVisible = !isVisible;

        if (imageObject != null)
        {
            imageObject.SetActive(isVisible);
        }
    }
}
