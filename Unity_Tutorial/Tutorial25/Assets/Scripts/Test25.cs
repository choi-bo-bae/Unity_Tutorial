using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test25 : MonoBehaviour , IPointerDragHandler, IPointerUpHandler, IDragHandler
{

    
    [SerializeField] private RectTransform rect_Background;
    [SerializeField] private RectTransform rect_Joystick;

    private float radius;

    [SerializeField] private GameObject go_Player;
    [SerializrField] private private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        radius = rect_Background.rect.eidth * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
