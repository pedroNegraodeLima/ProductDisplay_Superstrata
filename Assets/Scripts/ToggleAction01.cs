using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabInstatiator : MonoBehaviour
{
    public GameObject myPrefabOne;
    public GameObject myPrefabTwo;
    public GameObject myPrefabThree;

    GameObject prefabOne = null;
    GameObject prefabTwo = null;
    GameObject prefabThree = null;



    public void ObjInstantiatorOne(bool isActive)
    {

        if (isActive == false)
        {
            isActive = true;

            // Instantiate at position (0, 0, 0) and zero rotation.
            prefabOne = Instantiate(myPrefabOne, new Vector3(0, 0, 0), Quaternion.identity);
        }

        else
        {
            Destroy(prefabOne);
            isActive = false;
        }
    }


    public void ObjInstantiatorTwo(bool isActive)
        {

            if (isActive == false)
            {
                isActive = true;

                // Instantiate at position (0, 0, 0) and zero rotation.
                prefabTwo = Instantiate(myPrefabTwo, new Vector3(1, 1, 0), Quaternion.identity);
            }

            else
            {
                Destroy(prefabTwo);
                isActive = false;
            }


    }

    public void ObjInstantiatorThree(bool isActive)
    {

        if (isActive == false)
        {
            isActive = true;

            // Instantiate at position (0, 0, 0) and zero rotation.
            prefabThree = Instantiate(myPrefabThree, new Vector3(-1, 0, 0), Quaternion.identity);
        }

        else
        {
            Destroy(prefabThree);
            isActive = false;
        }
    }
}