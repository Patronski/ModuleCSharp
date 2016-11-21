using MassDefect.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassDefect.ExportingJson
{
    public class StartExporting
    {
        static void Main()
        {
            var context = new MassDefectContext();

            ExportPlanetsWhichAreNotAnomalyOrigins(context);
            ExportPeopleWhichHaveNotBeenVictims(context);
            ExportTopAnomaly(context);
        }

        private static void ExportTopAnomaly(MassDefectContext context)
        {
            var exportedAnomaly = context.Anomalies
                .OrderByDescending(a => a.Victims.Count)
                .Take(1)
                .Select(anomaly => new
                {
                    id = anomaly.Id,
                    originPlanet = new
                    {
                        name = anomaly.OriginPlanet.Name
                    },
                    teleportPlanet = new
                    {
                        name = anomaly.TeleportPlanet.Name
                    },
                    victimsCount = anomaly.Victims.Count
                });

            var exportedAnomalyAsJson = JsonConvert.SerializeObject(exportedAnomaly, Formatting.Indented);
            File.WriteAllText("../../ExportedData/anomaly.json", exportedAnomalyAsJson);    
        }

        private static void ExportPeopleWhichHaveNotBeenVictims(MassDefectContext context)
        {
            var exportedPersons = context.Persons
                .Where(p => !p.Anomalies.Any())
                .Select(people => new
                {
                    name = people.Name,
                    homePlanet = new
                    {
                        name = people.HomePlanet.Name
                    }
                });

            var personsAsJson = JsonConvert.SerializeObject(exportedPersons, Formatting.Indented);
            File.WriteAllText("../../ExportedData/people.json", personsAsJson);
        }

        private static void ExportPlanetsWhichAreNotAnomalyOrigins(MassDefectContext context)
        {
            var exportedPlanets = context.Planets
                .Where(p => !p.OriginAnomalies.Any())
                .Select(planet => new
                {
                    name = planet.Name
                });

            var planetsAsJson = JsonConvert.SerializeObject(exportedPlanets, Formatting.Indented);
            File.WriteAllText("../../ExportedData/planets.json", planetsAsJson);
        }
    }
}
