module GameModule

let add x y =
    x + y + GameRulesModule.add x y

let sub x y =
    x - y + GameRulesModule.sub x y
