using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DishCategory
{
    Pizza, Burger, Roll, Sushi, Sandwich, Meat, Croissant, Cinnamonl, All
}

[System.Serializable]
public class DishData
{
    public string dishName;
    public string ingridients;
    public string recipe;
    public DishCategory dishCategory;
    public float dishRating;
    public bool isLiked;

    public DishData(string dishName, string ingridients, string recipe, DishCategory dishCategory, float dishRating, bool isLiked)
    {
        this.dishName = dishName;
        this.ingridients = ingridients;
        this.recipe = recipe;
        this.dishCategory = dishCategory;
        this.dishRating = dishRating;
        this.isLiked = isLiked;
    }
}

public static class DishDataManager
{
    public static string dishesDataKey = "DishData";

    public static void SaveCardDataList(List<DishData> dishesDataList)
    {
        if (dishesDataList == null)
        {
            Debug.LogWarning("Trying to save null card data list for key: " + dishesDataKey);
            return;
        }

        string json = JsonUtility.ToJson(new DishesDataListWrapper(dishesDataList));
        PlayerPrefs.SetString(dishesDataKey, json);
        PlayerPrefs.Save();
        Debug.Log("Saved dishes data for key: " + dishesDataKey);
    }

    public static List<DishData> LoadDishesDataList()
    {
        if (PlayerPrefs.HasKey(dishesDataKey))
        {
            string json = PlayerPrefs.GetString(dishesDataKey);
            if (!string.IsNullOrEmpty(json))
            {
                DishesDataListWrapper wrapper = JsonUtility.FromJson<DishesDataListWrapper>(json);
                if (wrapper != null && wrapper.dishesDataList != null)
                {
                    Debug.Log("Loaded card data for key: " + dishesDataKey);
                    return wrapper.dishesDataList;
                }
                else
                {                  
                    Debug.LogError("Wrapper or dishesDataList is null");
                }
            }
        }
        else
        {
            Debug.LogWarning("PlayerPrefs key not found: " + dishesDataKey);
        }

        return null;
    }
}

[System.Serializable]
public class DishesDataListWrapper
{
    public List<DishData> dishesDataList;

    public DishesDataListWrapper(List<DishData> dishesDataList)
    {
        this.dishesDataList = dishesDataList;
    }
}
