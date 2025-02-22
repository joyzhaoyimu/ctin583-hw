using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SearchService;

/* 
******************************************************************************************************
    Problem 1: TODO: Finish the case statements for each collectible item listed in CollectibleItems.cs

    Problem 2: TODO: Currently each case statement is written as a string. Enums are especially helpful 
    in preventing spelling mistakes. Instead of using strings such as "Enemy" and "Gem", lets use an enum. 
    Please modify each case statement to use an enum instead. 

enum ObjectType {
    Enemy,
    Gem
}

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private ParticleSystem enemyParticles;
    [SerializeField] private CollectibleItems collectibles;
    
    private void OnCollisionEnter(Collision collision) {
        if (System.Enum.TryParse(collision.gameObject.tag, out ObjectType objectType))
        {
            switch (objectType)
            {
                case ObjectType.Enemy:
                    Destroy(gameObject);
                    break;
                case ObjectType.Gem:
                    meshRenderer.material = collision.gameObject.GetComponent<Renderer>().material;
                    Destroy(collision.gameObject);
                    PlayParticles();
                    break;
                default:
                    break;
            }
        }
    }

    private bool IsCollectibleItem(CollectibleItems collectible) {
        return (collectibles & collectible) != 0;
    }

    void Start()
    {
        gameObject.tag = collectibles.ToString();
    }
}


--------------------------------------------------------------------------------------------------------------------------
    Problem 3: TODO: Define a normal tuple and a value tuple. When would you use a value tuple? 
    Print out each value in your defined tuple with Debug.Log

 private (int, string) normalTuple = (1, "Normal Tuple");
    private (int id, string name) valueTuple = (2, "Value Tuple");

    private void Start()
    {
        // Print values of the tuples
        Debug.Log("Normal Tuple: " + normalTuple.Item1 + ", " + normalTuple.Item2);
        Debug.Log("Value Tuple: " + valueTuple.id + ", " + valueTuple.name);

        // Set the tag based on the enum
        gameObject.tag = collectibles.ToString();
    }

    private void OnCollisionEnter(Collision collision) {
        if (System.Enum.TryParse(collision.gameObject.tag, out ObjectType objectType))
        {
            switch (objectType)
            {
                case ObjectType.Enemy:
                    Destroy(gameObject);
                    break;
                case ObjectType.Gem:
                    meshRenderer.material = collision.gameObject.GetComponent<Renderer>().material;
                    Destroy(collision.gameObject);
                    PlayParticles();
                    break;
                default:
                    break;
            }
        }
    }
--------------------------------------------------------------------------------------------------------------------------

    Problem 4: TODO: Define a new enum within this file taking in different types of particles. 
    Examples include: FireParticles, GoldRibbons, Snowflakes, RainParticles, etc. 
public enum ParticleType
{
    FireParticles,
    GoldRibbons,
    Snowflakes,
    RainParticles,
    Smoke
}

--------------------------------------------------------------------------------------------------------------------------

    Problem 5: TODO: 
        * When would you use a tuple over a struct?
Tuples are best for temporary, lightweight groupings of data, while structs are more structured and reusable.
If you need a return type for a method that groups a few values, a tuple is a great choice.
However, if you need a well-defined type with methods and behaviors, use a struct.


        * How do we acces items in a tuple?
You can access tuple elements using Item1, Item2, etc., or named fields if they are explicitly defined.


        * Try visualizing your enum in the Unity Editor. How does it appear as?
Enums appear as dropdown menus in the Unity Inspector, allowing developers to select a predefined value easily.




******************************************************************************************************
*/
public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private ParticleSystem enemyParticles;
    [SerializeField] private CollectibleItems collectibles; 

    private void OnCollisionEnter(Collision collision) {
        switch (collision.gameObject.tag) {
            case "Enemy":
                Destroy(gameObject);
                break;

            case "Gem":
                meshRenderer.material = collision.gameObject.GetComponent<Renderer>().material;
                Destroy(collision.gameObject);
                PlayParticles();
                break;

            default:
                break;
        }
    }

    // Check to make sure our value is defined
    private bool IsCollectibleItem(CollectibleItems collectible) {
        return (collectibles & collectible) != 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Set the tag based on the enum
        gameObject.tag = collectibles.ToString();
    }
}
