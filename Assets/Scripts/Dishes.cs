using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Dishes
{
    public static List<DishData> dishes = new List<DishData>();

    public static void LoadDishes()
    {
        dishes = DishDataManager.LoadDishesDataList();

        if (dishes == null || dishes.Count == 0)
        {
            Debug.Log("Creating new dishes");
            dishes = new List<DishData>
            {
                //Pizza

                new DishData(
                    //Dish Name
                    "Margherita Pizza",

                    //Ingredients
                    "1 pizza dough\r\n" +
                    "1 cup tomato sauce\r\n" +
                    "2 cups shredded mozzarella cheese\r\n" +
                    "Fresh basil leaves\r\n" +
                    "2 tbsp olive oil\r\n" +
                    "Salt to taste",

                    //Recipe
                    "Preheat your oven to 475°F (245°C) and roll out the pizza dough on a floured surface until it fits your pizza pan or baking sheet. Spread the tomato sauce evenly over the dough, leaving a small border around the edges. \r\n" +
                    "Next, sprinkle the shredded mozzarella cheese generously over the tomato sauce, ensuring even coverage for a balanced flavor. \r\n" +
                    "Gently place fresh basil leaves on top of the cheese. The basil will infuse the pizza with a delightful aroma and fresh taste as it bakes. \r\n" +
                    "Drizzle olive oil over the basil and cheese to enhance the flavors and give the pizza a beautiful finish. Season with a pinch of salt to taste. This step brings out the flavors of the ingredients and gives the pizza a well-rounded taste. \r\n" +
                    "Place the pizza in the preheated oven. Bake for 10-12 minutes until the crust is golden brown and the cheese is bubbly and slightly browned. The Margherita pizza is now ready to be sliced and served, offering a simple yet delicious combination of flavors.",

                    //Category
                    DishCategory.Pizza,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Pepperoni Pizza",

                    //Ingredients
                    "1 pizza dough\r\n"+
                    "1 cup tomato sauce\r\n"+
                    "2 cups shredded mozzarella cheese\r\n"+
                    "1/2 cup pepperoni slices\r\n"+
                    "1 tsp dried oregano",


                    //Recipe
                    "Begin by preheating your oven to 475°F (245°C). Roll out the pizza dough on a floured surface to your desired thickness, ensuring it fits your pizza pan or baking sheet. Spread a generous layer of tomato sauce over the dough, leaving a small border around the edges for the crust. \r\n" +
                    "Evenly sprinkle the shredded mozzarella cheese over the tomato sauce, covering the entire surface. This cheese layer will melt beautifully and create a gooey, delicious base for the pepperoni. \r\n" +
                    "Arrange the pepperoni slices over the cheese. You can overlap them slightly to ensure each bite has a bit of pepperoni. For added flavor, sprinkle dried oregano over the top of the pepperoni and cheese. \r\n" +
                    "Place the pizza in the oven and bake for 12-15 minutes until the crust is golden and the cheese is melted and bubbly. The pepperoni should also be slightly crispy. \r\n" +
                    "Once baked to perfection, remove the pizza from the oven. Let it cool for a couple of minutes before slicing and serving. Enjoy your classic and flavorful pepperoni pizza!",

                    //Category
                    DishCategory.Pizza,

                    //Rating
                    4.9f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "BBQ Chicken Pizza",

                    //Ingredients
                    "1 pizza dough\r\n"+
                    "1/2 cup BBQ sauce\r\n"+
                    "2 cups shredded mozzarella cheese\r\n"+
                    "1 cup cooked chicken breast, shredded\r\n"+
                    "1/2 cup sliced red onions\r\n"+
                    "Fresh cilantro, chopped",

                    //Recipe
                     "Preheat your oven to 475°F (245°C). Roll out the pizza dough on a floured surface, stretching it to fit your pizza pan or baking sheet. Spread BBQ sauce evenly over the dough, leaving a small border for the crust. \r\n" +
                     "Sprinkle shredded mozzarella cheese over the BBQ sauce, ensuring an even distribution. This cheese will melt and combine with the BBQ sauce to create a deliciously creamy base. \r\n" +
                     "Scatter the shredded cooked chicken breast over the cheese. Make sure the chicken is well-distributed to ensure each bite is packed with flavor. Add sliced red onions on top of the chicken, which will add a sweet and tangy crunch to the pizza. \r\n" +
                     "Bake the pizza for 12-15 minutes until the crust is golden and the cheese is melted and bubbly. Once out of the oven, sprinkle fresh cilantro over the top for a burst of freshness. Allow the pizza to cool for a couple of minutes before slicing. Enjoy the unique and savory taste of BBQ chicken pizza.",

                    //Category
                    DishCategory.Pizza,

                    //Rating
                    4.9f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Veggie Pizza",

                    //Ingredients
                    "1 pizza dough\r\n"+
                    "1 cup tomato sauce\r\n"+
                    "2 cups shredded mozzarella cheese\r\n"+
                    "1/2 cup sliced bell peppers\r\n"+
                    "1/2 cup sliced mushrooms\r\n"+
                    "1/2 cup sliced black olives\r\n"+
                    "1/4 cup red onion, thinly sliced\r\n"+
                    "1 tsp dried oregano",

                    //Recipe
                     "Start by preheating your oven to 475°F (245°C). Roll out the pizza dough on a floured surface until it fits your pizza pan or baking sheet. Spread the tomato sauce evenly over the dough, leaving a small border for the crust. \r\n" +
                     "Sprinkle shredded mozzarella cheese over the tomato sauce. This will create a creamy, cheesy base for your vegetables. \r\n" +
                     "Evenly distribute the sliced bell peppers, mushrooms, black olives, and red onion over the cheese. Sprinkle dried oregano over the top of the vegetables to enhance their flavors and add an aromatic touch to the pizza. \r\n" +
                     "Place the pizza in the preheated oven. Bake for 12-15 minutes until the crust is golden and the cheese is melted and bubbly. The vegetables should be tender and slightly caramelized. \r\n" +
                     "Remove the pizza from the oven and let it cool for a few minutes before slicing. Enjoy the fresh and vibrant flavors of a veggie pizza.",

                    //Category
                    DishCategory.Pizza,

                    //Rating
                    4.6f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Hawaiian Pizza",

                    //Ingredients
                    "1 pizza dough\r\n"+
                    "1 cup tomato sauce\r\n"+
                    "2 cups shredded mozzarella cheese\r\n"+
                    "1 cup cooked ham, diced\r\n"+
                    "1 cup pineapple chunks\r\n"+
                    "1 tsp dried oregano",

                    //Recipe
                     "Preheat your oven to 475°F (245°C). Roll out the pizza dough on a floured surface until it fits your pizza pan or baking sheet. Spread the tomato sauce evenly over the dough, leaving a small border for the crust. \r\n" +
                     "Sprinkle shredded mozzarella cheese over the tomato sauce, ensuring even coverage. This cheese layer will melt and create a perfect base for the toppings. \r\n" +
                     "Evenly distribute the diced ham and pineapple chunks over the cheese. The sweet and savory combination of ham and pineapple is what makes Hawaiian pizza unique and delicious. Sprinkle dried oregano over the top to add an aromatic touch. \r\n" +
                     "Place the pizza in the oven. Bake for 12-15 minutes until the crust is golden and the cheese is melted and bubbly. The pineapple should be slightly caramelized, and the ham should be heated through. \r\n" +
                     "Once baked, remove the pizza from the oven and let it cool for a few minutes before slicing. Enjoy the tropical flavors of Hawaiian pizza.",

                    //Category
                    DishCategory.Pizza,

                    //Rating
                    4.5f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Meat Lovers Pizza",

                    //Ingredients
                    "1 pizza dough\r\n"+
                    "1 cup tomato sauce\r\n"+
                    "2 cups shredded mozzarella cheese\r\n"+
                    "1/2 cup pepperoni slices\r\n"+
                    "1/2 cup cooked sausage, crumbled\r\n"+
                    "1/2 cup cooked bacon, crumbled\r\n"+
                    "1/2 cup cooked ground beef\r\n"+
                    "1 tsp dried oregano",


                    //Recipe
                     "Preheat your oven to 475°F (245°C). Roll out the pizza dough on a floured surface until it fits your pizza pan or baking sheet. Spread the tomato sauce evenly over the dough, leaving a small border for the crust. \r\n" +
                     "Sprinkle shredded mozzarella cheese over the tomato sauce. This cheese layer will melt and blend with the meats, creating a savory base. \r\n" +
                     "Arrange the pepperoni slices evenly over the cheese. Add crumbled sausage, cooked bacon, and cooked ground beef on top. Make sure to distribute the meats evenly to ensure each bite is packed with flavor. Sprinkle dried oregano over the top to enhance the flavors. \r\n" +
                     "Place the pizza in the oven. Bake for 12-15 minutes until the crust is golden and the cheese is melted and bubbly. The meats should be heated through and slightly crispy. \r\n" +
                     "Remove the pizza from the oven and let it cool for a few minutes before slicing. Enjoy the hearty and savory taste of Meat Lovers pizza.",

                    //Category
                    DishCategory.Pizza,

                    //Rating
                    4.9f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Spinach and Feta Pizza",

                    //Ingredients
                    "1 pizza dough\r\n"+
                    "1 cup tomato sauce\r\n"+
                    "2 cups shredded mozzarella cheese\r\n"+
                    "2 cups fresh spinach, chopped\r\n"+
                    "1/2 cup feta cheese, crumbled\r\n"+
                    "1 tsp dried oregano",


                    //Recipe
                     "Preheat your oven to 475°F (245°C). Roll out the pizza dough on a floured surface until it fits your pizza pan or baking sheet. Spread the tomato sauce evenly over the dough, leaving a small border for the crust. \r\n" +
                     "Sprinkle shredded mozzarella cheese over the tomato sauce, ensuring even coverage. This cheese layer will melt and create a creamy base for the spinach and feta. \r\n" +
                     "Evenly distribute the chopped fresh spinach over the cheese. Sprinkle crumbled feta cheese on top of the spinach. The feta will add a salty, tangy flavor to the pizza. \r\n" +
                     "Sprinkle dried oregano over the top to add an aromatic touch. Place the pizza in the oven. Bake for 12-15 minutes until the crust is golden and the cheese is melted and bubbly. The spinach should be wilted and the feta slightly browned. \r\n" +
                     "Remove the pizza from the oven and let it cool for a few minutes before slicing.Enjoy the fresh and tangy flavors of Spinach and Feta pizza.",

                    //Category
                    DishCategory.Pizza,

                    //Rating
                    4.6f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Buffalo Chicken Pizza",

                    //Ingredients
                    "1 pizza dough\r\n"+
                    "1/2 cup buffalo sauce\r\n"+
                    "2 cups shredded mozzarella cheese\r\n"+
                    "1 cup cooked chicken breast, shredded\r\n"+
                    "1/2 cup blue cheese crumbles\r\n"+
                    "1/4 cup chopped green onions",

                    //Recipe
                     "Preheat your oven to 475°F (245°C). Roll out the pizza dough on a floured surface until it fits your pizza pan or baking sheet. Spread buffalo sauce evenly over the dough, leaving a small border for the crust. \r\n" +
                     "Sprinkle shredded mozzarella cheese over the buffalo sauce, ensuring even coverage. This cheese layer will melt and blend with the buffalo sauce for a spicy, creamy base. \r\n" +
                     "Scatter the shredded cooked chicken breast over the cheese. The chicken will absorb the buffalo sauce flavor as it bakes. Add blue cheese crumbles on top of the chicken for a tangy kick. \r\n" +
                     "Bake the pizza for 12-15 minutes until the crust is golden and the cheese is melted and bubbly. The blue cheese should be slightly browned. \r\n" +
                     "Once out of the oven, sprinkle chopped green onions over the top for a fresh finish. Allow the pizza to cool for a couple of minutes before slicing. Enjoy the bold and spicy flavors of Buffalo Chicken pizza.",

                    //Category
                    DishCategory.Pizza,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                //Burger

                new DishData(
                    //Dish Name
                    "Classic Cheeseburger",

                    //Ingredients
                    "1 lb ground beef\r\n"+
                    "Salt and pepper to taste\r\n"+
                    "4 slices cheddar cheese\r\n"+
                    "4 burger buns\r\n"+
                    "Lettuce leaves\r\n"+
                    "Tomato slices\r\n"+
                    "Onion slices\r\n"+
                    "Pickles\r\n"+
                    "Ketchup\r\n"+
                    "Mustard",

                    //Recipe
                     "Start by preheating your grill or a large skillet over medium-high heat. Divide the ground beef into four equal portions and shape them into patties. Season each patty with salt and pepper on both sides. \r\n" +
                     "Place the patties on the grill or skillet and cook for about 4-5 minutes per side, or until they reach your desired level of doneness. In the last minute of cooking, place a slice of cheddar cheese on each patty and allow it to melt. \r\n" +
                     "While the patties are cooking, lightly toast the burger buns on the grill or in a toaster. This step adds a nice crunch to the buns and helps prevent them from getting soggy. \r\n" +
                     "Assemble the burgers by placing a lettuce leaf on the bottom half of each bun. Top with a cooked patty, followed by tomato slices, onion slices, and pickles. \r\n" +
                     "Spread ketchup and mustard on the top half of the buns, then place them on top of the assembled burgers. Serve immediately and enjoy the classic taste of a cheeseburger.",

                    //Category
                    DishCategory.Burger,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Bacon Cheeseburger",

                    //Ingredients
                    "1 lb ground beef\r\n"+
                    "Salt and pepper to taste\r\n"+
                    "4 slices cheddar cheese\r\n"+
                    "4 burger buns\r\n"+
                    "8 slices cooked bacon\r\n"+
                    "Lettuce leaves\r\n"+
                    "Tomato slices\r\n"+
                    "Onion slices\r\n"+
                    "BBQ sauce",

                    //Recipe
                     "Preheat your grill or a large skillet over medium-high heat. Divide the ground beef into four equal portions and shape them into patties. Season each patty with salt and pepper on both sides. \r\n" +
                     "Place the patties on the grill or skillet and cook for about 4-5 minutes per side, or until they reach your desired level of doneness. In the last minute of cooking, place a slice of cheddar cheese on each patty and allow it to melt. \r\n" +
                     "While the patties are cooking, lightly toast the burger buns on the grill or in a toaster. This step adds a nice crunch to the buns and helps prevent them from getting soggy. \r\n" +
                     "Assemble the burgers by placing a lettuce leaf on the bottom half of each bun. Top with a cooked patty, followed by two slices of cooked bacon, tomato slices, and onion slices. \r\n" +
                     "Drizzle BBQ sauce over the top, then place the top half of the buns on the assembled burgers. Serve immediately and enjoy the smoky, savory taste of a bacon cheeseburger.",

                    //Category
                    DishCategory.Burger,

                    //Rating
                    4.9f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Mushroom Swiss Burger",

                    //Ingredients
                    "1 lb ground beef\r\n"+
                    "Salt and pepper to taste\r\n"+
                    "4 slices Swiss cheese\r\n"+
                    "4 burger buns\r\n"+
                    "1 cup mushrooms, sliced\r\n"+
                    "2 tbsp butter\r\n"+
                    "Lettuce leaves\r\n"+
                    "Garlic aioli",

                    //Recipe
                     "Begin by preheating your grill or a large skillet over medium-high heat. Divide the ground beef into four equal portions and shape them into patties. Season each patty with salt and pepper on both sides. \r\n" +
                     "Place the patties on the grill or skillet and cook for about 4-5 minutes per side, or until they reach your desired level of doneness. In the last minute of cooking, place a slice of Swiss cheese on each patty and allow it to melt. \r\n" +
                     "While the patties are cooking, melt the butter in a separate skillet over medium heat. Add the sliced mushrooms and cook until they are soft and browned, about 5-7 minutes. \r\n" +
                     "Lightly toast the burger buns on the grill or in a toaster. This step adds a nice crunch to the buns and helps prevent them from getting soggy. \r\n" +
                     "Assemble the burgers by spreading garlic aioli on the bottom half of each bun. Top with a lettuce leaf, a cooked patty, and a generous portion of sautéed mushrooms. \r\n" +
                     "Place the top half of the buns on the assembled burgers. Serve immediately and enjoy the rich, savory flavors of a mushroom Swiss burger.",

                    //Category
                    DishCategory.Burger,

                    //Rating
                    4.7f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "BBQ Bacon Burger",

                    //Ingredients
                    "1 lb ground beef\r\n"+
                    "Salt and pepper to taste\r\n"+
                    "4 slices cheddar cheese\r\n"+
                    "4 burger buns\r\n"+
                    "8 slices cooked bacon\r\n"+
                    "1/2 cup BBQ sauce\r\n"+
                    "Lettuce leaves\r\n"+
                    "Tomato slices\r\n"+
                    "Onion rings",

                    //Recipe
                     "Preheat your grill or a large skillet over medium-high heat. Divide the ground beef into four equal portions and shape them into patties. Season each patty with salt and pepper on both sides. \r\n" +
                     "Place the patties on the grill or skillet and cook for about 4-5 minutes per side, or until they reach your desired level of doneness. In the last minute of cooking, place a slice of cheddar cheese on each patty and allow it to melt. \r\n" +
                     "While the patties are cooking, lightly toast the burger buns on the grill or in a toaster. This step adds a nice crunch to the buns and helps prevent them from getting soggy. \r\n" +
                     "Assemble the burgers by placing a lettuce leaf on the bottom half of each bun. Top with a cooked patty, followed by two slices of cooked bacon, tomato slices, and a couple of onion rings. \r\n" +
                     "Drizzle BBQ sauce over the top, then place the top half of the buns on the assembled burgers. Serve immediately and enjoy the smoky, tangy flavors of a BBQ bacon burger.",

                    //Category
                    DishCategory.Burger,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Avocado Burger",

                    //Ingredients
                    "1 lb ground beef\r\n"+
                    "Salt and pepper to taste\r\n"+
                    "4 slices pepper jack cheese\r\n"+
                    "4 burger buns\r\n"+
                    "1 avocado, sliced\r\n"+
                    "Lettuce leaves\r\n"+
                    "Tomato slices\r\n"+
                    "Red onion slices\r\n"+
                    "Chipotle mayo",


                    //Recipe
                     "Preheat your grill or a large skillet over medium-high heat. Divide the ground beef into four equal portions and shape them into patties. Season each patty with salt and pepper on both sides. \r\n" +
                     "Place the patties on the grill or skillet and cook for about 4-5 minutes per side, or until they reach your desired level of doneness. In the last minute of cooking, place a slice of pepper jack cheese on each patty and allow it to melt. \r\n" +
                     "While the patties are cooking, lightly toast the burger buns on the grill or in a toaster. This step adds a nice crunch to the buns and helps prevent them from getting soggy. \r\n" +
                     "Assemble the burgers by spreading chipotle mayo on the bottom half of each bun. Top with a lettuce leaf, a cooked patty, avocado slices, tomato slices, and red onion slices. \r\n" +
                     "Place the top half of the buns on the assembled burgers. Serve immediately and enjoy the creamy, spicy flavors of an avocado burger.",

                    //Category
                    DishCategory.Burger,

                    //Rating
                    4.6f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Blue Cheese Burger",

                    //Ingredients
                    "1 lb ground beef\r\n"+
                    "Salt and pepper to taste\r\n"+
                    "4 burger buns\r\n"+
                    "4 oz blue cheese, crumbled\r\n"+
                    "1 avocado, sliced\r\n"+
                    "Lettuce leaves\r\n"+
                    "Tomato slices\r\n"+
                    "Balsamic glaze",

                    //Recipe
                     "Preheat your grill or a large skillet over medium-high heat. Divide the ground beef into four equal portions and shape them into patties. Season each patty with salt and pepper on both sides. \r\n" +
                     "Place the patties on the grill or skillet and cook for about 4-5 minutes per side, or until they reach your desired level of doneness. In the last minute of cooking, add the crumbled blue cheese on top of each patty and allow it to melt slightly. \r\n" +
                     "While the patties are cooking, lightly toast the burger buns on the grill or in a toaster. This step adds a nice crunch to the buns and helps prevent them from getting soggy. \r\n" +
                     "Assemble the burgers by placing a lettuce leaf on the bottom half of each bun. Top with a cooked patty, tomato slices, and red onion slices. \r\n" +
                     "Drizzle balsamic glaze over the top, then place the top half of the buns on the assembled burgers. Serve immediately and enjoy the tangy, bold flavors of a blue cheese burger.",

                    //Category
                    DishCategory.Burger,

                    //Rating
                    4.5f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Chicken Burger",

                    //Ingredients
                    "1 lb ground chicken\r\n"+
                    "Salt and pepper to taste\r\n"+
                    "4 slices provolone cheese\r\n"+
                    "4 burger buns\r\n"+
                    "Lettuce leaves\r\n"+
                    "Tomato slices\r\n"+
                    "Red onion slices\r\n"+
                    "Avocado mayo",

                    //Recipe
                     "Preheat your grill or a large skillet over medium-high heat. Divide the ground chicken into four equal portions and shape them into patties. Season each patty with salt and pepper on both sides. \r\n" +
                     "Place the patties on the grill or skillet and cook for about 4-5 minutes per side, or until they reach your desired level of doneness. In the last minute of cooking, place a slice of provolone cheese on each patty and allow it to melt. \r\n" +
                     "While the patties are cooking, lightly toast the burger buns on the grill or in a toaster. This step adds a nice crunch to the buns and helps prevent them from getting soggy. \r\n" +
                     "Assemble the burgers by spreading avocado mayo on the bottom half of each bun. Top with a lettuce leaf, a cooked patty, tomato slices, and red onion slices. \r\n" +
                     "Place the top half of the buns on the assembled burgers. Serve immediately and enjoy the fresh, light flavors of a chicken burger.",

                    //Category
                    DishCategory.Burger,

                    //Rating
                    4.7f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Veggie Burger",

                    //Ingredients
                    "4 veggie burger patties\r\n"+
                    "Salt and pepper to taste\r\n"+
                    "4 slices cheddar cheese\r\n"+
                    "4 burger buns\r\n"+
                    "Lettuce leaves\r\n"+
                    "Tomato slices\r\n"+
                    "Red onion slices\r\n"+
                    "Avocado slices\r\n"+
                    "Hummus",

                    //Recipe
                     "Preheat your grill or a large skillet over medium-high heat. Season the veggie burger patties with salt and pepper on both sides. \r\n" +
                     "Place the patties on the grill or skillet and cook for about 4-5 minutes per side, or until they are heated through and have a nice sear. In the last minute of cooking, place a slice of cheddar cheese on each patty and allow it to melt. \r\n" +
                     "While the patties are cooking, lightly toast the burger buns on the grill or in a toaster. This step adds a nice crunch to the buns and helps prevent them from getting soggy. \r\n" +
                     "Assemble the burgers by spreading hummus on the bottom half of each bun. Top with a lettuce leaf, a cooked veggie patty, tomato slices, red onion slices, and avocado slices. \r\n" +
                     "Place the top half of the buns on the assembled burgers. Serve immediately and enjoy the fresh, nutritious flavors of a veggie burger.",

                    //Category
                    DishCategory.Burger,

                    //Rating
                    4.6f,

                    //Is Liked
                    false
                    ),

                //Roll

                new DishData(
                    //Dish Name
                    "California Roll",

                    //Ingredients
                    "1 sheet nori seaweed\r\n"+
                    "1/2 cup sushi rice, cooked and seasoned\r\n"+
                    "1/4 avocado, thinly sliced\r\n"+
                    "1/4 cucumber, julienne cut\r\n"+
                    "1/4 cup imitation crab meat, shredded\r\n"+
                    "Soy sauce, for dipping",

                    //Recipe
                     "Place a bamboo sushi mat on a clean surface. Lay a sheet of nori seaweed, shiny side down, on the mat. \r\n" +
                     "Spread an even layer of seasoned sushi rice over the nori, leaving about 1 inch uncovered at the top edge. \r\n" +
                     "Arrange avocado slices, cucumber strips, and shredded imitation crab meat evenly across the center of the rice. \r\n" +
                     "Using the bamboo mat, carefully roll the nori and rice over the filling, applying gentle pressure to shape the roll. \r\n" +
                     "Once rolled, seal the edge with a little water. Slice the roll into bite-sized pieces with a sharp knife. Serve with soy sauce for dipping and enjoy the fresh and flavorful California Roll.",

                    //Category
                    DishCategory.Roll,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Spicy Tuna Roll",

                    //Ingredients
                    "1 sheet nori seaweed\r\n"+
                    "1/2 cup sushi rice, cooked and seasoned\r\n"+
                    "1/4 lb sushi-grade tuna, thinly sliced\r\n"+
                    "1 tbsp spicy mayo\r\n"+
                    "1/4 cucumber, julienne cut\r\n"+
                    "Soy sauce, for dipping",

                    //Recipe
                     "Place a bamboo sushi mat on a clean surface. Lay a sheet of nori seaweed, shiny side down, on the mat. \r\n" +
                     "Spread an even layer of seasoned sushi rice over the nori, leaving about 1 inch uncovered at the top edge. \r\n" +
                     "Arrange thinly sliced tuna and cucumber strips evenly across the center of the rice. Drizzle spicy mayo over the tuna. \r\n" +
                     "Using the bamboo mat, carefully roll the nori and rice over the filling, applying gentle pressure to shape the roll. \r\n" +
                     "Once rolled, seal the edge with a little water. Slice the roll into bite-sized pieces with a sharp knife. Serve with soy sauce for dipping and enjoy the spicy kick of the Spicy Tuna Roll.",

                    //Category
                    DishCategory.Roll,

                    //Rating
                    4.7f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Philadelphia Roll",

                    //Ingredients
                    "1 sheet nori seaweed\r\n"+
                    "1/2 cup sushi rice, cooked and seasoned\r\n"+
                    "4 oz cream cheese, softened\r\n"+
                    "1/4 lb smoked salmon, thinly sliced\r\n"+
                    "1/4 cucumber, julienne cut\r\n"+
                    "Soy sauce, for dipping",

                    //Recipe
                     "Place a bamboo sushi mat on a clean surface. Lay a sheet of nori seaweed, shiny side down, on the mat. \r\n" +
                     "Spread an even layer of seasoned sushi rice over the nori, leaving about 1 inch uncovered at the top edge. \r\n" +
                     "Spread softened cream cheese evenly over the rice. Arrange thinly sliced smoked salmon and cucumber strips across the center of the rice. \r\n" +
                     "Using the bamboo mat, carefully roll the nori and rice over the filling, applying gentle pressure to shape the roll. \r\n" +
                     "Once rolled, seal the edge with a little water. Slice the roll into bite-sized pieces with a sharp knife. Serve with soy sauce for dipping and enjoy the creamy and savory flavors of the Philadelphia Roll.",

                    //Category
                    DishCategory.Roll,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Tempura Roll",

                    //Ingredients
                    "1 sheet nori seaweed\r\n"+
                    "1/2 cup sushi rice, cooked and seasoned\r\n"+
                    "4-6 pieces shrimp tempura\r\n"+
                    "1/4 avocado, thinly sliced\r\n"+
                    "1/4 cucumber, julienne cut\r\n"+
                    "Soy sauce, for dipping",

                    //Recipe
                     "Place a bamboo sushi mat on a clean surface. Lay a sheet of nori seaweed, shiny side down, on the mat. \r\n" +
                     "Spread an even layer of seasoned sushi rice over the nori, leaving about 1 inch uncovered at the top edge. \r\n" +
                     "Arrange shrimp tempura, avocado slices, and cucumber strips evenly across the center of the rice. \r\n" +
                     "Using the bamboo mat, carefully roll the nori and rice over the filling, applying gentle pressure to shape the roll. \r\n" +
                     "Once rolled, seal the edge with a little water. Slice the roll into bite-sized pieces with a sharp knife. Serve with soy sauce for dipping and enjoy the crunchy texture of the Tempura Roll.",

                    //Category
                    DishCategory.Roll,

                    //Rating
                    4.7f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Vegetable Roll",

                    //Ingredients
                    "1 sheet nori seaweed\r\n"+
                    "1/2 cup sushi rice, cooked and seasoned\r\n"+
                    "1/4 avocado, thinly sliced\r\n"+
                    "1/4 cucumber, julienne cut\r\n"+
                    "1/4 carrot, julienne cut\r\n"+
                    "Soy sauce, for dipping",

                    //Recipe
                     "Place a bamboo sushi mat on a clean surface. Lay a sheet of nori seaweed, shiny side down, on the mat. \r\n" +
                     "Spread an even layer of seasoned sushi rice over the nori, leaving about 1 inch uncovered at the top edge. \r\n" +
                     "Arrange avocado slices, cucumber strips, and carrot strips evenly across the center of the rice. \r\n" +
                     "Using the bamboo mat, carefully roll the nori and rice over the filling, applying gentle pressure to shape the roll. \r\n" +
                     "Once rolled, seal the edge with a little water. Slice the roll into bite-sized pieces with a sharp knife. Serve with soy sauce for dipping and enjoy the fresh and crunchy Vegetable Roll.",

                    //Category
                    DishCategory.Roll,

                    //Rating
                    4.6f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Dragon Roll",

                    //Ingredients
                    "1 sheet nori seaweed\r\n"+
                    "1/2 cup sushi rice, cooked and seasoned\r\n"+
                    "4-6 pieces shrimp tempura\r\n"+
                    "1/4 avocado, thinly sliced\r\n"+
                    "Eel sauce\r\n"+
                    "Sesame seeds\r\n"+
                    "Soy sauce, for dipping",

                    //Recipe
                     "Place a bamboo sushi mat on a clean surface. Lay a sheet of nori seaweed, shiny side down, on the mat. \r\n" +
                     "Spread an even layer of seasoned sushi rice over the nori, leaving about 1 inch uncovered at the top edge. \r\n" +
                     "Arrange shrimp tempura, avocado slices, and drizzle with eel sauce. Sprinkle sesame seeds evenly across the center of the rice. \r\n" +
                     "Using the bamboo mat, carefully roll the nori and rice over the filling, applying gentle pressure to shape the roll. \r\n" +
                     "Once rolled, seal the edge with a little water. Slice the roll into bite-sized pieces with a sharp knife. Serve with soy sauce for dipping and enjoy the delicious Dragon Roll.",

                    //Category
                    DishCategory.Roll,

                    //Rating
                    4.9f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Rainbow Roll",

                    //Ingredients
                    "1 sheet nori seaweed\r\n"+
                    "1/2 cup sushi rice, cooked and seasoned\r\n"+
                    "4-6 pieces sashimi (tuna, salmon, and avocado slices)\r\n"+
                    "Cucumber, julienne cut\r\n"+
                    "Soy sauce, for dipping",

                    //Recipe
                     "Place a bamboo sushi mat on a clean surface. Lay a sheet of nori seaweed, shiny side down, on the mat. \r\n" +
                     "Spread an even layer of seasoned sushi rice over the nori, leaving about 1 inch uncovered at the top edge. \r\n" +
                     "Arrange slices of sashimi (tuna, salmon) and avocado slices evenly across the center of the rice. Add cucumber strips. \r\n" +
                     "Using the bamboo mat, carefully roll the nori and rice over the filling, applying gentle pressure to shape the roll. \r\n" +
                     "Once rolled, seal the edge with a little water. Slice the roll into bite-sized pieces with a sharp knife. Serve with soy sauce for dipping and enjoy the vibrant colors and flavors of the Rainbow Roll.",

                    //Category
                    DishCategory.Roll,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Spider Roll",

                    //Ingredients
                    "1 sheet nori seaweed\r\n"+
                    "1/2 cup sushi rice, cooked and seasoned\r\n"+
                    "Soft-shell crab tempura\r\n"+
                    "1/4 avocado, thinly sliced\r\n"+
                    "Cucumber, julienne cut\r\n"+
                    "Soy sauce, for dipping",

                    //Recipe
                     "Place a bamboo sushi mat on a clean surface. Lay a sheet of nori seaweed, shiny side down, on the mat. \r\n" +
                     "Spread an even layer of seasoned sushi rice over the nori, leaving about 1 inch uncovered at the top edge. \r\n" +
                     "Arrange soft-shell crab tempura, avocado slices, and cucumber strips evenly across the center of the rice. \r\n" +
                     "Using the bamboo mat, carefully roll the nori and rice over the filling, applying gentle pressure to shape the roll. \r\n" +
                     "Once rolled, seal the edge with a little water. Slice the roll into bite-sized pieces with a sharp knife. Serve with soy sauce for dipping and enjoy the crunchy texture of the Spider Roll.",

                    //Category
                    DishCategory.Roll,

                    //Rating
                    4.7f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Caterpillar Roll",

                    //Ingredients
                    "1 sheet nori seaweed\r\n"+
                    "1/2 cup sushi rice, cooked and seasoned\r\n"+
                    "Eel, thinly sliced\r\n"+
                    "1/4 avocado, thinly sliced\r\n"+
                    "Eel sauce\r\n"+
                    "Sesame seeds\r\n"+
                    "Soy sauce, for dipping",

                    //Recipe
                     "Place a bamboo sushi mat on a clean surface. Lay a sheet of nori seaweed, shiny side down, on the mat. \r\n" +
                     "Spread an even layer of seasoned sushi rice over the nori, leaving about 1 inch uncovered at the top edge. \r\n" +
                     "Arrange thinly sliced eel and avocado slices evenly across the center of the rice. Drizzle with eel sauce and sprinkle sesame seeds over the fillings. \r\n" +
                     "Using the bamboo mat, carefully roll the nori and rice over the filling, applying gentle pressure to shape the roll. \r\n" +
                     "Once rolled, seal the edge with a little water. Slice the roll into bite-sized pieces with a sharp knife. Serve with soy sauce for dipping and enjoy the rich and savory Caterpillar Roll.",

                    //Category
                    DishCategory.Roll,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                //Shusi

                new DishData(
                    //Dish Name
                    "Nigiri Sushi",

                    //Ingredients
                    "Sushi rice\r\n"+
                    "Sashimi-grade fish (salmon, tuna, etc.)\r\n"+
                    "Wasabi paste\r\n"+
                    "Soy sauce",

                    //Recipe
                     "Prepare sushi rice according to package instructions. \r\n" +
                     "Take a small handful of rice and shape it into an oval-shaped mound. \r\n" +
                     "Slice sashimi-grade fish into thin pieces and place on top of each rice mound. \r\n" +
                     "Serve with a small amount of wasabi paste and soy sauce on the side. Enjoy the simplicity and freshness of Nigiri Sushi.",

                    //Category
                    DishCategory.Sushi,

                    //Rating
                    4.7f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Maki Sushi",

                    //Ingredients
                    "Sushi rice\r\n"+
                    "Nori seaweed sheets\r\n"+
                    "Assorted fillings (cucumber, avocado, fish, etc.)\r\n"+
                    "Soy sauce",

                    //Recipe
                     "Place a sheet of nori seaweed on a bamboo sushi mat. \r\n" +
                     "Spread an even layer of sushi rice over the nori, leaving about 1 inch uncovered at the top edge. \r\n" +
                     "Arrange assorted fillings across the center of the rice. \r\n" +
                     "Using the bamboo mat, carefully roll the nori and rice over the fillings, applying gentle pressure to shape the roll. \r\n" +
                     "Once rolled, seal the edge with a little water. Slice the roll into bite-sized pieces with a sharp knife. Serve with soy sauce for dipping. Enjoy the variety and flavors of Maki Sushi.",

                    //Category
                    DishCategory.Sushi,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Temaki (Hand Roll)",

                    //Ingredients
                    "Sushi rice\r\n"+
                    "Nori seaweed sheets\r\n"+
                    "Assorted fillings (fish, avocado, cucumber, etc.)\r\n"+
                    "Soy sauce",

                    //Recipe
                     "Cut nori seaweed sheets in half to create triangles. \r\n" +
                     "Place a small amount of sushi rice on one corner of the nori triangle. \r\n" +
                     "Add assorted fillings over the rice. \r\n" +
                     "Roll the nori into a cone shape, enclosing the fillings. \r\n" +
                     "Serve immediately with soy sauce for dipping. Enjoy the simplicity and freshness of Temaki Sushi.",

                    //Category
                    DishCategory.Sushi,

                    //Rating
                    4.7f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Sashimi",

                    //Ingredients
                    "Sashimi-grade fish (salmon, tuna, etc.)\r\n"+
                    "Wasabi paste\r\n"+
                    "Soy sauce\r\n"+
                    "Pickled ginger",

                    //Recipe
                     "Slice sashimi-grade fish into thin pieces. \r\n" +
                     "Serve the sliced fish on a plate with wasabi paste and soy sauce on the side. \r\n" +
                     "Garnish with pickled ginger. Enjoy the pure and delicate flavors of Sashimi.",

                    //Category
                    DishCategory.Sushi,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Chirashi Sushi",

                    //Ingredients
                    "Sushi rice\r\n"+
                    "Assorted sashimi-grade fish (salmon, tuna, etc.)\r\n"+
                    "Assorted vegetables (cucumber, avocado, etc.)\r\n"+
                    "Pickled ginger\r\n"+
                    "Soy sauce",

                    //Recipe
                    "Prepare sushi rice according to package instructions. \r\n" +
                    "Spread an even layer of sushi rice in a bowl or serving dish. \r\n" +
                    "Arrange assorted sashimi-grade fish and vegetables on top of the rice. \r\n" +
                    "Serve with pickled ginger and soy sauce on the side. Enjoy the colorful and nutritious Chirashi Sushi.",

                    //Category
                    DishCategory.Sushi,

                    //Rating
                    4.9f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Dragon Rolls",

                    //Ingredients
                    "Sushi rice\r\n"+
                    "Nori seaweed sheets\r\n"+
                    "Shrimp tempura\r\n"+
                    "Avocado, thinly sliced\r\n"+
                    "Unagi (eel)\r\n"+
                    "Eel sauce\r\n"+
                    "Soy sauce",

                    //Recipe
                    "Prepare sushi rice according to package instructions. \r\n" +
                    "Place a sheet of nori seaweed on a bamboo sushi mat. \r\n" +
                    "Spread an even layer of sushi rice over the nori, leaving about 1 inch uncovered at the top edge. \r\n" +
                    "Arrange shrimp tempura, avocado slices, and unagi (eel) across the center of the rice. Drizzle with eel sauce. \r\n" +
                    "Using the bamboo mat, carefully roll the nori and rice over the fillings, applying gentle pressure to shape the roll. \r\n" +
                    "Once rolled, seal the edge with a little water. Slice the roll into bite-sized pieces with a sharp knife. Serve with soy sauce for dipping. Enjoy the flavorful and filling Dragon Roll.",

                    //Category
                    DishCategory.Sushi,

                    //Rating
                    4.9f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Rainbow Rolls",

                    //Ingredients
                    "Sushi rice\r\n"+
                    "Nori seaweed sheets\r\n"+
                    "Assorted sashimi (tuna, salmon, etc.)\r\n"+
                    "Avocado, thinly sliced\r\n"+
                    "Cucumber, julienne cut\r\n"+
                    "Soy sauce",

                    //Recipe
                    "Prepare sushi rice according to package instructions. \r\n" +
                    "Place a sheet of nori seaweed on a bamboo sushi mat. \r\n" +
                    "Spread an even layer of sushi rice over the nori, leaving about 1 inch uncovered at the top edge. \r\n" +
                    "Arrange assorted sashimi, avocado slices, and cucumber strips across the center of the rice. \r\n" +
                    "Using the bamboo mat, carefully roll the nori and rice over the fillings, applying gentle pressure to shape the roll. \r\n" +
                    "Once rolled, seal the edge with a little water. Slice the roll into bite-sized pieces with a sharp knife. Serve with soy sauce for dipping. Enjoy the vibrant colors and flavors of the Rainbow Roll.",

                    //Category
                    DishCategory.Sushi,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Spider Rolls",

                    //Ingredients
                    "Sushi rice\r\n"+
                    "Nori seaweed sheets\r\n"+
                    "Soft-shell crab tempura\r\n"+
                    "Avocado, thinly sliced\r\n"+
                    "Cucumber, julienne cut\r\n"+
                    "Soy sauce",

                    //Recipe
                    "Prepare sushi rice according to package instructions. \r\n" +
                    "Place a sheet of nori seaweed on a bamboo sushi mat. \r\n" +
                    "Spread an even layer of sushi rice over the nori, leaving about 1 inch uncovered at the top edge. \r\n" +
                    "Arrange soft-shell crab tempura, avocado slices, and cucumber strips across the center of the rice. \r\n" +
                    "Using the bamboo mat, carefully roll the nori and rice over the fillings, applying gentle pressure to shape the roll. \r\n" +
                    "Once rolled, seal the edge with a little water. Slice the roll into bite-sized pieces with a sharp knife. Serve with soy sauce for dipping. Enjoy the crunchy texture and unique flavor of the Spider Roll.",

                    //Category
                    DishCategory.Sushi,

                    //Rating
                    4.7f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Caterpillar Rolls",

                    //Ingredients
                    "Sushi rice\r\n"+
                    "Nori seaweed sheets\r\n"+
                    "Eel (unagi), thinly sliced\r\n"+
                    "Avocado, thinly sliced\r\n"+
                    "Eel sauce\r\n"+
                    "Soy sauce",

                    //Recipe
                    "Prepare sushi rice according to package instructions. \r\n" +
                    "Place a sheet of nori seaweed on a bamboo sushi mat. \r\n" +
                    "Spread an even layer of sushi rice over the nori, leaving about 1 inch uncovered at the top edge. \r\n" +
                    "Arrange thinly sliced eel (unagi) and avocado slices across the center of the rice. Drizzle with eel sauce. \r\n" +
                    "Using the bamboo mat, carefully roll the nori and rice over the fillings, applying gentle pressure to shape the roll. \r\n" +
                    "Once rolled, seal the edge with a little water. Slice the roll into bite-sized pieces with a sharp knife. Serve with soy sauce for dipping. Enjoy the rich and savory Caterpillar Roll.",

                    //Category
                    DishCategory.Sushi,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                //Sandwich

                new DishData(
                    //Dish Name
                    "Classic BLT Sandwich",

                    //Ingredients
                    "2 slices of bread (white, wheat, or sourdough)\r\n"+
                    "3-4 strips of bacon, cooked crispy\r\n"+
                    "Lettuce leaves\r\n"+
                    "Tomato slices\r\n"+
                    "Mayonnaise",

                    //Recipe
                    "Toast the bread slices until golden brown. \r\n" +
                    "Spread mayonnaise on one side of each slice. \r\n" +
                    "Layer lettuce leaves, tomato slices, and crispy bacon on one slice of bread. \r\n" +
                    "Top with the other slice of bread, mayo side down. \r\n" +
                    "Slice the sandwich diagonally and serve immediately. Enjoy the classic flavors of the BLT Sandwich.",

                    //Category
                    DishCategory.Sandwich,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Grilled Cheese Sandwich",

                    //Ingredients
                    "2 slices of bread (white, wheat, or sourdough)\r\n"+
                    "Butter\r\n"+
                    "Cheddar cheese slices",

                    //Recipe
                    "Heat a skillet over medium heat. \r\n" +
                    "Butter one side of each slice of bread. \r\n" +
                    "Place one slice of bread, buttered side down, on the skillet. \r\n" +
                    "Layer with cheddar cheese slices and top with the other slice of bread, buttered side up. \r\n" +
                    "Cook until golden brown on both sides and the cheese is melted. \r\n" +
                    "Slice diagonally and serve hot. Enjoy the gooey goodness of the Grilled Cheese Sandwich.",

                    //Category
                    DishCategory.Sandwich,

                    //Rating
                    4.7f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Club Sandwich",

                    //Ingredients
                    "3 slices of bread (white, wheat, or sourdough)\r\n"+
                    "Mayonnaise\r\n"+
                    "Lettuce leaves\r\n"+
                    "Tomato slices\r\n"+
                    "Cooked chicken breast slices\r\n"+
                    "Bacon strips, cooked crispy\r\n"+
                    "Sliced cheese (cheddar or Swiss)",

                    //Recipe
                    "Toast three slices of bread until golden brown. \r\n" +
                    "Spread mayonnaise on one side of each toasted slice. \r\n" +
                    "Layer lettuce leaves, tomato slices, cooked chicken breast slices, crispy bacon strips, and sliced cheese on one slice of bread. \r\n" +
                    "Top with the second slice of bread, mayo side down, and repeat the layering. \r\n" +
                    "Finish with the third slice of bread, mayo side down. Secure with toothpicks and slice diagonally. Serve immediately and enjoy the hearty Club Sandwich.",

                    //Category
                    DishCategory.Sandwich,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Caprese Sandwich",

                    //Ingredients
                    "2 slices of ciabatta bread\r\n"+
                    "Fresh mozzarella cheese slices\r\n"+
                    "Tomato slices\r\n"+
                    "Fresh basil leaves\r\n"+
                    "Balsamic glaze\r\n"+
                    "Olive oil",

                    //Recipe
                    "Drizzle olive oil on one side of each slice of ciabatta bread. \r\n" +
                    "Layer fresh mozzarella cheese slices, tomato slices, and fresh basil leaves on one slice of bread. \r\n" +
                    "Drizzle with balsamic glaze. \r\n" +
                    "Top with the other slice of bread, olive oil side down. \r\n" +
                    "Slice diagonally and serve immediately. Enjoy the flavors of Italy in the Caprese Sandwich.",

                    //Category
                    DishCategory.Sandwich,

                    //Rating
                    4.7f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Chicken Avocado Sandwich",

                    //Ingredients
                    "2 slices of multigrain bread\r\n"+
                    "Grilled chicken breast slices\r\n"+
                    "Avocado, sliced\r\n"+
                    "Lettuce leaves\r\n"+
                    "Tomato slices\r\n"+
                    "Mayonnaise",

                    //Recipe
                    "Toast the slices of multigrain bread until lightly golden. \r\n" +
                    "Spread mayonnaise on one side of each slice. \r\n" +
                    "Layer grilled chicken breast slices, avocado slices, lettuce leaves, and tomato slices on one slice of bread. \r\n" +
                    "Top with the other slice of bread, mayo side down. \r\n" +
                    "Slice diagonally and serve immediately. Enjoy the fresh and satisfying Chicken Avocado Sandwich.",

                    //Category
                    DishCategory.Sandwich,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Turkey and Swiss Sandwich",

                    //Ingredients
                    "2 slices of whole wheat bread\r\n"+
                    "Sliced turkey breast\r\n"+
                    "Swiss cheese slices\r\n"+
                    "Lettuce leaves\r\n"+
                    "Tomato slices\r\n"+
                    "Dijon mustard",

                    //Recipe
                    "Spread Dijon mustard on one side of each slice of whole wheat bread. \r\n" +
                    "Layer sliced turkey breast, Swiss cheese slices, lettuce leaves, and tomato slices on one slice of bread. \r\n" +
                    "Top with the other slice of bread, mustard side down. \r\n" +
                    "Slice diagonally and serve immediately. Enjoy the savory flavors of the Turkey and Swiss Sandwich.",

                    //Category
                    DishCategory.Sandwich,

                    //Rating
                    4.7f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Egg Salad Sandwich",

                    //Ingredients
                    "2 slices of sandwich bread (white or wheat)\r\n"+
                    "Hard-boiled eggs, chopped\r\n"+
                    "Mayonnaise\r\n"+
                    "Dijon mustard\r\n"+
                    "Chopped celery\r\n"+
                    "Lettuce leaves",

                    //Recipe
                    "In a bowl, mix chopped hard-boiled eggs, mayonnaise, Dijon mustard, and chopped celery until well combined. \r\n" +
                    "Spread the egg salad mixture evenly on one slice of sandwich bread. \r\n" +
                    "Top with lettuce leaves and the other slice of bread. \r\n" +
                    "Slice diagonally and serve immediately. Enjoy the creamy and satisfying Egg Salad Sandwich.",

                    //Category
                    DishCategory.Sandwich,

                    //Rating
                    4.6f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Tuna Salad Sandwich",

                    //Ingredients
                    "2 slices of whole wheat bread\r\n"+
                    "Canned tuna, drained\r\n"+
                    "Mayonnaise\r\n"+
                    "Dijon mustard\r\n"+
                    "Chopped celery\r\n"+
                    "Lettuce leaves",

                    //Recipe
                    "In a bowl, mix canned tuna, mayonnaise, Dijon mustard, and chopped celery until well combined. \r\n" +
                    "Spread the tuna salad mixture evenly on one slice of whole wheat bread. \r\n" +
                    "Top with lettuce leaves and the other slice of bread. \r\n" +
                    "Slice diagonally and serve immediately. Enjoy the light and flavorful Tuna Salad Sandwich.",

                    //Category
                    DishCategory.Sandwich,

                    //Rating
                    4.6f,

                    //Is Liked
                    false
                    ),

                //Meat

                new DishData(
                    //Dish Name
                    "Steak",

                    //Ingredients
                    "1 steak (ribeye, sirloin, or filet mignon)\r\n"+
                    "Salt and pepper to taste\r\n"+
                    "1-2 tbsp olive oil\r\n"+
                    "Garlic cloves, optional for seasoning",

                    //Recipe
                    "Preheat a grill or skillet over high heat. \r\n" +
                    "Season the steak generously with salt and pepper on both sides. Rub with olive oil and optional minced garlic cloves for added flavor. \r\n" +
                    "Place the steak on the hot grill or skillet and cook to desired doneness, flipping once. \r\n" +
                    "For medium-rare, cook for about 3-4 minutes per side, depending on the thickness of the steak. Adjust cooking time for preferred doneness. \r\n" +
                    "Remove the steak from heat and let it rest for 5 minutes before slicing against the grain. Serve immediately, savoring the juicy and tender Steak.",

                    //Category
                    DishCategory.Meat,

                    //Rating
                    4.9f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "BBQ Ribs",

                    //Ingredients
                    "1 rack of pork ribs\r\n"+
                    "BBQ sauce of choice\r\n"+
                    "Salt and pepper to taste\r\n"+
                    "1-2 tbsp olive oil",

                    //Recipe
                    "Preheat your oven to 300°F (150°C). \r\n" +
                    "Season the rack of pork ribs with salt and pepper. Rub with olive oil. \r\n" +
                    "Wrap the ribs tightly in aluminum foil and place on a baking sheet. \r\n" +
                    "Bake for 2.5-3 hours until the ribs are tender. \r\n" +
                    "Remove from the oven, unwrap, and brush generously with BBQ sauce. \r\n" +
                    "Place under the broiler for a few minutes to caramelize the sauce. Serve warm.",

                    //Category
                    DishCategory.Meat,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Chicken Breast",

                    //Ingredients
                    "2 boneless, skinless chicken breasts\r\n"+
                    "Salt and pepper to taste\r\n"+
                    "1-2 tbsp olive oil\r\n"+
                    "1 tsp paprika\r\n"+
                    "1 tsp garlic powder",

                    //Recipe
                    "Preheat your oven to 375°F (190°C). \r\n" +
                    "Season the chicken breasts with salt, pepper, paprika, and garlic powder. \r\n" +
                    "Heat olive oil in a skillet over medium-high heat. \r\n" +
                    "Sear the chicken breasts for 2-3 minutes on each side until golden brown. \r\n" +
                    "Transfer the skillet to the oven and bake for 20-25 minutes until the chicken is cooked through. Serve warm.",

                    //Category
                    DishCategory.Meat,

                    //Rating
                    4.7f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Lamb Chops",

                    //Ingredients
                    "4 lamb chops\r\n"+
                    "Salt and pepper to taste\r\n"+
                    "2 tbsp olive oil\r\n"+
                    "1 tsp rosemary\r\n"+
                    "2 cloves garlic, minced",

                    //Recipe
                    "Preheat a grill or skillet over high heat. \r\n" +
                    "Season the lamb chops with salt, pepper, rosemary, and minced garlic. \r\n" +
                    "Rub with olive oil. \r\n" +
                    "Grill or sear the lamb chops for 3-4 minutes per side for medium-rare. \r\n" +
                    "Adjust cooking time for preferred doneness. Serve immediately.",

                    //Category
                    DishCategory.Meat,

                    //Rating
                    4.6f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Pork Chops",

                    //Ingredients
                    "2 bone-in pork chops\r\n"+
                    "Salt and pepper to taste\r\n"+
                    "1-2 tbsp olive oil\r\n"+
                    "1 tsp thyme\r\n"+
                    "1 clove garlic, minced",

                    //Recipe
                    "Preheat your oven to 375°F (190°C). \r\n" +
                    "Season the pork chops with salt, pepper, thyme, and minced garlic. \r\n" +
                    "Heat olive oil in a skillet over medium-high heat. \r\n" +
                    "Sear the pork chops for 3-4 minutes on each side until golden brown. \r\n" +
                    "Transfer the skillet to the oven and bake for 15-20 minutes until the pork is cooked through. Serve warm.",

                    //Category
                    DishCategory.Meat,

                    //Rating
                    4.5f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Turkey Breast",

                    //Ingredients
                    "1 turkey breast\r\n"+
                    "Salt and pepper to taste\r\n"+
                    "2 tbsp olive oil\r\n"+
                    "1 tsp sage\r\n"+
                    "1 tsp thyme\r\n"+
                    "2 cloves garlic, minced",

                    //Recipe
                    "Preheat your oven to 350°F (175°C). \r\n" +
                    "Season the turkey breast with salt, pepper, sage, thyme, and minced garlic. \r\n" +
                    "Rub with olive oil. \r\n" +
                    "Place the turkey breast in a roasting pan and roast for 1.5-2 hours, basting occasionally, until the turkey is cooked through. \r\n" +
                    "Let it rest for 10 minutes before slicing. Serve warm.",

                    //Category
                    DishCategory.Meat,

                    //Rating
                    4.4f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Duck Breast",

                    //Ingredients
                    "2 duck breasts\r\n"+
                    "Salt and pepper to taste\r\n"+
                    "1-2 tbsp olive oil\r\n"+
                    "1 tsp five-spice powder",

                    //Recipe
                    "Preheat your oven to 400°F (200°C). \r\n" +
                    "Score the skin of the duck breasts in a crosshatch pattern. Season with salt, pepper, and five-spice powder. \r\n" +
                    "Heat olive oil in a skillet over medium-high heat. \r\n" +
                    "Place the duck breasts skin-side down and sear for 5-7 minutes until the skin is crispy. \r\n" +
                    "Flip and cook for another 2-3 minutes. \r\n" +
                    "Transfer to the oven and bake for 5-7 minutes for medium-rare. Let it rest for 5 minutes before slicing. Serve warm.",

                    //Category
                    DishCategory.Meat,

                    //Rating
                    4.3f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Beef Brisket",

                    //Ingredients
                    "1 beef brisket (about 4-5 pounds)\r\n"+
                    "Salt and pepper to taste\r\n"+
                    "1-2 tbsp olive oil\r\n"+
                    "1 cup beef broth\r\n"+
                    "1 onion, sliced\r\n"+
                    "2 cloves garlic, minced",

                    //Recipe
                    "Preheat your oven to 325°F (160°C). \r\n" +
                    "Season the beef brisket with salt and pepper. \r\n" +
                    "Heat olive oil in a large skillet over medium-high heat. \r\n" +
                    "Sear the brisket on all sides until browned. \r\n" +
                    "Transfer to a roasting pan. Add beef broth, sliced onion, and minced garlic. \r\n" +
                    "Cover tightly with foil and roast for 3-4 hours until the brisket is tender. Let it rest for 10 minutes before slicing. Serve warm.",

                    //Category
                    DishCategory.Meat,

                    //Rating
                    4.2f,

                    //Is Liked
                    false
                    ),

                //Croissant

                new DishData(
                    //Dish Name
                    "Chocolate Croissant",

                    //Ingredients
                    "1 croissant\r\n"+
                    "Dark chocolate bar or chocolate chips",

                    //Recipe
                    "Preheat your oven to 350°F (175°C). \r\n" +
                    "Slice the croissant in half lengthwise, but not all the way through. \r\n" +
                    "Place dark chocolate pieces or chocolate chips inside the croissant. \r\n" +
                    "Bake in the preheated oven for about 5-7 minutes, or until the croissant is warm and the chocolate is melted. \r\n" +
                    "Remove from the oven and serve warm. Enjoy the indulgent Chocolate Croissant.",

                    //Category
                    DishCategory.Croissant,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Ham and Cheese Croissant",

                    //Ingredients
                    "1 croissant\r\n"+
                    "Sliced ham\r\n"+
                    "Sliced cheese (Swiss, cheddar, or your choice)",

                    //Recipe
                    "Preheat your oven to 350°F (175°C). \r\n" +
                    "Slice the croissant in half lengthwise. \r\n" +
                    "Layer sliced ham and cheese on one half of the croissant. \r\n" +
                    "Top with the other half of the croissant. \r\n" +
                    "Bake in the preheated oven for about 5-7 minutes, or until the croissant is warm and the cheese is melted. \r\n" +
                    "Remove from the oven and serve warm. Enjoy the savory Ham and Cheese Croissant.",

                    //Category
                    DishCategory.Croissant,

                    //Rating
                    4.7f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Almond Croissant",

                    //Ingredients
                    "1 croissant\r\n"+
                    "Almond paste or marzipan\r\n"+
                    "Sliced almonds\r\n"+
                    "Powdered sugar (optional)",

                    //Recipe
                    "Preheat your oven to 350°F (175°C). \r\n" +
                    "Slice the croissant in half lengthwise, but not all the way through. \r\n" +
                    "Spread almond paste or marzipan inside the croissant. \r\n" +
                    "Sprinkle sliced almonds on top. \r\n" +
                    "Bake in the preheated oven for about 5-7 minutes, or until the croissant is warm and the almonds are toasted. \r\n" +
                    "Optional: Dust with powdered sugar before serving. Enjoy the delightful Almond Croissant.",

                    //Category
                    DishCategory.Croissant,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Turkey and Cheese Croissant",

                    //Ingredients
                    "1 croissant\r\n"+
                    "Sliced turkey breast\r\n"+
                    "Sliced cheese (cheddar, Swiss, or your choice)",

                    //Recipe
                    "Preheat your oven to 350°F (175°C). \r\n" +
                    "Slice the croissant in half lengthwise. \r\n" +
                    "Layer sliced turkey breast and cheese on one half of the croissant. \r\n" +
                    "Top with the other half of the croissant. \r\n" +
                    "Bake in the preheated oven for about 5-7 minutes, or until the croissant is warm and the cheese is melted. \r\n" +
                    "Remove from the oven and serve warm. Enjoy the satisfying Turkey and Cheese Croissant.",

                    //Category
                    DishCategory.Croissant,

                    //Rating
                    4.7f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Spinach and Feta Croissant",

                    //Ingredients
                    "1 croissant\r\n"+
                    "Fresh spinach leaves\r\n"+
                    "Crumbled feta cheese",

                    //Recipe
                    "Preheat your oven to 350°F (175°C). \r\n" +
                    "Slice the croissant in half lengthwise. \r\n" +
                    "Layer fresh spinach leaves and crumbled feta cheese on one half of the croissant. \r\n" +
                    "Top with the other half of the croissant. \r\n" +
                    "Bake in the preheated oven for about 5-7 minutes, or until the croissant is warm and the cheese is melted. \r\n" +
                    "Remove from the oven and serve warm. Enjoy the flavorsome Spinach and Feta Croissant.",

                    //Category
                    DishCategory.Croissant,

                    //Rating
                    4.7f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Tomato and Mozzarella Croissant",

                    //Ingredients
                    "1 croissant\r\n"+
                    "Fresh mozzarella cheese slices\r\n"+
                    "Tomato slices\r\n"+
                    "Fresh basil leaves",

                    //Recipe
                    "Preheat your oven to 350°F (175°C). \r\n" +
                    "Slice the croissant in half lengthwise. \r\n" +
                    "Layer fresh mozzarella cheese slices, tomato slices, and fresh basil leaves on one half of the croissant. \r\n" +
                    "Top with the other half of the croissant. \r\n" +
                    "Bake in the preheated oven for about 5-7 minutes, or until the croissant is warm and the cheese is melted. \r\n" +
                    "Remove from the oven and serve warm. Enjoy the Mediterranean flavors of the Tomato and Mozzarella Croissant.",

                    //Category
                    DishCategory.Croissant,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Chicken Salad Croissant",

                    //Ingredients
                    "1 croissant\r\n"+
                    "Chicken salad (cooked chicken, mayonnaise, celery, etc.)\r\n"+
                    "Lettuce leaves",

                    //Recipe
                    "Slice the croissant in half lengthwise. \r\n" +
                    "Spread chicken salad on one half of the croissant. \r\n" +
                    "Top with lettuce leaves and the other half of the croissant. \r\n" +
                    "Serve immediately and enjoy the creamy and satisfying Chicken Salad Croissant.",

                    //Category
                    DishCategory.Croissant,

                    //Rating
                    4.6f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Pesto Chicken Croissant",

                    //Ingredients
                    "1 croissant\r\n"+
                    "Grilled chicken breast slices\r\n"+
                    "Pesto sauce\r\n"+
                    "Fresh spinach leaves\r\n"+
                    "Sliced tomatoes",

                    //Recipe
                    "Preheat your oven to 350°F (175°C). \r\n" +
                    "Slice the croissant in half lengthwise. \r\n" +
                    "Spread pesto sauce on one half of the croissant. \r\n" +
                    "Layer grilled chicken breast slices, fresh spinach leaves, and sliced tomatoes on top. \r\n" +
                    "Top with the other half of the croissant. \r\n" +
                    "Bake in the preheated oven for about 5-7 minutes, or until the croissant is warm. \r\n" +
                    "Remove from the oven and serve warm. Enjoy the vibrant flavors of the Pesto Chicken Croissant.",

                    //Category
                    DishCategory.Croissant,

                    //Rating
                    4.7f,

                    //Is Liked
                    false
                    ),

                //Cinnamonl

                new DishData(
                    //Dish Name
                    "Classic Cinnamon Roll",

                    //Ingredients
                    "1 tube refrigerated cinnamon roll dough with icing",

                    //Recipe
                    "Preheat your oven to 350°F (175°C). \r\n" +
                    "Unroll the tube of refrigerated cinnamon roll dough and separate the rolls. \r\n" +
                    "Place them on a baking sheet lined with parchment paper. \r\n" +
                    "Bake according to package instructions, usually 12-15 minutes, or until golden brown. \r\n" +
                    "Remove from the oven and drizzle with the included icing. \r\n" +
                    "Serve warm and enjoy the classic sweetness of the Cinnamon Roll.",

                    //Category
                    DishCategory.Cinnamonl,

                    //Rating
                    4.9f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Pecan Cinnamon Roll",

                    //Ingredients
                    "1 tube refrigerated cinnamon roll dough with icing\r\n"+
                    "Chopped pecans",

                    //Recipe
                    "Preheat your oven to 350°F (175°C). \r\n" +
                    "Unroll the tube of refrigerated cinnamon roll dough and separate the rolls. \r\n" +
                    "Place them on a baking sheet lined with parchment paper. \r\n" +
                    "Sprinkle chopped pecans over the rolls before baking. \r\n" +
                    "Bake according to package instructions, usually 12-15 minutes, or until golden brown. \r\n" +
                    "Remove from the oven and drizzle with the included icing. \r\n" +
                    "Serve warm and enjoy the delightful crunch of the Pecan Cinnamon Roll.",

                    //Category
                    DishCategory.Cinnamonl,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Cream Cheese Cinnamon Roll",

                    //Ingredients
                    "1 tube refrigerated cinnamon roll dough with icing\r\n"+
                    "Cream cheese frosting (included in the package)",

                    //Recipe
                    "Preheat your oven to 350°F (175°C). \r\n" +
                    "Unroll the tube of refrigerated cinnamon roll dough and separate the rolls. \r\n" +
                    "Place them on a baking sheet lined with parchment paper. \r\n" +
                    "Bake according to package instructions, usually 12-15 minutes, or until golden brown. \r\n" +
                    "Remove from the oven and drizzle with the cream cheese frosting included in the package. \r\n" +
                    "Serve warm and enjoy the rich flavor of the Cream Cheese Cinnamon Roll.",

                    //Category
                    DishCategory.Cinnamonl,

                    //Rating
                    4.9f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Apple Cinnamon Roll",

                    //Ingredients
                    "1 tube refrigerated cinnamon roll dough with icing\r\n"+
                    "Apple pie filling or thinly sliced apples",

                    //Recipe
                    "Preheat your oven to 350°F (175°C). \r\n" +
                    "Unroll the tube of refrigerated cinnamon roll dough and separate the rolls. \r\n" +
                    "Place them on a baking sheet lined with parchment paper. \r\n" +
                    "Spread apple pie filling or thinly sliced apples over the rolls before baking. \r\n" +
                    "Bake according to package instructions, usually 12-15 minutes, or until golden brown. \r\n" +
                    "Remove from the oven and drizzle with the included icing. \r\n" +
                    "Serve warm and enjoy the delightful combination of flavors in the Apple Cinnamon Roll.",

                    //Category
                    DishCategory.Cinnamonl,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Maple Pecan Cinnamon Roll",

                    //Ingredients
                    "1 tube refrigerated cinnamon roll dough with icing\r\n"+
                    "Chopped pecans\r\n"+
                    "Maple syrup",

                    //Recipe
                    "Preheat your oven to 350°F (175°C). \r\n" +
                    "Unroll the tube of refrigerated cinnamon roll dough and separate the rolls. \r\n" +
                    "Place them on a baking sheet lined with parchment paper. \r\n" +
                    "Sprinkle chopped pecans over the rolls before baking. \r\n" +
                    "Drizzle with maple syrup during the last few minutes of baking. \r\n" +
                    "Bake according to package instructions, usually 12-15 minutes, or until golden brown. \r\n" +
                    "Remove from the oven and drizzle with the included icing. \r\n" +
                    "Serve warm and enjoy the rich sweetness of the Maple Pecan Cinnamon Roll.",

                    //Category
                    DishCategory.Cinnamonl,

                    //Rating
                    4.9f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Orange Cinnamon Roll",

                    //Ingredients
                    "1 tube refrigerated cinnamon roll dough with icing\r\n"+
                    "Orange zest",

                    //Recipe
                    "Preheat your oven to 350°F (175°C). \r\n" +
                    "Unroll the tube of refrigerated cinnamon roll dough and separate the rolls. \r\n" +
                    "Place them on a baking sheet lined with parchment paper. \r\n" +
                    "Sprinkle orange zest over the rolls before baking. \r\n" +
                    "Bake according to package instructions, usually 12-15 minutes, or until golden brown. \r\n" +
                    "Remove from the oven and drizzle with the included icing. \r\n" +
                    "Serve warm and enjoy the refreshing citrus flavor of the Orange Cinnamon Roll.",

                    //Category
                    DishCategory.Cinnamonl,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Nutella Cinnamon Roll",

                    //Ingredients
                    "1 tube refrigerated cinnamon roll dough with icing\r\n"+
                    "Nutella or chocolate hazelnut spread",

                    //Recipe
                    "Preheat your oven to 350°F (175°C). \r\n" +
                    "Unroll the tube of refrigerated cinnamon roll dough and separate the rolls. \r\n" +
                    "Place them on a baking sheet lined with parchment paper. \r\n" +
                    "Spread Nutella or chocolate hazelnut spread over the rolls before baking. \r\n" +
                    "Bake according to package instructions, usually 12-15 minutes, or until golden brown. \r\n" +
                    "Remove from the oven and drizzle with the included icing. \r\n" +
                    "Serve warm and enjoy the indulgent Nutella Cinnamon Roll.",

                    //Category
                    DishCategory.Cinnamonl,

                    //Rating
                    4.9f,

                    //Is Liked
                    false
                    ),

                new DishData(
                    //Dish Name
                    "Lemon Blueberry Cinnamon Roll",

                    //Ingredients
                     "1 tube refrigerated cinnamon roll dough with icing\r\n"+
                    "Fresh blueberries\r\n"+
                    "Lemon zest",

                    //Recipe
                    "Preheat your oven to 350°F (175°C). \r\n" +
                    "Unroll the tube of refrigerated cinnamon roll dough and separate the rolls. \r\n" +
                    "Place them on a baking sheet lined with parchment paper. \r\n" +
                    "Sprinkle fresh blueberries and lemon zest over the rolls before baking. \r\n" +
                    "Bake according to package instructions, usually 12-15 minutes, or until golden brown. \rn\n" +
                    "Remove from the oven and drizzle with the included icing. \r\n" +
                    "Serve warm and enjoy the vibrant flavors of the Lemon Blueberry Cinnamon Roll.",

                    //Category
                    DishCategory.Cinnamonl,

                    //Rating
                    4.8f,

                    //Is Liked
                    false
                    ),
            };
            DishDataManager.SaveCardDataList(dishes);
        }
        else
        {
            Debug.Log("Dishes loaded");
        }
    }
}
