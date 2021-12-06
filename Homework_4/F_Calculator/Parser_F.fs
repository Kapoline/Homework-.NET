namespace F_Calculator

open System

module Parser =
    let OperatorDetector arg =
        match arg with
        |"+" -> Calculator.Operations.Plus
        |"-" -> Calculator.Operations.Minus
        |"*" -> Calculator.Operations.Mult
        |"/" -> Calculator.Operations.Divide
        | _  -> Calculator.Operations.UnknownOperation
        
    let IsInt (arg:string) (result:outref<int>) =
        if Int32.TryParse(arg, &result) then
            true
        else
            false
        

