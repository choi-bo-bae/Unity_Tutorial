using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
   
    private Rigidbody myRigid;
    //private Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
        //rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            //myRigid.velocity = new Vector3(0, 0, 1);

            //myRigid.velocity = Vector3.forward;//이동
            //myRigid.maxAngularVelocity = 100f;
            //myRigid.angularVelocity = Vector3.right * 100;//회전

            //myRigid.MovePosition(Vector3.forward * Time.deltaTime);

            //rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
            //myRigid.MoveRotation(Quaternion.Euler(rotation)); //회전

            myRigid.AddForce(Vector3.forward);// 물리영향 받는 이동

            myRigid.AddTorque(Vector3.up);// 물리영향 받는거 회전

            myRigid.AddExplosionForce(10, this.transform.right, 10);//폭발 영향

            //Add가 붙으면 물리효과와 관련있음
        }
    }


}
