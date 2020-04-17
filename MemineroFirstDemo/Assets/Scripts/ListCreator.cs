using UnityEngine;

public class ListCreator : MonoBehaviour
{

    [SerializeField]
    private Transform SpawnPoint = null;

    [SerializeField]
    private GameObject item = null;

    [SerializeField]
    private RectTransform content = null;

    [SerializeField]
    private int numberOfItems = 3;

    public string[] itemNames = null;
    public Sprite[] itemImages = null;

    // Use this for initialization
    void Start()
    {

        //setContent Holder Height;
        content.sizeDelta = new Vector2(0, numberOfItems * 60);

        for (int i = 0; i < numberOfItems; i++)
        {
            // 60 width of item
            float spawnY = i * 60;
            //newSpawn Position
            Vector3 pos = new Vector3(SpawnPoint.position.x, -spawnY, SpawnPoint.position.z);
            //instantiate item
            GameObject SpawnedItem = Instantiate(item, pos, SpawnPoint.rotation);
            //setParent
            SpawnedItem.transform.SetParent(SpawnPoint, false);
            //get ItemDetails Component
            ItemDetails itemDetails = SpawnedItem.GetComponent<ItemDetails>();
            //set name
            itemDetails.text.text = itemNames[i];
            //set image
            itemDetails.image.sprite = itemImages[i];


        }
    }
}