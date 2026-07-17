vaporizer-examine-state =
    { $state ->
        *[normal] [color=lightblue]Испаритель работает исправно.[/color]
        [badsolution] [color=red]В камере испарителя находится некачественный раствор.[/color]
        [lowsolution] [color=yellow]В испарителе мало жидкости..[/color]
        [empty] [color=red]Испаритель пуст.[/color]
    }
