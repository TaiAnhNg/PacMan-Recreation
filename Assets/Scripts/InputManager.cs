using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Tweener tweener;
    public Animator pacControl;
    //private int tempItem;
    [SerializeField]
    private GameObject pac;
    //private GameObject[] item;
    //private Transform[] transformArray;

    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
        // Moving vertically
        /*if (item[1].transform.position.y > item[0].transform.position.y)
        {
            Vector3 tempPos = item[1].transform.position;
            Vector3 endPos = new Vector3(item[0].transform.position.x,
                                                               tempPos.y,
                                                               item[0].transform.position.z);
            tweener.AddTween(item[0].transform, item[0].transform.position, endPos, 1.5f);
            Vector3 endposTemp = new Vector3(item[1].transform.position.x,
                                                            item[0].transform.position.y,
                                                            item[1].transform.position.z);
            tweener.AddTween(item[1].transform, item[1].transform.position, endposTemp, 1.5f);
        }

        // Moving horizontally
        else if(item[1].transform.position.y < item[0].transform.position.y)
        {
            Vector3 tempPos = item[1].transform.position;
            Vector3 endPos = new Vector3(tempPos.x, item[0].transform.position.y, item[0].transform.position.z);
            tweener.AddTween(item[0].transform, item[0].transform.position, endPos, 1.5f);
            Vector3 endposTemp = new Vector3(item[0].transform.position.x,
                                                            item[1].transform.position.y,
                                                            item[1].transform.position.z);
            tweener.AddTween(item[1].transform, item[1].transform.position, endposTemp, 1.5f);
        }*/
        /*int rightMost = 0;
        if (transformArray[1].position.x > transformArray[0].position.x)
            rightMost = 1;

        Vector3 tempPos = transformArray[rightMost].position;
        // Moving vertically
        if (transformArray[rightMost].position.y > transformArray[1 - rightMost].position.y)
        {
            Vector3 endposTemp = new Vector3(transformArray[rightMost].position.x,
                                                            transformArray[1 - rightMost].position.y,
                                                            transformArray[rightMost].position.z);
            tweener.AddTween(transformArray[rightMost], transformArray[rightMost].position, endposTemp, 1.5f);
            Vector3 endPos = new Vector3(transformArray[1 - rightMost].position.x,
                                                               tempPos.y,
                                                               transformArray[1 - rightMost].position.z);
            tweener.AddTween(transformArray[1 - rightMost], transformArray[1 - rightMost].position, endPos, 1.5f);
        }

        // Moving horizontally
        else
        {
            Vector3 endposTemp = new Vector3(transformArray[1 - rightMost].position.x,
                                                            transformArray[rightMost].position.y,
                                                            transformArray[rightMost].position.z);
            tweener.AddTween(transformArray[rightMost], transformArray[rightMost].position, endposTemp, 1.5f);
            Vector3 endPos = new Vector3(tempPos.x,
                                                               transformArray[1 - rightMost].position.y,
                                                               transformArray[1 - rightMost].position.z);
            tweener.AddTween(transformArray[1 - rightMost], transformArray[1 - rightMost].position, endPos, 1.5f);
        }*/

        Vector3 checkPoint1 = new Vector3(6.5f, -0.5f, 0.0f);
        if (pac.transform.position.x < checkPoint1.x && pac.transform.position.y >= checkPoint1.y)
        {
            tweener.AddTween(pac.transform, pac.transform.position, checkPoint1, 1.5f);
            Vector3 param = checkPoint1 - pac.transform.position;
            pacControl.SetFloat("DirX", param.x);
        }
        Vector3 checkPoint2 = new Vector3(6.5f, -4.5f, 0.0f);
        if (pac.transform.position.y > checkPoint2.y)
        {
            tweener.AddTween(pac.transform, pac.transform.position, checkPoint2, 1.5f);
            Vector3 param = checkPoint2 - pac.transform.position;
            pacControl.SetFloat("DirX", param.y);
        }
        Vector3 checkPoint3 = new Vector3(1.5f, -4.5f, 0.0f);
        if (pac.transform.position.x > checkPoint3.x)
        {
            tweener.AddTween(pac.transform, pac.transform.position, checkPoint3, 1.5f);
            Vector3 param = checkPoint3 - pac.transform.position;
            pacControl.SetFloat("DirX", param.x);
        }
        Vector3 checkPoint4 = new Vector3(1.5f, -0.5f, 0.0f);
        if (pac.transform.position.y < checkPoint4.y)
        {
            tweener.AddTween(pac.transform, pac.transform.position, checkPoint4, 1.5f);
            Vector3 param = checkPoint4 - pac.transform.position;
            pacControl.SetFloat("DirX", param.y);
        }
    }
}

