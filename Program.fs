module Program

open System
open Types
open Pricing

[<EntryPoint>]
let main argv =
    // Sample data
    let coffee = Coffee(Espresso, Medium)
    let tea = Tea(GreenTea, Large)
    let juice = Juice(JuiceType.Orange, Small)
    let food = FoodItem Burger
    let fruit = FruitItem Banana

    // Print results
    printfn "Price of %A is: %.2f DKK" coffee (getDrinkPrice coffee)
    printfn "Price of %A is: %.2f DKK" tea (getDrinkPrice tea)
    printfn "Price of %A is: %.2f DKK" juice (getDrinkPrice juice)
    printfn "Price of %A is: %.2f DKK" food (getFoodPrice food)
    printfn "Price of %A is: %.2f DKK" fruit (getFruitPrice fruit)

    // Keep console open
    printfn "Press any key to exit..."
    Console.ReadKey() |> ignore
    0 // return an integer exit code
