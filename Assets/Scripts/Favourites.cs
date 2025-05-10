using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Mesh;

public class Favourites : MonoBehaviour
{
    [SerializeField] private GameObject dishPrefab;
    [SerializeField] private Transform dishContainer;
    [SerializeField] private DishMenu dishMenu;
    [SerializeField] private TMP_InputField searchInput;

    private DishData currentDishData = null;

    private void Awake()
    {
        Dishes.LoadDishes();
    }

    private void Start()
    {
        DisplayDishes(searchInput.text);
    }

    private void DisplayDishes(string search)
    {
        foreach (Transform dish in dishContainer)
        {
            Destroy(dish.gameObject);
        }

        var filteredDishes = Dishes.dishes;

        if (!string.IsNullOrEmpty(search))
        {
            filteredDishes = filteredDishes.Where(dish => dish.dishName.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        foreach (DishData dishData in filteredDishes)
        {
            if(dishData.isLiked)
            {
                GameObject dishObject = Instantiate(dishPrefab, dishContainer);
                dishObject.name = dishData.dishName;
                Dish dish = dishObject.GetComponent<Dish>();
                dish.SetData(dishData);
                dish.dishButton.onClick.RemoveAllListeners();
                dish.dishButton.onClick.AddListener(() => OnDishClick(dishData));
            }         
        }
    }

    private void OnDishClick(DishData data)
    {
        currentDishData = data;
        dishMenu.gameObject.SetActive(true);
        dishMenu.SetUp(currentDishData);
    }

    public void CloseDishMenu()
    {
        dishMenu.gameObject.SetActive(false);
        currentDishData = null;
        DisplayDishes(searchInput.text);
    }

    public void Search()
    {
        DisplayDishes(searchInput.text);
    }
}
