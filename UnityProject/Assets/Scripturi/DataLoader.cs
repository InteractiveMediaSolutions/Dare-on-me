using UnityEngine;
using System.Collections;

public class DataLoader : MonoBehaviour {

   IEnumerator  Start()
    {
        WWW itemData = new WWW("http://coadademaimuta.com/eduard_udriste_licenta/ItemsData.php");

        yield return itemData;
        string itemsDataString = itemData.text;
        print(itemsDataString);
        
    }

}
