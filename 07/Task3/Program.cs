using Task3;

WeatherStation station = new WeatherStation();
DisplayPanel display = new DisplayPanel();
WarningSystem warning = new WarningSystem();

station.WeatherChanged += display.OnWeatherChanged;
station.WeatherChanged += warning.OnWeatherChanged;
station.UpdateWeather("Солнечно");
station.UpdateWeather("Штормовой ветер");
public delegate void WeatherChangedHandler(string weatherCondition);