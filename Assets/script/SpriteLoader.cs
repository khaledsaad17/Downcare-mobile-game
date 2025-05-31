// SpriteLoader.cs
using UnityEngine;

public class SpriteLoader : MonoBehaviour
{
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        if (sr != null && SpriteHolder.Instance != null)
        {
            Sprite selected = SpriteHolder.Instance.selectedSprite;

            if (selected != null)
            {
                // احسب scale مناسب عشان تطلع بنفس الحجم (زي ما شرحنا قبل)
                Sprite oldSprite = sr.sprite;
                Vector2 oldSize = oldSprite.bounds.size;
                Vector2 newSize = selected.bounds.size;

                Vector3 scale = transform.localScale;
                scale.x *= oldSize.x / newSize.x;
                scale.y *= oldSize.y / newSize.y;

                sr.sprite = selected;
                transform.localScale = scale;
            }
        }
    }
}
