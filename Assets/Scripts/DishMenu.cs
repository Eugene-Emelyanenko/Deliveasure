using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DishMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dishNameText;
    [SerializeField] private TextMeshProUGUI ratingText;
    [SerializeField] private TextMeshProUGUI ingredientsText;
    [SerializeField] private TextMeshProUGUI recipeText;
    [SerializeField] private Image dishIcon;
    [SerializeField] private Button likeButton;
    [SerializeField] private Image likeButtonImage;
    [SerializeField] private Sprite likedSprite;
    [SerializeField] private Sprite unlikedSprite;
    private DishData currentDishData = null;

    public void SetUp(DishData data)
    {
        currentDishData = data;
        dishNameText.text = currentDishData.dishName;
        ingredientsText.text = $"Ingredients: \r\n{currentDishData.ingridients}";
        recipeText.text = currentDishData.recipe;
        ratingText.text = currentDishData.dishRating.ToString();
        dishIcon.sprite = Resources.Load<Sprite>($"{currentDishData.dishCategory.ToString()}/{currentDishData.dishName}");
        SwitchLikeButtonSprite();
        likeButton.onClick.RemoveAllListeners();
        likeButton.onClick.AddListener(Like);
    }

    public void Like()
    {
        currentDishData.isLiked = !currentDishData.isLiked;
        SwitchLikeButtonSprite();
        DishDataManager.SaveCardDataList(Dishes.dishes);
    }

    private void SwitchLikeButtonSprite()
    {
        likeButtonImage.sprite = currentDishData.isLiked ? likedSprite : unlikedSprite;
    }
}
