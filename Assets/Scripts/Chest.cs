using UnityEngine;

public class Chest : MonoBehaviour
{
    public Sprite closedChest; 
    public Sprite openedChest; 
    private SpriteRenderer spriteRenderer;
    private bool isNearby = false; 
    private bool isOpened = false; 

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = closedChest; 
    }

    void OnMouseDown()
    {
        if (isNearby) 
        {
            if (isOpened)
            {
                spriteRenderer.sprite = closedChest; 
            }
            else
            {
                spriteRenderer.sprite = openedChest; 
            }

            isOpened = !isOpened; 
            Debug.Log("Sandýk durumu deðiþti! Þu an: " + (isOpened ? "Açýk" : "Kapalý"));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isNearby = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isNearby = false;
        }
    }
}
