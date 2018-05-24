using UnityEngine;

public class InputManager : MonoBehaviour
{
    
    void Start ()
    {
		
	}
	
	
	void Update ()
    {
        
        Ray ray= Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;

        if (Physics.Raycast(ray,out hitInfo))
        {
            GameObject selectedObject = hitInfo.collider.transform.gameObject;
           
           
            //click event

            if (Input.GetMouseButtonDown(0))
            {
               
                SpriteRenderer sr = selectedObject.GetComponentInChildren<SpriteRenderer>();

                    sr.material.color = Color.cyan; //will be outline
            }
        }

	}
}
