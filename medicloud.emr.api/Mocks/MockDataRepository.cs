using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System;
using Bogus;
using System.Linq;

namespace medicloud.emr.api.Mocks
{
    public class MockDataRepository
    {
        public IEnumerable<MockVitals> FakeDataGenerator()
        {
            var fakes = new Faker<MockVitals>()
            .RuleFor(x => x.Id, f => f.UniqueIndex)
            .RuleFor(x => x.Name, f => f.Person.FullName)
            .RuleFor(x => x.Pulse, f => f.Random.Int(10, 35))
            .RuleFor(x => x.BloodPressure, f => f.Random.Int(60, 150))
            .RuleFor(x => x.Weight, f => Math.Round(f.Random.Double(50, 170),2))
            .RuleFor(x => x.Height, f => Math.Round(f.Random.Double(1, 2.5),2))
            .RuleFor(x => x.BMI, f => Math.Round(f.Random.Double(50, 170),2))
            .RuleFor(x => x.Temperature, f => Math.Round(f.Random.Double(24, 37),2))
            .RuleFor(x => x.Respiration, f => f.Random.Int(10, 35))
            .RuleFor(x => x.DateAdded, f => f.Date.Between(new DateTime(2020,08,01),new DateTime(2021,08,01)))
            .RuleFor(x => x.Complaint, f => f.Random.Words(20));

            var generatedFakes = fakes.Generate(10);
            return generatedFakes;
        }

        public IEnumerable<MockVitals> FakeVitals() => MockVitalsData.MockVitals;
        

        public MockVitals FakeVital(int id) => MockVitalsData.MockVitals.FirstOrDefault(x => x.Id == id);
    }

    public class MockVitals
    {
        public int Id { get; set; }
        public double Temperature { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Pulse { get; set; }
        public int BloodPressure { get; set; }
        public double Height { get; set; }
        public DateTime DateAdded { get; set; }
        public int Respiration { get; set; }
        public double BMI { get; set; }
        public string Complaint { get; set; }

    }

    public static class MockVitalsData
    {
        public static MockVitals[] MockVitals = new MockVitals[]
        {
            
            new MockVitals {
                Id = 1,
                Temperature = 27.38,
                Name = "Armando Tremblay",
                Weight = 164.94,
                Pulse = 19,
                BloodPressure = 75,
                Height = 1.44,
                DateAdded =  new DateTime(2020,10,04),
                Respiration = 33,
                BMI = 136.98,
                Complaint = "Granite Pines bi-directional static Division Borders Indiana Syrian Pound withdrawal Computers & Sports Home & Home Landing yellow Belarussian Ruble Tools card deposit Rustic Naira turn-key"
            },
            new MockVitals {
                Id = 2, Temperature = 25.78, Name = "Zachary Bradtke", Weight = 109.89,
                Pulse = 10, BloodPressure = 78, Height = 2.16, DateAdded =  new DateTime(2020,05,14),
                Respiration = 18,BMI = 128.34, Complaint = "clicks-and-mortar virtual Small Plastic Salad Gourde Berkshire Senior wireless Polarised Open-source sky blue Avon Marshall Islands Corporate Ferry hacking West Virginia Security Cambridgeshire silver Practical"
            },
            new MockVitals {
                Id = 3, Temperature = 33.51, Name = "Franklin Christiansen", Weight = 103.39, Pulse = 31,
                BloodPressure = 114, Height = 2.2, DateAdded =  new DateTime(2020,01,09), Respiration = 14,
                BMI = 59.11, Complaint = "transmit bandwidth plum Research Forges redundant Rhode Island budgetary management Soft Rustic Steel Chair Avon Junction Marshall Islands Frozen Baby, Grocery & Computers Intelligent Sudanese Pound Fresh Estate Creative"
            },
            new MockVitals {
                Id = 4, Temperature = 26.61, Name = "Israel Bernhard", Weight = 168.49, Pulse = 23,
                BloodPressure = 131, Height = 2.33, DateAdded =  new DateTime(2020,10,16), Respiration = 14,
                BMI = 142.58, Complaint = "Savings Account Intelligent Granite Tuna Ergonomic Home & Computers red neural Refined Granite Pizza Chief turquoise Generic program Generic Frozen Table Handcrafted Cotton Gloves Borders Diverse systems Montserrat Tasty Analyst Officer"
            },
            new MockVitals {
                Id = 5, Temperature = 25.82, Name = "Sonja Rath", Weight = 81.67, Pulse = 17,
                BloodPressure = 60, Height = 1.93, DateAdded =  new DateTime(2020,12,24), Respiration = 23,
                BMI = 93.66, Complaint = "Sleek Refined Awesome white Implementation withdrawal Avon benchmark virtual Licensed Soft Gloves cross-platform integrate Berkshire Handcrafted indexing Rue Incredible Cotton Car ROI Senior River"
            },
            new MockVitals {
                Id = 6, Temperature = 25.8, Name = "Edward Stokes", Weight = 158.97, Pulse = 33,
                BloodPressure = 62, Height = 1.86, DateAdded =  new DateTime(2020,04,22), Respiration = 32,
                BMI = 146.59, Complaint = "Intelligent Fresh Towels solid state payment transform Ouguiya invoice alarm input Games Awesome Cotton Fish Frozen Sleek Steel Bacon Motorway Bypass array navigate vortals Money Market Account dynamic New Mexico"
            },
            new MockVitals {
                Id = 7, Temperature = 27.92, Name = "Calvin Gaylord", Weight = 57.72, Pulse = 33,
                BloodPressure = 134, Height = 1.76, DateAdded =  new DateTime(2020,04,17), Respiration = 18,
                BMI = 164.89, Complaint = "Regional Handcrafted Licensed Frozen Bacon algorithm deposit technologies human-resource Licensed Granite Bacon synthesize Eritrea Flats Legacy Central Intelligent Handcrafted incubate Yemeni Rial 24/365 Cotton Incredible"
            },
            new MockVitals {
                Id = 8, Temperature = 36.6, Name = "Jaime Schaefer", Weight = 108.09, Pulse = 27,
                BloodPressure = 110, Height = 1.76, DateAdded =  new DateTime(2020,04, 09), Respiration = 25,
                BMI = 103.08, Complaint = "Health, Industrial & Outdoors Home, Music & Baby transmit impactful Pakistan Rupee blockchains architectures Functionality PNG Awesome Steel Gloves e-business Tasty Frozen Towels incubate Avon Squares programming Village Licensed Concrete Salad transmitting Granite"
            },
            new MockVitals {
                Id = 9, Temperature = 29.36, Name = "Michelle Roberts", Weight = 90.78, Pulse = 32,
                BloodPressure = 78, Height = 1.69, DateAdded =  new DateTime(2020,07,09), Respiration = 35,
                BMI = 167.42, Complaint = "calculate innovative Soft California efficient Berkshire quantifying bus Designer e-markets Awesome Concrete Salad port Usability Personal Loan Account revolutionize Operations protocol expedite Dynamic quantify"
            },
            new MockVitals {
                Id = 10,
                Temperature = 24.25,
                Name = "Brandi Kihn",
                Weight = 75.09,
                Pulse = 29,
                BloodPressure = 111,
                Height = 1.52,
                DateAdded =  new DateTime(2020,05,09),
                Respiration = 29,
                BMI = 140.32,
                Complaint = "Steel 3rd generation Switchable Global blockchains Courts Trail Investment Account Florida deposit Intuitive Czech Koruna capability Small Rubber Mouse Human Bedfordshire Configurable AGP Up-sized withdrawal"
            },
            new MockVitals {
                Id = 11,
                Temperature = 27.38,
                Name = "Armando Tremblay",
                Weight = 164.94,
                Pulse = 19,
                BloodPressure = 75,
                Height = 1.44,
                DateAdded =  new DateTime(2020,10,04),
                Respiration = 33,
                BMI = 136.98,
                Complaint = "Granite Pines bi-directional static Division Borders Indiana Syrian Pound withdrawal Computers & Sports Home & Home Landing yellow Belarussian Ruble Tools card deposit Rustic Naira turn-key"
            },

        };
    }
}