<?php
class Usuario
{
    private $baseUrl;

    public function __construct()
    {
        $this->baseUrl = "http://192.130.0.125:8080/f1hub/rest/usuarios";
    }


    private function request($method, $url, $data = null)
    {
        // Inicializa la conexión cURL a la URL completa
        $ch = curl_init($this->baseUrl . $url);
        // Hace que la respuesta se devuelva como texto
        // y no se imprima directamente en pantalla
        curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
        // Define el método HTTP dinámicamente
        curl_setopt($ch, CURLOPT_CUSTOMREQUEST, $method);
        // Si hay datos, los enviamos en formato JSON
        if ($data) {
            // Indicamos al servidor que enviamos JSON
            curl_setopt($ch, CURLOPT_HTTPHEADER, [
                'Content-Type: application/json'
            ]);
            // Convertimos el array PHP a JSON
            curl_setopt($ch, CURLOPT_POSTFIELDS, json_encode($data));
        }
        // Ejecuta la petición HTTP
        $response = curl_exec($ch);
        // Si hay errores de conexión, lanzamos excepción
        if (curl_errno($ch)) {
            throw new Exception("Error en la API: " . curl_error($ch));
        }
        // Cerramos la conexión para liberar memoria
        curl_close($ch);
        // Convertimos JSON → objeto PHP
        // Permite acceder como $empleado->nombre
        return json_decode($response);
    }

    public function registro($nombre, $apellidos, $correo, $fechaNacimiento, $nombreUsuario, $genero, $password)
    {
        $datos = [

        'nombre' => $nombre,
        'apellidos' => $apellidos,
        'correo' => $correo,
        'fechaNacimiento' => $fechaNacimiento,
        'nombreUsuario' => $nombreUsuario,
        'genero' => $genero,
        'password' => $password
        ];

        return $this->request('POST','',$datos);

    }

    
}
