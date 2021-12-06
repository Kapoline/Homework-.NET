namespace F_Calculator_RCE

open System
open F_Calculator_RCE

module Parser_RCE =
    let wrongOperation= Calculator_RCE.WrongOperator
    let OperatorDetector arg =
        ResultBuilder(wrongOperation){
            if arg = "+" || arg = "-" || arg = "*" || arg = "/" then
               match arg with
               |"+" -> Calculator_RCE.Operations.Plus |> ignore
               |"-" -> Calculator_RCE.Operations.Minus |> ignore
               |"*" -> Calculator_RCE.Operations.Mult |> ignore
               |"/" -> Calculator_RCE.Operations.Divide |> ignore
               | _ -> failwith "UnknownOperation"
        }
        
    let parserInt(var: string) =
        match Int32.TryParse var with
        |true, result -> Success result
        | _ -> failwith "Error"
    let parserFloat(var: string) =
        match Single.TryParse var with
        |true, result -> Success result
        | _ -> failwith "Error"
    let parserDouble(var: string) =
        match Double.TryParse var with
        |true, result -> Success result
        | _ -> failwith "Error"    
    let parserDecimal(var: string) =
        match Decimal.TryParse var with
        |true, result -> Success result
        | _ -> failwith "Error"    

