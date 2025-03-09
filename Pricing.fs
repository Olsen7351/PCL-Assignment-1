module Pricing

open Types

// Function to compute drink prices based on type and size
let getDrinkPrice (drink: Drink) =
    match drink with
    | Coffee(Espresso, Small) -> 15.0
    | Coffee(Espresso, Medium) -> 20.0
    | Coffee(Espresso, Large) -> 25.0
    | Coffee(Latte, Small) -> 18.0
    | Coffee(Latte, Medium) -> 23.0
    | Coffee(Latte, Large) -> 28.0
    | Coffee(Cappuccino, Small) -> 17.0
    | Coffee(Cappuccino, Medium) -> 22.0
    | Coffee(Cappuccino, Large) -> 27.0
    | Tea(BlackTea, Small) -> 10.0
    | Tea(BlackTea, Medium) -> 15.0
    | Tea(BlackTea, Large) -> 20.0
    | Tea(GreenTea, Small) -> 12.0
    | Tea(GreenTea, Medium) -> 17.0
    | Tea(GreenTea, Large) -> 22.0
    | Tea(HerbalTea, Small) -> 11.0
    | Tea(HerbalTea, Medium) -> 16.0
    | Tea(HerbalTea, Large) -> 21.0
    | Juice(JuiceType.Orange, Small) -> 13.0
    | Juice(JuiceType.Orange, Medium) -> 18.0
    | Juice(JuiceType.Orange, Large) -> 23.0
    | Juice(JuiceType.Apple, Small) -> 12.0
    | Juice(JuiceType.Apple, Medium) -> 17.0
    | Juice(JuiceType.Apple, Large) -> 22.0
    | Juice(JuiceType.Mango, Small) -> 14.0
    | Juice(JuiceType.Mango, Medium) -> 19.0
    | Juice(JuiceType.Mango, Large) -> 24.0

// Function to compute food prices
let getFoodPrice (food: Food) =
    match food with
    | FoodItem Sandwich -> 30.0
    | FoodItem Salad -> 25.0
    | FoodItem Burger -> 35.0

// Function to compute fruit prices
let getFruitPrice (fruit: Fruit) =
    match fruit with
    | FruitItem FruitType.Apple -> 5.0
    | FruitItem FruitType.Banana -> 4.0
    | FruitItem FruitType.Orange -> 6.0

let getPrice (product: Product) =
    match product with
    | Drink drink -> getDrinkPrice(drink)
    | Food  food  -> getFoodPrice(food)
    | Fruit fruit -> getFruitPrice(fruit)

let gtgVAT (percent: int) (priceBeforeVAT: float) : float =
    priceBeforeVAT * (1.0 + (float percent / 100.0))
