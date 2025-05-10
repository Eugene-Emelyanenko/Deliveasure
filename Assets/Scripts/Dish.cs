using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dish : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dishNameText;
    [SerializeField] private TextMeshProUGUI recipeText;
    [SerializeField] private Image dishIcon;
    [SerializeField] private TextMeshProUGUI ratingText;
    [SerializeField] private Image likeButtonImage;
    [SerializeField] private Sprite unlikedSprite;
    [SerializeField] private Sprite likedSprite;
    public Button dishButton;
    private DishData dishData;

    public void SetData(DishData data)
    {
        dishData = data;
        dishNameText.text = data.dishName;
        recipeText.text = data.recipe;
        dishIcon.sprite = Resources.Load<Sprite>($"{data.dishCategory.ToString()}/{data.dishName}");
        ratingText.text = data.dishRating.ToString();
        SwitchLikeButtonSprite();
    }

    public void Like()
    {
        dishData.isLiked = !dishData.isLiked;
        SwitchLikeButtonSprite();
        DishDataManager.SaveCardDataList(Dishes.dishes);
    }

    private void SwitchLikeButtonSprite()
    {
        likeButtonImage.sprite = dishData.isLiked ? likedSprite : unlikedSprite;
    }
}
