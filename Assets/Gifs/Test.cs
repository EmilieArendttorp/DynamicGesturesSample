using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;
    int i = -1;

    Image image = null;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        image.sprite = sprites[i];

        if(i == sprites.Length - 1)
        {
            i = -1;
        }
    }
}
