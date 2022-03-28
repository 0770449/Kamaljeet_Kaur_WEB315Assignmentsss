using System.Collections.Generic;


public class GroceryIsle
{
    public List<FoodItem> ListofFoodItems;
    public string IsleName { get; set; }
    public float IsleNumber { get; set; } 

    public GroceryIsle (string IsleName, float IsleNumber, List<FoodItem> ListofFoodItems)
    {
        this.IsleName = IsleName;
        this.IsleNumber = IsleNumber;
        this.ListofFoodItems = ListofFoodItems;
    }
}