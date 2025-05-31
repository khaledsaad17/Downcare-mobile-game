// SpriteHolder.cs
using UnityEngine;

public class SpriteHolder : MonoBehaviour
{
    public static SpriteHolder Instance;

    public Sprite selectedSprite;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // نحافظ عليه لما ننتقل بين الـ scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
