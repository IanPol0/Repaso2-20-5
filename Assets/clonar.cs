using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clonar : MonoBehaviour
{
    public GameObject prefab;
    public int counter;
    public Text inputCloneAmount;
    public Text ClonesLeft;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        ClonesLeft.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClonePrefab()
    {
        if (counter < int.Parse(inputCloneAmount.text))
        {
            Instantiate(prefab);
            counter++;
            ClonesLeft.text = (int.Parse(inputCloneAmount.text) - counter).ToString();
        }

    }

}
