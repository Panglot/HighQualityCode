namespace HumanCreator
{
    class Hauptklasse
    {
        enum GenderType
        {
            Male,
            Female
        };

        class Human
        {
            public GenderType Gender { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public void CreateHuman(int HumanGeneratingVariable)
        {
            Human HumanForTest = new Human();
            HumanForTest.Age = HumanGeneratingVariable;

            if (HumanGeneratingVariable % 2 == 0)
            {
                HumanForTest.Name = "Батката";
                HumanForTest.Gender = GenderType.Male;
            }
            else
            {
                HumanForTest.Name = "Мацето";
                HumanForTest.Gender = GenderType.Female;
            }
        }
    }
}