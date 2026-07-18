<p align="center"> <img alt="Space Station 14" width="880" height="200" src="https://github.com/funky-station/funky-station/blob/master/Resources/Textures/Logo/logo.png" /></p>

Это сервер Space Station 14. Чтобы предотвратить создание форков RobustToolbox, клиент и сервер загружают специальный пакет контента. Этот пакет содержит всё необходимое для игры на конкретном сервере.

## Ссылки

[Discord-сервер Funky Station](https://discord.gg/5FqgaAA2qF)

## Документация/Вики

[Документация Funky Station](https://docs.funkystation.org/) содержит информацию о том, как внести вклад в Funky Station. В нем представлены руководства, документы по геймдизайну и полезные советы по работе с репозиторием.

## Контрибьют

Мы приглашаем всех желающих внести свой вклад в наш форк. Присоединяйтесь к нашему Discord для совместной работы!
Мы рекомендуем вам ознакомиться с правилами контрибьюции. [Правила контрибьюции](https://docs.spacestation14.com/en/general-development/codebase-info/pull-request-guidelines.html)

## Сборка

1. Клонируйте данный репозиторий:
```shell
git clone https://github.com/ThxMqninq/forky-station.git
```
2. Перейдите в папку проекта и запустите `RUN_THIS.py` чтобы инициализировать подмодули и загружить движок:
```shell
cd forky-station
python RUN_THIS.py
```
3. Скомпилируйте решение:

Соберите сервер с помощью `dotnet build`.

[Более подробные инструкции по сборке проекта.](https://docs.spacestation14.com/en/general-development/setup.html)

## Лицензия

Этот репозиторий распространяется на условиях лицензии MIT. Копия лицензии MIT находится в папке `LICENSES`.

Большинство медиаассетов лицензированы в соответствии с условиями [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/) если не указано иное. Ассеты имеют лицензию и авторские права, указанные в файле метаданных. [Пример](https://github.com/ThxMqninq/forky-station/blob/master/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json).

Обратите внимание, что некоторые ресурсы распространяются на условиях некоммерческой лицензии [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) или аналогичными некоммерческими лицензиями; их потребуется удалить, если вы захотите использовать этот проект в коммерческих целях.

Если вы обнаружили, что авторство вашей работы или работы другого человека указано неверно, пожалуйста, создайте issue на странице этого репозитория на GitHub или напишите команде мейнтейнеров Funky Station. @ `maintainers@funkystation.org`.
