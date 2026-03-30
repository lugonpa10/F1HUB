using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using F1HUB.Models;

namespace F1HUB.Services
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly JavaScriptSerializer _serializer;

        public ApiClient()
        {
            var baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            if (string.IsNullOrWhiteSpace(baseUrl))
            {
                baseUrl = "http://localhost:8080/f1hub/rest/";
            }

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl.EndsWith("/") ? baseUrl : baseUrl + "/")
            };
            _serializer = new JavaScriptSerializer();
        }

        public async Task<Usuario> IniciarSesionAsync(string nombreUsuario, string password)
        {
            var payload = new Dictionary<string, object>
            {
                ["nombreUsuario"] = nombreUsuario,
                ["passwordHash"] = password
            };

            var response = await EnviarJsonAsync(HttpMethod.Post, "usuarios/inicioSesion", payload);
            if (response.StatusCode == HttpStatusCode.NotFound || response.StatusCode == HttpStatusCode.Unauthorized)
            {
                return null;
            }

            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return ParseUsuario(content);
        }

        public async Task<bool> RegistrarUsuarioAsync(Usuario usuario)
        {
            var payload = new Dictionary<string, object>
            {
                ["nombre"] = usuario.Nombre,
                ["apellidos"] = usuario.Apellidos,
                ["nombreUsuario"] = usuario.NombreUsuario,
                ["passwordHash"] = usuario.PasswordHash,
                ["email"] = usuario.Email,
                ["genero"] = usuario.Genero,
                ["fechaNacimiento"] = usuario.FechaNacimiento
            };

            var response = await EnviarJsonAsync(HttpMethod.Post, "usuarios/registro", payload);
            return response.StatusCode == HttpStatusCode.Created || response.IsSuccessStatusCode;
        }

        public async Task<bool> EditarUsuarioAsync(Usuario usuario)
        {
            var payload = new Dictionary<string, object>
            {
                ["nombreUsuario"] = usuario.NombreUsuario,
                ["nombre"] = usuario.Nombre,
                ["apellidos"] = usuario.Apellidos,
                ["email"] = usuario.Email,
                ["fechaNacimiento"] = usuario.FechaNacimiento,
                ["genero"] = usuario.Genero
            };

            var response = await EnviarJsonAsync(HttpMethod.Put, "usuarios/editar", payload);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> SubirPublicacionAsync(int idUsuario, string texto)
        {
            var payload = new Dictionary<string, object>
            {
                ["usuario"] = new Dictionary<string, object> { ["idUsuario"] = idUsuario },
                ["texto"] = texto
            };

            var response = await EnviarJsonAsync(HttpMethod.Post, "publicaciones/subir", payload);
            return response.IsSuccessStatusCode;
        }

        public async Task<List<Publicacion>> ObtenerTodasPublicacionesAsync()
        {
            var response = await _httpClient.GetAsync("publicaciones/todas");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return ParsePublicaciones(content, true);
        }

        public async Task<List<Publicacion>> ObtenerPublicacionesUsuarioAsync(int idUsuario, string nombreUsuario)
        {
            var response = await _httpClient.GetAsync("publicaciones/" + idUsuario);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return ParsePublicaciones(content, false, nombreUsuario);
        }

        public async Task<bool> EliminarPublicacionAsync(int idPublicacion)
        {
            var response = await _httpClient.DeleteAsync("publicaciones/" + idPublicacion);
            return response.IsSuccessStatusCode;
        }

        private async Task<HttpResponseMessage> EnviarJsonAsync(HttpMethod method, string relativeUrl, object payload)
        {
            var json = _serializer.Serialize(payload);
            var request = new HttpRequestMessage(method, relativeUrl)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            return await _httpClient.SendAsync(request);
        }

        private Usuario ParseUsuario(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                return null;
            }

            var data = _serializer.DeserializeObject(json) as Dictionary<string, object>;
            if (data == null)
            {
                return null;
            }

            return new Usuario
            {
                IdUsuario = ToInt(data, "idUsuario"),
                Nombre = ToString(data, "nombre"),
                Apellidos = ToString(data, "apellidos"),
                NombreUsuario = ToString(data, "nombreUsuario"),
                Email = ToString(data, "email"),
                Genero = ToString(data, "genero"),
                FechaNacimiento = ToDateString(data, "fechaNacimiento")
            };
        }

        private List<Publicacion> ParsePublicaciones(string json, bool includeUsuario, string fallbackNombreUsuario = "")
        {
            var result = new List<Publicacion>();
            if (string.IsNullOrWhiteSpace(json))
            {
                return result;
            }

            var array = _serializer.DeserializeObject(json) as object[];
            if (array == null)
            {
                return result;
            }

            foreach (var item in array)
            {
                var dict = item as Dictionary<string, object>;
                if (dict == null)
                {
                    continue;
                }

                Usuario usuario;
                if (includeUsuario)
                {
                    var usuarioData = dict.ContainsKey("usuario") ? dict["usuario"] as Dictionary<string, object> : null;
                    usuario = new Usuario
                    {
                        NombreUsuario = ToString(usuarioData, "nombreUsuario")
                    };
                }
                else
                {
                    usuario = new Usuario { NombreUsuario = fallbackNombreUsuario };
                }

                result.Add(new Publicacion
                {
                    IdPubli = ToInt(dict, "idPubli", "id_publicacion"),
                    Texto = ToString(dict, "texto"),
                    FechaPublicacion = ToLong(dict, "fechaPublicacion"),
                    Usuario = usuario
                });
            }

            return result;
        }

        private static int ToInt(Dictionary<string, object> data, params string[] keys)
        {
            if (data == null)
            {
                return 0;
            }

            foreach (var key in keys)
            {
                if (!data.ContainsKey(key) || data[key] == null)
                {
                    continue;
                }

                if (int.TryParse(data[key].ToString(), out var value))
                {
                    return value;
                }
            }

            return 0;
        }

        private static long ToLong(Dictionary<string, object> data, params string[] keys)
        {
            if (data == null)
            {
                return 0;
            }

            foreach (var key in keys)
            {
                if (!data.ContainsKey(key) || data[key] == null)
                {
                    continue;
                }

                if (long.TryParse(data[key].ToString(), out var value))
                {
                    return value;
                }
            }

            return 0;
        }

        private static string ToString(Dictionary<string, object> data, params string[] keys)
        {
            if (data == null)
            {
                return string.Empty;
            }

            foreach (var key in keys)
            {
                if (data.ContainsKey(key) && data[key] != null)
                {
                    return data[key].ToString();
                }
            }

            return string.Empty;
        }

        private static string ToDateString(Dictionary<string, object> data, string key)
        {
            if (data == null || !data.ContainsKey(key) || data[key] == null)
            {
                return string.Empty;
            }

            var raw = data[key].ToString();
            if (long.TryParse(raw, out var millis))
            {
                var date = DateTimeOffset.FromUnixTimeMilliseconds(millis).DateTime;
                return date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            }

            DateTime parsed;
            if (DateTime.TryParse(raw, out parsed))
            {
                return parsed.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            }

            return raw;
        }
    }
}
