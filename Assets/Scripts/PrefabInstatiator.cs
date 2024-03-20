using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabInstatiator : MonoBehaviour
{
    public GameObject myPrefab;

    public void ObjInstantiator(bool isActive)
    {

        if (isActive == false)
        {
            isActive = true;
            
            // Instantiate at position (0, 0, 0) and zero rotation.
            Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }

        else
        {
            Destroy(myPrefab);
            isActive = false;
        }
        


        
    }
}