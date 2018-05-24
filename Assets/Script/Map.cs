using UnityEngine;

public class Map : MonoBehaviour {

    public GameObject hexPrefab;
    

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
