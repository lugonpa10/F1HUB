<?php
class Publicaciones
{
    private $baseUrl;

    public function __construct()
    {
        $this->baseUrl = "http://localhost:8080/f1hub/rest/publicaciones";
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
       return json_decode($response,true) ?? $httpCode;
    }

    public function subirPublicacion($idUsuario, $texto)
    {
        $datos = [
            'usuario' => ['idUsuario' => $idUsuario],
            'texto' => $texto
        ];
        return $this->request('POST', '/subir', $datos);
    }

    public function obtenerPublicaciones($idUsuario)
    {
        return $this->request('GET', '/' . $idUsuario, null);
    }

    public function eliminarPublicacion($id)
    {
        return $this->request('DELETE', '/' . $id, null);
    }

    public function obtenerTodas(){
        return $this->request('GET', '/todas', null);
    }
}