using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public GameObject item1UI, item2UI;
    string item1, item2;
    public float bounceForce;
    public Sprite bounceSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("q"))
        {
            item1 = PlayerItems.Item2;
            item2 = PlayerItems.Item1;
            PlayerItems.Item1 = item1;
            PlayerItems.Item2 = item2;
            if(item1=="Bouncer")
            {
                item1UI.GetComponent<Image>().sprite = bounceSprite;
            }

            if(item2=="Bouncer")
            {
                item2UI.GetComponent<Image>().sprite = bounceSprite;
            }
        }
        if(Input.GetKeyDown("e"))
        {
            UseItem();
        }
    }

    void UseItem()
    {
        if(item1=="Bouncer")
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce);
            item1 = item2;
            item2 = null;
        }
     
    }
}
