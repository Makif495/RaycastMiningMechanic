using UnityEngine;
using UnityEngine.Tilemaps;

public class PickaxeMining : MonoBehaviour
{
    public Transform handTransform;
    public float miningRange = 1.5f;
    public LayerMask mineableLayer;
    public Tilemap tilemap;
    public TileBase emptyTile1;

    PickaxeHandler pickaxeHandler;
    Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>();
        pickaxeHandler = FindObjectOfType<PickaxeHandler>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && pickaxeHandler.isPickaxeVisible)
        {
            Mine();
        }
    }

    void Mine()
{
    Vector2 direction = transform.localScale.x > 0 ? Vector2.right : Vector2.left;
    Debug.Log("Kazma Yönü: " + direction);
    Debug.DrawRay(handTransform.position, direction * miningRange, Color.red, 2f);

    RaycastHit2D hit = Physics2D.Raycast(player.transform.position, direction, miningRange, mineableLayer);

    if (hit.collider != null)
    {
        Debug.Log("Kazma ile vuruldu: " + hit.collider.gameObject.name);
        Vector3Int tilePosition = tilemap.WorldToCell(hit.point);
        Debug.Log("Tile Pozisyonu: " + tilePosition);

        if (tilemap.GetTile(tilePosition) != emptyTile1)
        {
            tilemap.SetTile(tilePosition, emptyTile1);
            Debug.Log("Tile kırıldı: " + tilePosition);

            if (player != null)
            {
                player.CollectDirt();
            }
        }
    }
    else
    {
        Debug.Log("Raycast hiçbir şeye çarpmadı.");
    }
}
}
