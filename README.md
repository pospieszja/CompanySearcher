# CompanySearcher

Zadanie
Celem zadania jest stworzenie aplikacji internetowej pozwalającej na pobieranie pełnych danych działalności
gospodarczej z bazy danych po podaniu numeru NIP, REGON lub KRS.
Użytkownik widzi pojedyncze pole, umożliwiające podanie numeru NIP/REGON/KRS. Po jego podaniu
asynchronicznie wywoływana jest metoda z API, która odpytuje bazę danych o dane działalności. W przypadku
podania ciągu, na podstawie którego nie da znaleźć się danych, należy wyświetlić puste pola i komunikat o błędzie
wyszukiwania. W przypadku podania poprawnego ciągu (dla którego istnieją dane w bazie danych) należy
wyświetlić wypełnione pola. Każdorazowa zmiana numeru NIP/REGON/KRS powinna aktualizować wyświetlane
dane.
Dodatkowo należy każde zapytanie powiązane z wyszukiwanym numerem logować w bazie w osobnej tabeli w celach
statystycznych wraz ze wszystkimi nagłówkami zapytania HTTP.
Do zadania należy kompletne zaprojektowanie wielowarstwowej aplikacji – od projektu modelu danych (bazy danych),
przez stworzenie uniwersalnego API, po frontendową aplikację konsumującą wskazane API. Oczywiście można
rozwiązać to na wiele innych sposobów – wybór optymalnego (Twoim zdaniem) rozwiązania, to Twoje główne
zadanie.
Makieta
Makieta (to, w jaki sposób rozwiązanie ma działać) znajduje się tutaj: http://ihaveanidea.aveneo.pl/Tasks/NIP/
Uwagi
Numer NIP w przeciwieństwie do numerów REGON i KRS może posiadać różne formy zapisu, np.: PL7777777777,
777-777-77-77, 7777777777 itd.. Należy uwzględnić to przy budowaniu zapytania do bazy danych.
Do każdego wpisu o działalności gospodarczej w bazie danych może być przypisany zarówno NIP, REGON jak i KRS.
Baza danych
W rozwiązaniu poza migracjami pozwalającymi stworzyć bazę danych umieść proszę seed-a, zawierającego kilka
wpisów z danymi działalności gospodarczych (testowych).
