// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

var menuItems = document.getElementsByClassName("menu-item");

var form = document.getElementById("search-and-filter-form");

form.addEventListener("submit", function (event) {
    event.preventDefault();
    var i, item;

    var searchTerm = document.getElementById("search").value;

    var menuCategory = [];
    var menuCategoryCheckBoxes = document.getElementsByClassName("menu-category");
    for (i = 0; i < menuCategoryCheckBoxes.length; i++) {
        if (menuCategoryCheckBoxes[i].checked) {
            menuCategory.push(menuCategoryCheckBoxes[i].value);
        }
    }

    var minimumPrice = document.getElementById("minimum-price").value;
    if (minimumPrice == 0) minimumPrice = false;
    var maximumPrice = document.getElementById("maximum-price").value;
    if (maximumPrice == 0) maximumPrice = false;

    var excludeIngredient = [];
    var excludeIngredientCheckBoxes = document.getElementsByClassName("exclude-ingredient");
    for (i = 0; i < excludeIngredientCheckBoxes.length; i++) {
        if (excludeIngredientCheckBoxes[i].checked) {
            excludeIngredient.push(excludeIngredientCheckBoxes[i].value);
        }
    }

    for (i = 0; i < menuItems.length; i++) {
        var item = menuItems[i];
        item.style.display = "block";

        if (searchTerm) {
            if (!item.dataset.description.toLowerCase().includes(searchTerm.toLowerCase())) {
                item.style.display = "none";
            }
        }

        if (menuCategory.length > 0) {
            if (!menuCategory.includes(item.dataset.category)) {
                item.style.display = "none"
            }
        }

        if (minimumPrice) {
            if (parseFloat(minimumPrice) > parseFloat(item.dataset.price)) {
                item.style.display = "none";
            }
        }

        if (maximumPrice) {
            if (parseFloat(maximumPrice) < parseFloat(item.dataset.price)) {
                item.style.display = "none";
            }
        }

        if (excludeIngredient.length > 0) {
            var ingredients = item.getElementsByClassName("ingredient");

            for (var j = 0; j < ingredients.length; j++) {
                console.log(ingredients[j].dataset.ingredient);
                if (excludeIngredient.includes(ingredients[j].dataset.ingredient)) {
                    item.style.display = "none";
                }
            }
        }
    }

});