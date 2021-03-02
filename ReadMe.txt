Приложение по получению информации о странах:

Написано с использованием ASP.NET Web-API + Entity Framework 6 Code First (MSSQL Server) 
- cерверная часть (на платформе .NET Framework 4.8)
и  .net Framework Windows Forms - клиентская часть (на платформе .NET Framework 4.8).

Клиентская часть вызывает стороннее API для получения информации о странах с ресурса "https://restcountries.eu", 
и вызывает Web-API серверной части, который управляет базой данных.

Форма CountryForm получает информацию о введенной стране (поле "Country name" - ввести название страны по-английски и нажать на кнопку "Get information"), затем,
по желанию пользователя, можно добавить эту информацию в базу данных.
Форма DbCountriesForm показывает информацию о странах из базы данных.
В базе данных три связанные таблицы: City, Region, Country, новая страна добавляется только после того, как заполняется регион и город из полученных данных. 

В переменной client форм CountryForm и DbCountriesForm нужно указать адрес Web-API серверной части.

База данных находится в папке "CountriesInformationApplication\CoutriesInformationAPI\App_Data".