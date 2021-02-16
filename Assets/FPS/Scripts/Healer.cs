using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : MonoBehaviour
{
    private float update;

    public GameObject[] HealNPCs;

    // Start is called before the first frame update
    void Start()
    {
        update = 0.0f;
        if (HealNPCs.Length == 0)
        {
            return;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject healingNpc = HealNPCs[0];
        if (healingNpc == null)
        {
            // Don't process for invalid npc
            return;
        }

        update += Time.deltaTime;
        if (update > 3.0f /* Every 3 seconds */)
        {
            Health npcHealth = healingNpc.GetComponent<Health>();
            Debug.Log("Health is currenly: " + npcHealth.currentHealth);
            npcHealth.Heal(Random.Range(1, 50));
            update = 0.0f; // Reset the interval
        }
        
    }
}
