using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoLoco : MonoBehaviour
{
  
    public Transform target;           
    CapsuleCollider capsuleCollider;
    public float speed = 5f;
    public float rotateSpeed = 0.025f;
    private Rigidbody2D rb;
    private MaquinaDeEstado maquinaDeEstados;

    private SpriteRenderer rend;
    private Sprite formaDos;


    void Awake ()
        {          
            capsuleCollider = GetComponent <CapsuleCollider> ();
            maquinaDeEstados = GetComponent<MaquinaDeEstado>();

        }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
        formaDos = Resources.Load<Sprite>("cambiaforma");
        rend.sprite = formaDos;
    }

    private void Update()
    {
        rend.sprite = formaDos;
        if(!target){
            GetTarget();
        } else {
            RotateTowardsTarget();
        }
    }

    private void FixedUpdate(){
        rb.velocity = transform.up * speed;
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

    private void GetTarget(){
        if(GameObject.FindGameObjectWithTag("Player")){
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Player")){
            Destroy(other.gameObject);
            target = null;
        } 
    } 

    
}
