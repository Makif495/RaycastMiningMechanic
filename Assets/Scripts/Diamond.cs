using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Diamond : MonoBehaviour
{
    private Rigidbody2D rb;
    public Tilemap tilemap;
    public TileBase emptyTile1;
    private Vector3Int currentTilePos;
    private bool isFalling = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        rb.isKinematic = true;
        currentTilePos = tilemap.WorldToCell(transform.position);
    }

    void Update()
    {
        if (!isFalling && tilemap.GetTile(currentTilePos) == emptyTile1)
        {
            Debug.Log("Elmasýn bulunduðu tile kazýldý! Elmas düþüyor.");
            rb.isKinematic = false; 
            rb.gravityScale = 1;
            isFalling = true; 
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground")) 
        {
            rb.isKinematic = true;
            rb.velocity = Vector2.zero; 
            Debug.Log("Elmas yere düþtü ve durdu.");
        }

       
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Elmas toplandý!");
            Destroy(gameObject); 
        }

    }
   

}
