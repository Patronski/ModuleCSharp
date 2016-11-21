using MassDefect.Data;
using MassDefect.Models;
using MassDefect.Models.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassDefect.ImportFromJson
{
    public class StartImportFromJson
    {
        private const string SolarSystemsPath = "../../../datasets/solar-systems.json";
        private const string StarsPath = "../../../datasets/stars.json";

        private const string PlanetsPath = "../../../datasets/planets.json";

        private const string PersonsPath = "../../../datasets/persons.json";

        private const string AnomaliesPath = "../../../datasets/anomalies.json";
        private const string AnomalyVictimsPath = "../../../datasets/anomaly-victims.json";


        static void Main()
        {
            ImportSoloarSystems();
            ImportStars();
            ImportPlanets();
            ImportPersons();
            ImportAnomalies();
            ImportAnomalyVictims();
        }

        private static void ImportAnomalyVictims()
        {
            var context = new MassDefectContext();
            var json = File.ReadAllText(AnomalyVictimsPath);
            var anomalyVictims = JsonConvert.DeserializeObject<IEnumerable<AnomalyVictimsDto>>(json);

            foreach (var anomalyVictim in anomalyVictims)
            {
                if (anomalyVictim.Id == null || anomalyVictim.Person == null)
                {
                    Console.WriteLine("Error: Invalid data.");
                    continue;
                }

                var anomalyEntity = GetAnomalyById(anomalyVictim.Id, context);
                var personEntity = GetPersonByName(anomalyVictim.Person, context);

                if (anomalyEntity == null || personEntity == null)
                {
                    Console.WriteLine("Error: Invalid data.");
                    continue;
                }

                anomalyEntity.Victims.Add(personEntity);
            }

            context.SaveChanges();
        }

        private static void ImportAnomalies()
        {
            var context = new MassDefectContext();
            var json = File.ReadAllText(AnomaliesPath);
            var anomalies = JsonConvert.DeserializeObject<IEnumerable<AnomalyDto>>(json);

            foreach (var anomaly in anomalies)
            {
                if (anomaly.OriginPlanet == null || anomaly.TeleportPlanet == null)
                {
                    //throw new ArgumentNullException("Error: Invalid data.”… ");
                    Console.WriteLine("Error: Invalid data.");
                    continue;
                }

                var anomalyEntity = new Anomaly
                {
                    OriginPlanet = GetPlanetByNameOfPlanet(anomaly.OriginPlanet, context),
                    TeleportPlanet = GetPlanetByNameOfPlanet(anomaly.TeleportPlanet, context)
                };

                if (anomalyEntity.OriginPlanet == null || anomalyEntity.TeleportPlanet == null)
                {
                    Console.WriteLine("Error: Invalid data.");
                    continue;
                }

                context.Anomalies.Add(anomalyEntity);
                Console.WriteLine($"Successfully imported Anomaly {anomaly.OriginPlanet}.");
            }

            context.SaveChanges();
        }

        private static void ImportPersons()
        {
            var context = new MassDefectContext();
            var json = File.ReadAllText(PersonsPath);
            var persons = JsonConvert.DeserializeObject<IEnumerable<PersonDto>>(json);

            foreach (var person in persons)
            {
                if (person.Name == null || person.HomePlanet == null)
                {
                    //throw new ArgumentNullException("Error: Invalid data.”… ");
                    Console.WriteLine("Error: Invalid data.");
                    continue;
                }

                var personEntity = new Person
                {
                    Name = person.Name,
                    HomePlanet = GetPlanetByNameOfPlanet(person.HomePlanet, context)
                };

                if (personEntity.HomePlanet == null)
                {
                    Console.WriteLine("Error: Invalid data.");
                    continue;
                }

                context.Persons.Add(personEntity);
                Console.WriteLine($"Successfully imported Person {person.Name}.");
            }

            context.SaveChanges();
        }

        private static void ImportPlanets()
        {
            var context = new MassDefectContext();
            var json = File.ReadAllText(PlanetsPath);
            var planets = JsonConvert.DeserializeObject<IEnumerable<PlanetDto>>(json);

            foreach (var planet in planets)
            {
                if (planet.Name == null || planet.SolarSystem == null || planet.Sun == null)
                {
                    //throw new ArgumentNullException("Error: Invalid data.”… ");
                    Console.WriteLine("Error: Invalid data.");
                    continue;
                }

                var planetEntity = new Planet
                {
                    Name = planet.Name,
                    SolarSystem = GetSolarSystemsByName(planet.SolarSystem, context),
                    Sun = GetSunByNameOfStar(planet.Sun, context)
                };

                if (planetEntity.Sun == null || planetEntity.SolarSystem == null)
                {
                    Console.WriteLine("Error: Invalid data.");
                    continue;
                }

                context.Planets.Add(planetEntity);
                Console.WriteLine($"Successfully imported Planet {planet.Name}.");
            }

            context.SaveChanges();
        }

        private static void ImportStars()
        {
            var context = new MassDefectContext();
            var json = File.ReadAllText(StarsPath);
            var stars = JsonConvert.DeserializeObject<IEnumerable<StarDto>>(json);

            foreach (var star in stars)
            {
                //
                if (star.Name == null || star.SolarSystem == null)
                {
                    //throw new ArgumentNullException("Error: Invalid data.”… ");
                    Console.WriteLine("Error: Invalid data.");
                    continue;
                }

                var starEntity = new Star
                {
                    Name = star.Name,
                    SolarSystem = GetSolarSystemsByName(star.SolarSystem, context)
                };

                if (starEntity.SolarSystem == null)
                {
                    Console.WriteLine("Error: Invalid data.");
                    continue;
                }

                context.Stars.Add(starEntity);
                Console.WriteLine($"Successfully imported Star {star.Name}.");
            }

            context.SaveChanges();
        }

        private static void ImportSoloarSystems()
        {
            var context = new MassDefectContext();
            var json = File.ReadAllText(SolarSystemsPath);
            var solarSystems = JsonConvert.DeserializeObject<IEnumerable<SolarSystemDto>>(json);

            foreach (var solarSystem in solarSystems)
            {
                //
                if (solarSystem.Name == null)
                {
                    //throw new ArgumentNullException("Error: Invalid data.”… ");
                    Console.WriteLine("Error: Invalid data.");
                    continue;
                }

                var solarSystemEntity = new SolarSystem
                {
                    Name = solarSystem.Name
                };

                context.SolarSystems.Add(solarSystemEntity);
                Console.WriteLine($"Successfully imported SolarSystem {solarSystem.Name}.");
            }

            context.SaveChanges();
        }

        private static SolarSystem GetSolarSystemsByName(string solarSystemName, MassDefectContext context)
        {
            var solarSystem = context.SolarSystems.FirstOrDefault(s => s.Name == solarSystemName);

            return solarSystem;
        }

        private static Star GetSunByNameOfStar(string sunName, MassDefectContext context)
        {
            var sun = context.Stars.FirstOrDefault(s => s.Name == sunName);

            return sun;
        }

        private static Planet GetPlanetByNameOfPlanet(string homePlanetName, MassDefectContext context)
        {
            var homePlanet = context.Planets.FirstOrDefault(s => s.Name == homePlanetName);

            return homePlanet;
        }

        private static Person GetPersonByName(string personName, MassDefectContext context)
        {
            var person = context.Persons.FirstOrDefault(s => s.Name == personName);

            return person;
        }

        private static Anomaly GetAnomalyById(int? id, MassDefectContext context)
        {
            var anomaly = context.Anomalies.FirstOrDefault(a => a.Id == id);

            return anomaly;
        }
    }
}
