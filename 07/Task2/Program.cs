using Task2;

ConfigurationManager configManager = new ConfigurationManager();
Configurations configs = new Configurations();

configManager.SetConfiguration("SQL Server", configs.SetDatabaseConfig);
configManager.SetConfiguration("Redis Cache", configs.SetCacheConfig);
public delegate void ConfigSetter(string config);