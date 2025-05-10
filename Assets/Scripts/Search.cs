using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Mesh;

public class Search : MonoBehaviour
{
    [SerializeField] private GameObject dishPrefab;
    [SerializeField] private Transform dishContainer;
    [SerializeField] private RectTransform searchTransform;
    [SerializeField] private TMP_InputField searchInput;
    [SerializeField] private DishMenu dishMenu;
    [SerializeField] private GameObject otherMenu;
    [SerializeField] private GameObject dishesObject;

    private DishData currentDishData = null;

    private void Awake()
    {
        Dishes.LoadDishes();
    }

    private void Start()
    {
        SetDefault();
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
            GameObject dishObject = Instantiate(dishPrefab, dishContainer);
            dishObject.name = dishData.dishName;
            Dish dish = dishObject.GetComponent<Dish>();
            dish.SetData(dishData);
            dish.dishButton.onClick.RemoveAllListeners();
            dish.dishButton.onClick.AddListener(() => OnDishClick(dishData));
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

    public void Searchh()
    {
        if(searchInput.text == string.Empty)
        {
            SetDefault();
        }
        else
        {
            dishesObject.SetActive(true);
            otherMenu.SetActive(false);
            searchTransform.anchoredPosition = new Vector3(0, 760, 0);
            DisplayDishes(searchInput.text);
        }
        
    }

    private void SetDefault()
    {
        dishesObject.SetActive(false);
        otherMenu.SetActive(true);
        searchTransform.anchoredPosition = new Vector3(0, -100, 0);
    }
}
