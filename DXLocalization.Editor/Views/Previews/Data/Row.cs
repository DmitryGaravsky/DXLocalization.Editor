namespace DXLocalizationEditor.Views.Data {
    using System;
    using System.Collections.Generic;

    public enum Gender {
        Male, Female, Other
    }
    public class Row {
        const int Seed = 10000;
        static Random random = new Random(Seed);
        protected Row() { }
        //
        public int ID { get; set; }
        public Guid UID { get; set; }
        public string SID { get; set; }
        //
        public int Age { get; set; }
        public long Size { get; set; }
        public decimal Price { get; set; }
        public double Amount { get; set; }
        public float Factor { get; set; }
        //
        public string Name { get; set; }
        public string Notes { get; set; }
        //
        public bool IsActive { get; set; }
        public bool? Approved { get; set; }
        //
        public DateTime Open { get; set; }
        public DateTime? Resolved { get; set; }
        //
        public Gender Gender { get; set; }
        //
        public static object GetRows(int rows = 1000) {
            List<Row> dataSource = new List<Row>(rows);
            for(int i = 0; i < rows; i++)
                dataSource.Add(Row.CreateRow(i));
            return dataSource;
        }
        public static Row CreateRow(int seed, Func<Row> createRow = null) {
            createRow = createRow ?? new Func<Row>(() => new Row());
            Row r = createRow();
            r.ID = seed;
            r.UID = new Guid(seed.UID());
            r.SID = random.String(6);
            //
            r.Age = random.Next(16, 100);
            r.Size = random.Next(0, int.MaxValue);
            r.Price = Math.Round(new decimal(random.NextDouble() * 10000.0), 2);
            r.Amount = Math.Round(115.0 + random.NextDouble() * 100.0, 4);
            r.Factor = (float)Math.Round(15.0 + random.NextDouble() * 10.0, 2);
            //
            r.Name = random.String(random.Next(6, 12));
            r.Notes = random.LoremIpsum();
            //
            r.IsActive = seed % 17 != 0;
            if(seed % 23 == 0)
                r.Approved = random.Next(10000) % 2 != 0;
            //
            r.Open = new DateTime(2000, 1, 1).AddDays(random.Next(1000));
            if(seed % 7 == 0)
                r.Resolved = r.Open.AddDays(random.Next(50));
            //
            r.Gender = random.Next(10000) % 2 == 0 ? Gender.Male : Gender.Female;
            if(r.Gender == Gender.Male && seed % 7 == 0)
                r.Gender = Gender.Other;
            return r;
        }
    }
}