using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    Vector3 rotation;

    [SerializeField] private GameObject go_camera;

    void Start()
    {
        rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            //this.transform.position = this.transform.position + new Vector3(0, 0, 1) * Time.deltaTime;
            this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);//이동

            //this.transform.eulerAngles = transform.eulerAngles + new Vector3(90, 0, 0) * Time.deltaTime;
            //rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
            //this.transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);
            // Debug.Log(transform.eulerAngles);

            this.transform.rotation = Quaternion.Euler(rotation + new Vector3(90, 0, 0) * Time.deltaTime);//회전

            this.transform.localScale = this.transform.localScale + new Vector3(2, 2, 2) * Time.deltaTime;//크게

            this.transform.LookAt(go_camera.transform.position);//카메라를 바라봄

            transform.RotateAround(go_camera.transform.position, Vector3.up, 100 * Time.deltaTime);//카메라 주변을 돎
        }
    }



}
