using UnityEngine;

public class PickaxeHandler : MonoBehaviour
{
    public GameObject pickaxePrefab; 
    public Transform handTransform; 

    private GameObject currentPickaxe; 
    public bool isPickaxeVisible = false; 

    void Start()
    {
        EquipPickaxe(); 
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E) && currentPickaxe != null)
        {
            isPickaxeVisible = true;
            currentPickaxe.SetActive(true);
        }

        
        if (Input.GetKeyDown(KeyCode.R) && currentPickaxe != null)
        {
            isPickaxeVisible = false;
            currentPickaxe.SetActive(false);
        }
    }

     public void EquipPickaxe()
    {
        
        if (currentPickaxe != null) return;

        if (pickaxePrefab != null && handTransform != null)
        {
            currentPickaxe = Instantiate(pickaxePrefab, handTransform.position, handTransform.rotation);
            currentPickaxe.transform.SetParent(handTransform); 
            currentPickaxe.SetActive(false); 
        }
    }
}
