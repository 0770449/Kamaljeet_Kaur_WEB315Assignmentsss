using System.Collections.Generic;


public class GroceryIsle
{
    public List<FoodItem> ListofFoodItems;
    public string IsleName { get; set; }
    public int IsleNumber { get; set; } 

    public GroceryIsle (string IsleName, int IsleNumber, List<FoodItem> ListofFoodItems)
    {
        this.IsleName = IsleName;
        this.IsleNumber = IsleNumber;
        this.ListofFoodItems = ListofFoodItems;
    }
}