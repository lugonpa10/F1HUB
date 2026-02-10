<?php
require_once 'modelos/Usuario.php';

class ControladorRegistro
{
    public function registroPaso1()
    {
        if ($_SERVER['REQUEST_METHOD'] == $_POST) {
            session_start();
            $_SESSION['datos_registro'] = $_POST;

            header('Location: index.php?action=registro2');
        }
    }

    public function registroPaso2()
    {
        if ($_SERVER['REQUEST_METHOD'] == 'POST') {


            $password = $_POST['password'];
            $confirm_password = $_POST['confirm_password'];

            if ($password != $confirm_password) {
                echo "Las contraseñas no coinciden";
                return;
            }

            $datosRegistro1 = $_SESSION['datos_registro'];

        }

        try {

            $usuario = new Usuario();
            $resultado = $usuario->registro(
                $datosRegistro1['nombre'],
                $datosRegistro1['apellidos'],
                $datosRegistro1['email'],
                $datosRegistro1['fechaNacimiento'],
                $datosRegistro1['nombreUsuario'],
                $datosRegistro1['genero'],
                $password
            );

            if ($resultado) {
                unset($_SESSION['datos_registro']);

                header('Location: index.php?action=inicioSesion&success=1');
                exit();
            }
        } catch (Exception $e) {
            header('Location: index.php?action=registro_paso1&error=api');
            exit();
        }
    }
}
