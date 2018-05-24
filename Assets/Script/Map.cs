using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public GameObject hexPrefab;
    Color col;

    int width = 8;
    int height = 9;

    float xOffSet = 0.890f;
    float yOffSet = 0.782f;

    // Use this for initialization
    void Start ()
    {

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                float xPos = x*xOffSet;
                if(y %2 == 1)
                {
                    xPos += xOffSet/2;
                }
               GameObject go  =(GameObject)Instantiate(hexPrefab, new Vector2(xPos, y* yOffSet), Quaternion.identity);
               
                
                switch (Random.Range(0, 5))
                {
                    case 0:
                        col = Color.magenta;
                        break;
                    case 1:
                        col = Color.red;
                        break;

                    case 2:
                        col = Color.blue;
                        break;

                    case 3:
                        col = Color.yellow;
                        break;

                    case 4:
                        col = new Color32(254, 120, 10, 255);
                        break;
                    default:
                        Debug.Log("Error! Cant paint a hex");
                        break;

                }
                go.GetComponentInChildren<SpriteRenderer>().color = col;

                go.name = "Hex_" + x + "_" + y;

                //hex coordinates setting
                go.GetComponent<Hex>().x = x;
                go.GetComponent<Hex>().y = y;
                
                go.transform.SetParent(this.transform);
                go.isStatic = true;
            }
        }
	}
	
	// Update is called once per frame
	void Update ()
    {

        

    }

}
