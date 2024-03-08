using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    

    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            if (player.HasKitchenObject())
            {
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                //player not carry anything
            }
        }
        else
        {
            //kitchenobj
            if(player.HasKitchenObject())
            {
                //player carry something
            }
            else
            {
                //player isnt carry anything
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }

}
