<?php
require_once 'modelos/Usuario.php';
class ControladorPerfil
{
    public function editar()
    {
        if (session_status() === PHP_SESSION_NONE) {
            session_start();
        }

        $usuario = $_SESSION['usuario'];
        $nombre = $_POST['nombre'];
        $apellidos = $_POST['apellidos'];
        $email = $_POST['email'];
        $fechaNacimiento = $_POST['fechaNacimiento'];
        $genero = $_POST['genero'];

        $usuarioModel = new Usuario();
        $resultado = $usuarioModel->editarUsuario(
            $usuario->nombreUsuario,
            $nombre,
            $apellidos,
            $fechaNacimiento,
            $email,
            $genero
        );

       

        if ($resultado) {
            $_SESSION['usuario']->nombre = $nombre;
            $_SESSION['usuario']->apellidos = $apellidos;
            $_SESSION['usuario']->email = $email;
            $_SESSION['usuario']->fechaNacimiento = $fechaNacimiento;
            $_SESSION['usuario']->genero = $genero;
            header('Location: index.php?action=perfil&success=1');
        } else {
            header('Location: index.php?action=perfil&error=1');
        }
        exit();
    }
}
