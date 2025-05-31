using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public Sprite newSprite; // الصورة الجديدة

    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        if (sr != null && newSprite != null)
        {
            Sprite oldSprite = sr.sprite;

            // احسب الحجم الفعلي القديم والجديد بناءً على bounds
            Vector2 oldSize = oldSprite.bounds.size;
            Vector2 newSize = newSprite.bounds.size;

            // احسب نسبة الفرق
            Vector3 scale = transform.localScale;
            scale.x *= oldSize.x / newSize.x;
            scale.y *= oldSize.y / newSize.y;

            // غير الصورة والسكيل
            sr.sprite = newSprite;
            transform.localScale = scale;
        }
    }
}
