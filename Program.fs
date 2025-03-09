module Program

open System
open Types
open Pricing
open Agents

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

    let gtgAgent = startGtgAgent ()

    gtgAgent.Post (Order { Customer = VIACustomer;     Payment = VIACard;      Product = Drink (Coffee (Espresso, Small));     Quantity = 1 })
    gtgAgent.Post (Order { Customer = SOSUCustomer;    Payment = CreditCard;   Product = Drink (Tea (GreenTea, Large));        Quantity = 2 })
    gtgAgent.Post (LeaveAComment "Great service!")
    gtgAgent.Post (Order { Customer = VIACustomer;     Payment = MobilePay;    Product = Drink (Juice (Mango, Medium));        Quantity = 3 })
    gtgAgent.Post (Order { Customer = SOSUCustomer;    Payment = VIACard;      Product = Food  (FoodItem Sandwich);            Quantity = 1 })
    gtgAgent.Post (LeaveAComment "This sandwich was very tasty")
    gtgAgent.Post (Order { Customer = VIACustomer;     Payment = CreditCard;   Product = Food  (FoodItem Burger);              Quantity = 2 })
    gtgAgent.Post (Order { Customer = SOSUCustomer;    Payment = MobilePay;    Product = Fruit (FruitItem Apple);              Quantity = 5 })
    gtgAgent.Post (Order { Customer = VIACustomer;     Payment = VIACard;      Product = Fruit (FruitItem Banana);             Quantity = 4 })
    gtgAgent.Post (Order { Customer = SOSUCustomer;    Payment = CreditCard;   Product = Drink (Coffee (Latte, Large));        Quantity = 1 })
    gtgAgent.Post (Order { Customer = VIACustomer;     Payment = MobilePay;    Product = Drink (Tea (BlackTea, Small));        Quantity = 2 })

    // Keep console open
    Console.ReadKey() |> ignore
    0 // return an integer exit code
