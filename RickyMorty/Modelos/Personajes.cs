namespace RickyMorty.Modelos {
    public class PersonajeRespuesta {
        public Info info { get; set; }
        public List<Personaje> results { get; set; }
    }

    public class Info {
        public int count { get; set; }
        public int pages { get; set; }
    }

    public class Personaje {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string image { get; set; }
    }
}

