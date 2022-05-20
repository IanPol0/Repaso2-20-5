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
    public InputField ifield;

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

        if (inputCloneAmount.text != "")
        {
            ifield.readOnly = true;
            int cantLimite = int.Parse(inputCloneAmount.text);

            if (counter < cantLimite)
            {
                Instantiate(prefab);
                counter++;
                ClonesLeft.text = (cantLimite - counter).ToString();
            }
            else ClonesLeft.text = "No hay más";
        }

        else
        {
            ClonesLeft.text = "ERROR. Ingrese un valor";
        }
        

    }

}
