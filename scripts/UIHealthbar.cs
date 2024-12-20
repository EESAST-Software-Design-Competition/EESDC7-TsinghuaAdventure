using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthbar : MonoBehaviour
{
    // Start is called before the first frame update
    public static UIHealthbar instance { get; private set; }
    public Image mask;
    float originalSize;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        originalSize = mask.rectTransform.rect.width;
    }
    public void SetValue(float value)
    {
        mask.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, originalSize * value);


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
