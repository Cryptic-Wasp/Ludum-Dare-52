using UnityEngine;

public enum InteractableTypes {
    Water,
    WheatSeed,
    CarrotSeed,
    BeetSeed,
    CropSeeded,
    CropEmpty,
    CropDead
}

public class Interactable : MonoBehaviour {
    public InteractableTypes type;

    public void Interact() {
        if (type == InteractableTypes.Water) {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInteraction>().inventory = PlayerItemTypes.WaterCan;
        } else if (type == InteractableTypes.WheatSeed) {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInteraction>().inventory = PlayerItemTypes.WheatSeed;
        } else if (type == InteractableTypes.CarrotSeed) {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInteraction>().inventory = PlayerItemTypes.CarrotSeed;
        } else if (type == InteractableTypes.BeetSeed) {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInteraction>().inventory = PlayerItemTypes.BeetSeed;
        }  else if (type == InteractableTypes.CropEmpty) {
            if (GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInteraction>().inventory == PlayerItemTypes.WheatSeed || GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInteraction>().inventory == PlayerItemTypes.CarrotSeed || GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInteraction>().inventory == PlayerItemTypes.BeetSeed) {
                GetComponent<CropSlot>().empty = false;
                GetComponent<CropSlot>().seed = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInteraction>().inventory;
                GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInteraction>().inventory = PlayerItemTypes.Empty;
                type = InteractableTypes.CropSeeded;
            }
        }
    }
    void Update() {
        if (type == InteractableTypes.CropSeeded) {

        }
    }
}
