using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Transform target;
    public float speed;
    public float rotateSpeed = 0.0025f;

    private Rigidbody2D Rigidbody2D;
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if(!target){
            GetTarget();
        } else {
            RotateTowardsTarget();
        }
    }

     private void RotateTowardsTarget(){
        Vector2 targetDirection = target.position - transform.position;
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg - 90f;
        Quaternion q = Quaternion.Euler(new Vector3(0,0,angle));
        transform.localRotation = Quaternion.Slerp(transform.localRotation, q, rotateSpeed);
        // Quaternion rotation = Quaternion.LookRotation
        // (target.transform.position - transform.position, transform.TransformDirection(Vector3.up));
        // transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);

    }

     private void FixedUpdate(){
        Rigidbody2D.velocity = transform.up * speed;
    }

     private void GetTarget(){
        if(GameObject.FindGameObjectWithTag("Enemigos")){
            target = GameObject.FindGameObjectWithTag("Enemigos").transform;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Player") || col.gameObject.CompareTag("Bull")) return;

        if(col.gameObject.name.Contains( "cambiaforma2"))
        {
           col.GetComponent<MaquinaDeEstado>().TakeDamage(30);

        }

        Destroy(gameObject);

    }

}
