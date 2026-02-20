<?php
class Usuario
{
    private $baseUrl;

    public function __construct()
    {
        $this->baseUrl = "http://localhost:8080/f1hub/rest/usuarios";
    }


    private function request($method, $url, $data = null)
    {


        $ch = curl_init($this->baseUrl . $url);
        curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
        curl_setopt($ch, CURLOPT_CUSTOMREQUEST, $method);
        if ($data) {
            curl_setopt($ch, CURLOPT_HTTPHEADER, ['Content-Type: application/json']);
            curl_setopt($ch, CURLOPT_POSTFIELDS, json_encode($data));
        }
        $response = curl_exec($ch);
        if (curl_errno($ch)) {
            throw new Exception("Error en la API: " . curl_error($ch));
        }
        $httpCode = curl_getinfo($ch, CURLINFO_HTTP_CODE);
        curl_close($ch);


        $decoded = json_decode($response);
        return $decoded !== null ? $decoded : $httpCode;
    }

    public function registro($nombre, $apellidos, $correo, $fechaNacimiento, $nombreUsuario, $genero, $password)
    {
        $datos = [

            'nombre' => $nombre,
            'apellidos' => $apellidos,
            'email' => $correo,
            'fechaNacimiento' => $fechaNacimiento,
            'nombreUsuario' => $nombreUsuario,
            'genero' => $genero,
            'passwordHash' => $password
        ];

        return $this->request('POST', '/registro', $datos);
    }

    public function login($nombreUsuario, $password)
    {
        $datos = [
            'nombreUsuario' => $nombreUsuario,
            'passwordHash' => $password
        ];
        return $this->request('POST', '/inicioSesion', $datos);
    }

    public function editarUsuario($nombreUsuario, $nombre, $apellidos, $fechaNacimiento, $correo, $genero)
    {

        $datos = [
            'nombreUsuario' => $nombreUsuario,
            'nombre' => $nombre,
            'apellidos' => $apellidos,
            'email' => $correo,
            'fechaNacimiento' => $fechaNacimiento,
            'genero' => $genero
        ];
        return $this->request('PUT','/editar',$datos);
    }
}
