using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{

    public GameObject button;
    
    private Color c;
    public Slider r;    
    public Slider g;
    public Slider b;
    public Slider alpha;
    public RawImage img;
    
    //TODO create 2 new public variables for the width and height sliders


    // Update is called once per frame
    void Update()
    {
        c.r = r.value;
        c.g = g.value;
        c.b = b.value;
        c.a = alpha.value;
        img.color = c;

        //TODO modify the images Width and Height based on the sliders value
        //Images transform scale = a new vector 3(width, height, 1);
        //replace width and height with the values from the sliders you created



        //img.transform.localScale = new Vector3(width, height, 1);
    }

    public void showImage()
    {
        if(c.a > 0)
        {
            alpha.value = 0;
            r.value = 0;
            g.value = 0;
            b.value = 0;
        }
        else if(c.a == 0)
        {
            alpha.value = 1;
            r.value = 1;
            g.value = 1;
            b.value = 1;
        }
        return;
    }
}
