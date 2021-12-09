using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class ParticleManager : MonoBehaviour
{

    [SerializeField] GameObject mushroom;
    [SerializeField] GameObject particle;
    private float flagForTrigger1;
    private float flagForTrigger2;

    
    public void TriggerTheParticle()
    {
        StartCoroutine(ExecuteParticle());
    }



    IEnumerator ExecuteParticle()
    {
        yield return new WaitForSeconds(3);

        Instantiate(particle, new Vector3(mushroom.transform.position.x, 
            mushroom.transform.position.y, mushroom.transform.position.z),Quaternion.identity);

        Destroy(gameObject);
    }



}
