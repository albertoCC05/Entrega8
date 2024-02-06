using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class exercice1 : MonoBehaviour
{
    // exercice 1 

    private int result = 0;
    [SerializeField] private TextMeshProUGUI resultText;

    private IEnumerator SumOfTeenFirstNumbers()
    {
       for ( int i = 1; i <= 10; i++)
        {

            result = result + i;

            resultText.text = $"result = {result}";
            
            
            yield return new WaitForSeconds(1);

        }
        
        
    }
    private void Start()
    {
        StartCoroutine(SumOfTeenFirstNumbers());
    }
}
