module Agents

open Types
open Pricing

let processOrder (order: Order) =
    let priceBeforeVAT = (getPrice order.Product) * (float order.Quantity)
    let percentVAT =
        match order with
        | { Product = Drink (Coffee (_, _)) } -> 25 // According to assignment, only add VAT when drink type is coffee
        | _ -> 0
    let priceAfterVAT =  gtgVAT percentVAT priceBeforeVAT
    printfn "Please pay %.2f DKK for your %i %A using %A" priceAfterVAT order.Quantity order.Product order.Payment

let processComment (comment: string) =
    printfn "Comment left by a customer: %s" comment

let startGtgAgent () = MailboxProcessor<OrderProductMsg>.Start(fun inbox ->
    let rec loop () =
        async {
            let! msg = inbox.Receive()
            match msg with
            | Order order -> processOrder order
            | LeaveAComment comment -> processComment comment
            return! loop ()
        }
    loop ()
)
