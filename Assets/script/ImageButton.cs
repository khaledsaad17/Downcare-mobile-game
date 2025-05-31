// ImageButton.cs
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageButton : MonoBehaviour
{
    public Image imageOnButton;
    
    public void OnClickChooseImage()
    
    {
        Debug.Log("khaled saad ");
        Debug.Log(ChangeScene.number_of_pieces);
        if (imageOnButton != null && SpriteHolder.Instance != null)
        {
            Debug.Log("ahmed saad ");
            Debug.Log("number of pieces you want to play is = "+ChangeScene.number_of_pieces);
            SpriteHolder.Instance.selectedSprite = imageOnButton.sprite;

            // غير اسم المشهد هنا بالمشهد اللي فيه SpriteRenderer
            // SceneManager.LoadScene("PuzzleScene");
            if (ChangeScene.number_of_pieces == 4 )
            {
                SceneManager.LoadSceneAsync(3);
            }else if (ChangeScene.number_of_pieces == 9)
            {
                SceneManager.LoadSceneAsync(4);
            }else
            {
                SceneManager.LoadSceneAsync(5);
            }
        }
    }
}
