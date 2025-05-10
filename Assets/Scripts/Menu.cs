using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Mesh;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject dishPrefab;
    [SerializeField] private Transform dishContainer;
    [SerializeField] private Transform orderByTransform;
    [SerializeField] private TMP_InputField searchInput;
    [SerializeField] private Transform categoriesContainer;
    [SerializeField] private DishMenu dishMenu;

    public Vector2 dishSize1x1 = new Vector2(375, 375);
    public Vector2 dishSize2x1 = new Vector2(775, 375);

    private DishCategory selectedDishCategory = DishCategory.All;
    private bool sortedByAscending = false;
    private GridLayoutGroup gridLayoutGroup;
    private DishData currentDishData = null;

    private void Awake()
    {
        Dishes.LoadDishes();
        DishCategory.TryParse(PlayerPrefs.GetString("SelectedDishCategory", "All"), true, out selectedDishCategory);
        gridLayoutGroup = dishContainer.GetComponent<GridLayoutGroup>();
    }

    private void Start()
    {
        CloseDishMenu();
        ChangeColor();
        OrderBy();
    }

    private void DisplayDishes(DishCategory dishCategory, string search)
    {
        foreach (Transform dish in dishContainer)
        {
            Destroy(dish.gameObject);
        }

        var filteredDishes = dishCategory == DishCategory.All
            ? Dishes.dishes
            : Dishes.dishes.Where(dish => dish.dishCategory == dishCategory).ToList();

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

        Debug.Log($"Displayed {filteredDishes.Count} dishes.");
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
        DisplayDishes(selectedDishCategory, searchInput.text);
    }

    public void OrderBy()
    {
        sortedByAscending = !sortedByAscending;

        List<DishData> sortedDishes;

        if (sortedByAscending)
        {
            sortedDishes = Dishes.dishes.OrderBy(dish => dish.dishRating).ToList();
            orderByTransform.localScale = new Vector3(1f, -1f, 1f);
        }
        else
        {
            sortedDishes = Dishes.dishes.OrderByDescending(dish => dish.dishRating).ToList();
            orderByTransform.localScale = new Vector3(1f, 1f, 1f);
        }

        Dishes.dishes = sortedDishes;

        DisplayDishes(selectedDishCategory, searchInput.text);
    }

    public void Search()
    {
        DisplayDishes(selectedDishCategory, searchInput.text);
    }

    public void ChangeCategory(string category)
    {
        DishCategory.TryParse(category, true, out selectedDishCategory);
        PlayerPrefs.SetString("SelectedDishCategory", selectedDishCategory.ToString());
        PlayerPrefs.Save();
        ChangeColor();
        DisplayDishes(selectedDishCategory, searchInput.text);
    }

    private void ChangeColor()
    {
        foreach (Transform category in categoriesContainer)
        {
            Image categoryImage = category.GetComponent<Image>();
            if (category.gameObject.name == selectedDishCategory.ToString())
                categoryImage.color = Color.black;
            else
                categoryImage.color = Color.white;
        }
    }

    public void SetDishSize1x1()
    {
        gridLayoutGroup.cellSize = dishSize1x1;
    }

    public void SetDishSize2x1()
    {
        gridLayoutGroup.cellSize = dishSize2x1;
    }
}
