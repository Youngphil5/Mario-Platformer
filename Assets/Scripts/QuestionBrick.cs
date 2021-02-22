using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionBrick : MonoBehaviour
{
    public Coin b;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        b.AddCoin();
    }
}
