using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Drag_and_dop : MonoBehaviour
{
    public ParticleSystem effects;
    public ParticleSystem effects1;
    public ParticleSystem effects2;
    public ParticleSystem effects3;
    public static int TotalNumberOfPieces;
    public static int InatialNumberOfPieces = 0;
    public GameObject SelectedPiece;
    public GameObject finishPanel;
    int IndexLeyer;
    void Start()
    {
        effects.Pause();
        effects1.Pause();
        effects2.Pause();
        effects3.Pause();
        TotalNumberOfPieces = ChangeScene.number_of_pieces;
        
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Debug.Log("the touch happened !!!!!!!!");
            Touch touch = Input.GetTouch(0);
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, Camera.main.nearClipPlane));
            touchPos.z = 0;


            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit2D hit = Physics2D.Raycast(touchPos, Vector2.zero);
                if (hit.collider != null && hit.transform.CompareTag("puzzle"))
                {
                    if (!hit.transform.GetComponent<PiecesScript>().InRightPosition)
                    {
                        SelectedPiece = hit.transform.gameObject;
                        SelectedPiece.GetComponent<PiecesScript>().InRightPosition = true;
                        SelectedPiece.GetComponent<SortingGroup>().sortingOrder = IndexLeyer;
                        IndexLeyer++;
                        
                    }
                }
            }

            if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                if (SelectedPiece != null)
                {
                    SelectedPiece.transform.position = touchPos;
                }
            }

            if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
            {
                if (SelectedPiece != null)
                {
                    SelectedPiece.GetComponent<PiecesScript>().InRightPosition = false;
                    SelectedPiece = null;
                }
            }
        }

        if (InatialNumberOfPieces == TotalNumberOfPieces)
        {
            Debug.Log("it is dooooooooooooone ");
            effects.Play();
            effects1.Play();
            effects2.Play();
            effects3.Play();
            InatialNumberOfPieces = 0;
            finishPanel.SetActive(true);
        }
    }

    public static void IncreasePieces()
    {
        InatialNumberOfPieces++;
        Debug.Log($"Initial Value: {InatialNumberOfPieces}");
    }
}





