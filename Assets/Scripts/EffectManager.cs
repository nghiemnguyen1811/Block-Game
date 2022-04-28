using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    public ParticleSystem explosion;
    // Start is called before the first frame update
    void Start()
    {
        explosion.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Explosion()
    {
        explosion.Play(); 
    }
}
