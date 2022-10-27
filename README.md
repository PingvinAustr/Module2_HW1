
# Модуль 2. ДЗ №1. Логер
## Важные моменты:
 - Поскольку в условии было сказано, что "Логер надає методи для взаємодії з ним." - я решил, что будет лучше не вызывать сразу метод Starter.Run в классе Program, а выводить пользователю меню взаимодействия с логером, чтобы пользователь мог сам выбрать какое действие сейчас стоит выполнять.
 - Изначально программа подразумевала использование класса LogEntry для хранения информации о конкретном логе, однако согласно условию класс Result должен хранить сообщение об ошибке (что я предполагал хранить в LogEntry), поэтому было решено избавиться от класса LogEntry и передать его функционал классу Result, чтобы соответствовать условию. 
 - Использован singleton для класса Logger
 - Пользователю в меню взаимодействия с логгером предоставлена возможность генерировать 100 новых логов, читать логи из памяти, читать логи из файла, очищать логи в памяти, очищать логи в файле