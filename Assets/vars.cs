using classes_game;
namespace vars
{
    public class variables
    {
        public static bld oil_factory = new bld(4, 4, 1, "oil", 1);
        public static bld factory = new bld(3, 3, 2, "material", 1);
        public static bld tec = new bld(5, 5, 2, "power", 1);
        public static bld foodprom = new bld(10, 9, 2, "food", 1);
        public static bld hospital = new bld(1, 2, 0, "cure", 1);
        public static bld isolator = new bld(-1, 2, -1, "cure_all", 1);
        public static res oil = new res("oil", 0);
        public static res material = new res("material", 0);
        public static res power = new res("power", 0);
        public static res food = new res("food", 0);
        public static res masks = new res("masks", 10);
        public static res reputation = new res("reputation", 100);
        public static events ev1 = new events ("Shopping day!", "According to doctors, people should not stay close to each other. Do you want to close most of the shops to assure the obedience?", 1);
        public static events ev2 = new events("Celebration", "People want to celebrate the anniversary of your rule! Shall you allow them to do it?", 2);
        public static events ev3 = new events("Despotism", "People are organising illegal meetings and celebrations. Send the police to stop them?", 1);
        public static events ev4 = new events("Ding-dong!", "People need to eat, you know. But they have to stay at home. Organise food delivery?", 1);
        public static events ev5 = new events("Safety and sound", "A famous music group is passsing by and want to perform in the city. Let them in?", 2);
        public static events ev6 = new events("Festive!", "An annual 'Day of despotism' festival is coming. Let the celebrations happen?", 2);
        public static events ev7 = new events("Food dilemma", "People are afraid of food made by the factory because the witch doctor Granny Zinaida said COVID-19 may be transferred trough food. Reduce the output of the factory?", 2);
        public static events ev8 = new events("Vaccine!", "Congratulations! Doctors in your city found a vaccine against the virus! The pandemy will be over in 10 days!", 1);
    }
}
