namespace MassDefect.ImportFromXml
{
    using Data;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using System.Xml.XPath;


    public class StartImportFromXml
    {
        private const string NewAnomaliesPath = "../../../datasets/new-anomalies.xml";

        static void Main()
        {
            var xml = XDocument.Load(NewAnomaliesPath);
            var anomalies = xml.XPathSelectElements("anomalies/anomaly");

            var context = new MassDefectContext();
            var count = context.Anomalies.Count();

            foreach (var anomaly in anomalies)
            {
                ImportAnomalyAndVictims(anomaly, context);
            }

        }

        private static void ImportAnomalyAndVictims(XElement anomalyNode, MassDefectContext context)
        {
            var originPlanetName = anomalyNode.Attribute("origin-planet");
            var teleportPlanetName = anomalyNode.Attribute("teleport-planet");

            if (originPlanetName == null || teleportPlanetName == null)
            {
                Console.WriteLine("Error: Invalid data.");
                return;
            }

            var anomalyEntity = new Anomaly
            {
                OriginPlanet = GetPlanetByName(originPlanetName.Value, context),
                TeleportPlanet = GetPlanetByName(teleportPlanetName.Value, context)
            };

            if (anomalyEntity.OriginPlanet == null || anomalyEntity.TeleportPlanet == null)
            {
                Console.WriteLine("Error: Invalid data.");
                return;
            }

            context.Anomalies.Add(anomalyEntity);
            Console.WriteLine("Successfully imported anomaly.");

            var victims = anomalyNode.XPathSelectElements("victims/victim");
            foreach (var victim in victims)
            {
                ImportVictim(victim, context, anomalyEntity);
            }

            context.SaveChanges();
        }

        private static void ImportVictim(XElement victimNode, MassDefectContext context, Anomaly anomaly)
        {
            var name = victimNode.Attribute("name");

            if (name == null)
            {
                Console.WriteLine("Error: Invalid data.");
                return;
            }

            var personEntity = GetPersonByName(name.Value, context);

            if (personEntity == null)
            {
                Console.WriteLine("Error: Invalid data.");
                return;
            }

            anomaly.Victims.Add(personEntity);
            //Console.WriteLine("Successfully imported victims.");
            context.SaveChanges();
        }

        private static Person GetPersonByName(string value, MassDefectContext context)
        {
            var person = context.Persons.FirstOrDefault(s => s.Name == value);

            return person;
        }

        private static Planet GetPlanetByName(string homePlanetName, MassDefectContext context)
        {
            var homePlanet = context.Planets.FirstOrDefault(s => s.Name == homePlanetName);

            return homePlanet;
        }
    }
}
