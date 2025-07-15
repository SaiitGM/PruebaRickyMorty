using System.Net.Http.Json;
using RickyMorty.Modelos;

namespace RickyMorty.Servicios {
    public class PersonajeServicios {
        private readonly HttpClient _http;

        public PersonajeServicios(HttpClient http) {
            _http = http;
        }

        public async Task<List<Personaje>> GetCharactersAsync() {
            var result = await _http.GetFromJsonAsync<PersonajeRespuesta>("https://rickandmortyapi.com/api/character");
            return result.results;
        }
    }
}