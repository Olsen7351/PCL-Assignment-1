module Types

// Defining different types of drinks
type CoffeeType =
    | Espresso
    | Latte
    | Cappuccino

type TeaType =
    | BlackTea
    | GreenTea
    | HerbalTea

type JuiceType =
    | Orange
    | Apple
    | Mango

// Sizes for drinks
type DrinkSize =
    | Small
    | Medium
    | Large

// Union type for all drinks
type Drink =
    | Coffee of CoffeeType * DrinkSize
    | Tea of TeaType * DrinkSize
    | Juice of JuiceType * DrinkSize

// Food categories
type FoodType =
    | Sandwich
    | Salad
    | Burger

// Union type for food
type Food = FoodItem of FoodType

// Fruit categories
type FruitType =
    | Apple
    | Banana
    | Orange

// Union type for fruits
type Fruit = FruitItem of FruitType
