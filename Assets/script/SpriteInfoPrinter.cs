using UnityEngine;

public class SpriteInfoPrinter : MonoBehaviour
{
    void Start()
    {
        // Get the SpriteRenderer component
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer != null)
        {
            Sprite sprite = spriteRenderer.sprite;

            // Print some useful sprite info
            Debug.Log("Sprite Name: " + sprite.name);
            Debug.Log("Texture Size: " + sprite.texture.width + "x" + sprite.texture.height);
            Debug.Log("Rect: " + sprite.rect);
            Debug.Log("Pixels Per Unit: " + sprite.pixelsPerUnit);
        }
        else
        {
            Debug.Log("No SpriteRenderer found on this GameObject.");
        }
    }
}
