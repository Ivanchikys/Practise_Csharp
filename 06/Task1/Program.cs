using Task1;

CelestialBody[] celestialBodies =
{
    new Planet("Земля"),
    new Star("Солнце"),
    new Asteroid("Веста"),
};
foreach (var body in celestialBodies)
{
    Console.WriteLine(body);
}