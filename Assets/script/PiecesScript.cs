using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
public class PiecesScript : MonoBehaviour
{
    private Vector3 RightPosition ;
    public bool InRightPosition ;
    public bool Selected;
    // Start is called before the first frame update
    void Start()
    {
        // here stroe the right position in a variable called RightPosition and then spread out it in the random places
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(-1f,2f), Random.Range(-1.5f,-2f));
    }

    // Update is called once per frame
    void Update()
    {
        // here check for that the piece selected in the right position with the real position and the now position
        if (Vector3.Distance(transform.position, RightPosition) <  0.5f)
        {
            // this when the player select a piece the variable selected is set to true and when drop it is set to false 
            // and he chck when the player drop the piece
            if (!Selected)
            {
                // after the distance is smaller than the 0.5f then we check of that if it`s variable that is set to true or not 
                if ( InRightPosition == false )
                {
                    transform.position = RightPosition;
                    InRightPosition = true;
                    // here we make the piece order to 0 to make other selected pieces visible above it
                    GetComponent<SortingGroup>().sortingOrder = 0 ;

                    Drag_and_dop.IncreasePieces();
                }
               
            }
            
        }
    }
}
