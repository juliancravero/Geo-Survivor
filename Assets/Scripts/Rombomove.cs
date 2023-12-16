using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rombomove : MonoBehaviour
{

    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Vector2 direccion;
    public GameObject BulletPrefab;
    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    private float LastShoot;
    public float firerate = 0.25f;
    public int Experiencia;
    public const int MaxExperience = 100; 
    public static bool Vulnerable = true;
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {

        direccion = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        if (Time.time > LastShoot + firerate) 
        {
           Shoot();
            LastShoot = Time.time; 
        }
    }
    public void AddExperience(int newExp){
        Experiencia += newExp;
        if(Experiencia > MaxExperience)
            Experiencia = 0;
    }
    private void Shoot()
    {
        GameObject bullet = Instantiate(BulletPrefab, transform.position, Quaternion.identity);
        Destroy(bullet, 5);
    }

    private void FixedUpdate()
    {
        Rigidbody2D.MovePosition(Rigidbody2D.position + direccion * velocidadMovimiento * Time.fixedDeltaTime);
    }
}
