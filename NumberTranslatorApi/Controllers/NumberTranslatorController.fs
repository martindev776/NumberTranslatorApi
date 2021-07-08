namespace NumberTranslatorApi.Controllers

open Microsoft.AspNetCore.Mvc
open NumberTranslatorComposer


[<ApiController>]
[<Route("[controller]")>]
type NumberTranslatorController() =
    inherit ControllerBase()

    [<HttpGet("GetNumber/{number}")>]
    member _.Get (number: int) : string =
        number |> Translate