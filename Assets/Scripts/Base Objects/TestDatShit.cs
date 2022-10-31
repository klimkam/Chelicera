using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDatShit : MonoBehaviour
{
    // Start is called before the first frame update
    private Character character = new Character();
    void Start()
    {
        character.Health = 100000;
    }

    // Update is called once per frame
    void Update()
    {
        character.DealDamage(100);
    }
}
