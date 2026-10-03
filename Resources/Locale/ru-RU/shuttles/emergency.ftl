# Commands
## Delay shuttle round end
cmd-delayroundend-desc = Останавливает таймер окончания раунда, когда эвакуационный шаттл покидает гиперпространство.
cmd-delayroundend-help = Использование: delayroundend
emergency-shuttle-command-round-yes = Раунд продлён.
emergency-shuttle-command-round-no = Невозможно продлить окончание раунда.

## Dock emergency shuttle
cmd-dockemergencyshuttle-desc = Вызывает спасательный шаттл и пристыковывает его к станции... если это возможно.
cmd-dockemergencyshuttle-help = Использование: dockemergencyshuttle

## Launch emergency shuttle
cmd-launchemergencyshuttle-desc = Досрочно запускает эвакуационный шаттл, если это возможно.
cmd-launchemergencyshuttle-help = Использование: launchemergencyshuttle

# Emergency shuttle
emergency-shuttle-left = Обновление телеметрии эвакуации.
                         Эвакуационный шаттл покинул станцию.
                         Время в пути:
                         { $transitTime } секунд.
emergency-shuttle-launch-time = Уведомление эвакуации.
                                Эвакуационный шаттл запустится через { $consoleAccumulator } секунд.
emergency-shuttle-docked = Уведомление телеметрии эвакуации.
                           Эвакуационный шаттл пристыковался, направление: { $direction }, около станции, { $location }.
                           Отправка через { $time } секунд.{ $extended }
emergency-shuttle-good-luck = Неисправность навигационного трекера.
                              Эвакуационный шаттл не заполучил координаты станции.
                              Эвакуация отменена.
emergency-shuttle-nearby = Навигационное предупреждение.
                           Не удалось найти доступный стык. Эвакуационный шаттл переместился в открытый космос: { $direction }, { $location }.
                           Отправка через { $time } секунд.{ $extended }
emergency-shuttle-extended = { " " }Время до запуска было продлено; включено вспомогательное окно удержания.

# Emergency shuttle console popup / announcement
emergency-shuttle-console-no-early-launches = Досрочный запуск отключён
emergency-shuttle-console-auth-left = { $remaining } { $remaining ->
    [one] авторизация осталась
    [few] авторизации остались
    *[other] авторизаций осталось
} для досрочного запуска шаттла.
emergency-shuttle-console-auth-revoked = Авторизации на досрочный запуск шаттла отозваны, { $remaining } { $remaining ->
    [one] авторизация необходима
    [few] авторизации необходимы
    *[other] авторизаций необходимо
}.
emergency-shuttle-console-denied = Доступ запрещён

# UI
emergency-shuttle-console-window-title = Консоль эвакуационного шаттла
emergency-shuttle-ui-engines = ДВИГАТЕЛИ:
emergency-shuttle-ui-idle = Простой
emergency-shuttle-ui-repeal-all = Отменить все
emergency-shuttle-ui-early-authorize = Разрешение на досрочный запуск
emergency-shuttle-ui-authorize = АВТОРИЗАЦИЯ
emergency-shuttle-ui-repeal = ОТМЕНА
emergency-shuttle-ui-authorizations = Авторизации
emergency-shuttle-ui-remaining = Осталось: { $remaining }

# Map Misc.
map-name-centcomm = Центральное командование
map-name-terminal = Терминал прибытия
