### Examine

gas-turbine-examine-stator-null = It seems to be missing a stator.
gas-turbine-examine-stator = It has a stator.

gas-turbine-examine-blade-null = It seems to be missing a turbine blade.
gas-turbine-examine-blade = It has a turbine blade.

turbine-spinning-0 = Лопасти не вращаются.
turbine-spinning-1 = Лопасти медленно вращаются.
turbine-spinning-2 = Лопасти вращаются.
turbine-spinning-3 = Лопасти быстро вращаются.
turbine-spinning-4 = [color=red]Лопасти вращаются бесконтрольно![/color]

turbine-damaged-0 = Похоже, оно в хорошем состоянии.[/color]
turbine-damaged-1 = Турбина выглядит немного потёртой.[/color]
turbine-damaged-2 = [color=yellow]Турбина выглядит сильно повреждённой.[/color]
turbine-damaged-3 = [color=orange]Оно критически повреждено![/color]

turbine-ruined = [color=red]Оно полностью сломано![/color]

### Popups

# Shown when an event occurs
turbine-overheat = {$owner} активирует аварийный клапан сброса!
turbine-explode = {$owner} разрывает себя на части!

# Shown when damage occurs
turbine-spark = {$owner} начинает искрить!
turbine-spark-stop = {$owner} перестаёт искрить.
turbine-smoke = {$owner} начинает дымиться!
turbine-smoke-stop = {$owner} перестаёт дымиться.

# Shown during repairs
gas-turbine-repair-fail-blade = Вам нужно заменить лопатки турбины, прежде чем можно будет выполнить ремонт.
gas-turbine-repair-fail-stator = Вам нужно заменить статор, прежде чем можно будет выполнить ремонт.
turbine-repair-ruined = Вы исправляете корпус {$target} с помощью {$tool}.
turbine-repair = Вы устраняете часть повреждений {$target} используя {$tool}.
turbine-no-damage = На {$target} нет повреждений.
turbine-show-damage = BladeHealth {$health}, BladeHealthMax {$healthMax}.

# Anchoring warnings
turbine-unanchor-warning = Нельзя отсоединять крепления газовой турбины, пока она вращается!
turbine-anchor-warning = Недопустимая позиция крепления.

gas-turbine-eject-fail-speed = Нельзя снимать детали турбины, пока она вращается!
gas-turbine-insert-fail-speed = Нельзя устанавливать детали турбины, пока она вращается!

### UI

# Shown when using the UI
comp-turbine-ui-tab-main = Контроль
comp-turbine-ui-tab-parts = Части

comp-turbine-ui-rpm = RPM

comp-turbine-ui-overspeed = OVERSPEED
comp-turbine-ui-overtemp = OVERTEMP
comp-turbine-ui-stalling = STALLING
comp-turbine-ui-undertemp = UNDERTEMP

comp-turbine-ui-flow-rate = Расход
comp-turbine-ui-stator-load = Нагрузка на статор

comp-turbine-ui-blade = Лопасти турбины
comp-turbine-ui-blade-integrity = Целостность
comp-turbine-ui-blade-stress = Стресс

comp-turbine-ui-stator = Статор турбины
comp-turbine-ui-stator-potential = Потенциал
comp-turbine-ui-stator-supply = Снабжение

comp-turbine-ui-power = { POWERWATTS($power) }

comp-turbine-ui-locked-message = Controls locked.
comp-turbine-ui-footer-left = Danger: fast-moving machinery.
comp-turbine-ui-footer-right = 2.0 REV 1
