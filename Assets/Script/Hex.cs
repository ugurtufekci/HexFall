using UnityEngine;

public class Hex : MonoBehaviour {
    
    //coordinates in the map
    public int x;
    public int y;

    public Hex [] GetNeighbours()
    {
        //

        GameObject left = GameObject.Find("Hex_" + (x - 1) + "_" + y);
        GameObject right = GameObject.Find("Hex_" + (x + 1) + "_" + y);

        //
       
        return null;
    }

    public void Update()
    {
        
    }
}
