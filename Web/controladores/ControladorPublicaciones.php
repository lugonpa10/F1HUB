<?php
require_once 'modelos/Publicaciones.php';

class ControladorPublicaciones
{
    public function subir()
    {
        if (session_status() === PHP_SESSION_NONE) {

            session_start();
        }

        $usuario = $_SESSION['usuario'];
        $texto = $_POST['texto'];



        $publicacionesModel = new Publicaciones();
        $publicacionesModel->subirPublicacion($usuario->idUsuario, $texto);

        header('Location: index.php?action=Muro');
        exit();
    }

    public function eliminar()
    {
        if (session_status() === PHP_SESSION_NONE) {
            session_start();
        }

        $id = $_POST['id'];
        $publicacionesModel = new Publicaciones();
        $publicacionesModel->eliminarPublicacion($id);

        header('Location: index.php?action=perfil');
        exit();
    }

    public function obtener($idUsuario)
    {
        $publicacionesModel = new Publicaciones();
        return $publicacionesModel->obtenerPublicaciones($idUsuario);
    }

    public function obtenerTodas()
    {
        $publicacionesModel = new Publicaciones();
        return $publicacionesModel->obtenerTodas();
    }
}
